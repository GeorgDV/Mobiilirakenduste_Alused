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
    public partial class AddCommentPage : ContentPage
    {
        public AddCommentPage()
        {
            InitializeComponent();
        }

        private async void SaveCommentBtn_Clicked(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            if (CommentContentEntry.Text == "")
            {
                ErrorLabel.Text = "Comment Content is required!";
            }
            else
            {
                var comment = new Comment();
                var post = (Post)BindingContext;

                comment.PostId = post.Id;
                comment.UserName = post.UserName;
                comment.UserPhotoPath = post.UserPhotoPath;
                comment.Content = CommentContentEntry.Text.ToString();
                comment.Date = DateTime.Now;

                await App.dbContext.Comments_SaveCommentAsync(comment);
                await Navigation.PopAsync();
            }
        }
    }
}