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
	public partial class AddPostPage : ContentPage
	{
		public AddPostPage ()
		{
			InitializeComponent ();
		}

        private async void TakePictureBtn_Clicked(object sender, EventArgs e)
        {
            var post = (Post)BindingContext;
            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });

            post.ImgPath = PhotoImage.Source.ToString();
        }
    }
}