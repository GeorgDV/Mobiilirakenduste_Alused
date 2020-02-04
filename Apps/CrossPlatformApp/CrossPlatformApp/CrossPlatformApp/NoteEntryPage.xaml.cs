using CrossPlatformApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatformApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoteEntryPage : ContentPage
	{
		public NoteEntryPage ()
		{
			InitializeComponent ();
		}

        async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date = DateTime.UtcNow;
            await App.dbContext.SaveNoteAsync(note);


            //LOCAL NOTES DB CODE
            //if (string.IsNullOrWhiteSpace(note.Filename))
            //{
            //    var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
            //    File.WriteAllText(filename, note.Text);
            //}
            //else
            //{
            //    File.WriteAllText(note.Filename, note.Text);
            //}

            await Navigation.PopAsync();
        }

        async void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.dbContext.DeleteNoteAsync(note);

            //LOCAL DB CODE
            //if (File.Exists(note.Filename))
            //{
            //    File.Delete(note.Filename);
            //}

            await Navigation.PopAsync();
        }
    }
}