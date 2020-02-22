using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailsPage : ContentPage
    {
        public PostDetailsPage()
        {
            InitializeComponent();
        }

        private async void DeletePostBtn_Clicked(object sender, EventArgs e)
        {
            var post = (Post)BindingContext;
            await App.dbContext.DeletePostAsync(post);
            await Navigation.PopAsync();
        }
    }
}