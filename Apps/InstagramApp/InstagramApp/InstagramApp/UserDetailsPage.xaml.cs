using InstagramApp.Models;
using Plugin.Media;
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
    public partial class UserDetailsPage : ContentPage
    {
        public UserDetailsPage()
        {
            InitializeComponent();
        }

        private async void TakePictureBtn_Clicked(object sender, EventArgs e)
        {
            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                ProfilePhoto.Source = photo.Path;
        }

        private async void SaveProfileBtn_Clicked(object sender, EventArgs e)
        {
            ErrorOutput.Text = "";
            var user = (User)BindingContext;
            string currentPath = ProfilePhoto.Source.ToString();
            string formattedPath = currentPath.Substring(6);
            if (UserNameEntry.Text != "")
            {
                UserName.Text = UserNameEntry.Text.ToString();
                UserNameEntry.Text = String.Empty;
                user.ProfilePhotoPath = formattedPath;
                user.UserName = UserNameEntry.Text.ToString();
                await App.userDbContext.SaveUserAsync(user);
            }
            else
            {
                ErrorOutput.Text = "Username can't be empty!";
            }
        }

        private async void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            await App.userDbContext.DeleteUserAsync(user);
            await Navigation.PopAsync();
        }
    }
}