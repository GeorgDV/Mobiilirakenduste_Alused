using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LanguagePage : ContentPage
	{
        public ObservableCollection<string> Languages { get; set; }

        public string selectedLanguage;


        public LanguagePage ()
		{
			InitializeComponent ();
            AddLanguageBtn.Clicked += AddLanguageBtn_Clicked;

            Languages = new ObservableCollection<string>
            {
                "English",
                "Russian",
                "Italian",
                "Spanish",
                "Estonian",
                "Latvian",
                "Lithuanian",
                "Chinese",
                "Korean",
                "Japanese",
                "Nigerian"
            };

            Languages_ListView.ItemsSource = Languages;
        }

        private void AddLanguageBtn_Clicked(object sender, EventArgs e)
        {
            Languages.Add("Test Language");
        }

        private void Languages_ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selectedLanguage = e.Item as string;
            LanguageEditor.Text = selectedLanguage;
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            var edit = Languages.FirstOrDefault(x => x == selectedLanguage);
            if (edit != null)
            {
                edit = LanguageEditor.Text;
            }
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if (selectedLanguage != null)
            {
                Languages.Remove(selectedLanguage);
            }
        }
    }
}