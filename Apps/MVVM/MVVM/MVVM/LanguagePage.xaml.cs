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

        public LanguagePage ()
		{
			InitializeComponent ();
            LanguageBtn.Clicked += LanguageBtn_Clicked;

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

        private async void LanguageBtn_Clicked(object sender, EventArgs e)
        {
            return;
        }

        private void Languages_ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }
    }
}