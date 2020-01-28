using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatformApp
{
    public partial class MainPage : ContentPage
    {
        string localDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string _filePath = "";
        string[] _files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        Dictionary<string, string> filesDict = new Dictionary<string, string>();

        public MainPage()
        {
            InitializeComponent();
            GetFilesDictionary(_files);
        }

        public void GetFilesDictionary(string[] filePaths)
        {
            foreach (string path in filePaths)
            {
                string[] currFilePathParts = path.Split(new[] { "\\" }, StringSplitOptions.None);
                string currFileName = currFilePathParts[currFilePathParts.Length - 1];
                filesDict.Add(currFileName, path);
            }
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            _filePath = Path.Combine(localDataFolder, FileNameEntry.Text + ".txt");
            File.WriteAllText(_filePath, textEditor.Text);
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            _filePath = Path.Combine(localDataFolder, FileNameEntry.Text + ".txt");
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
                textEditor.Text = string.Empty;
            }
            else
            {
                textEditor.Text = "No Such File Found to Delete.";
            }
        }

        private void ReadFileBtn_Clicked(object sender, EventArgs e)
        {
            if (FileNameEntry.Text != "")
            {
                _filePath = Path.Combine(localDataFolder, FileNameEntry.Text + ".txt");
            }

            if (File.Exists(_filePath))
            {
                textEditor.Text = File.ReadAllText(_filePath);
            }
            else
            {
                textEditor.Text = "No Such File Found to Read.";
            }
        }

        private void ClearAllBtn_Clicked(object sender, EventArgs e)
        {
            textEditor.Text = string.Empty;
        }
    }
}
