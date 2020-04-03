using System;
using System.ComponentModel;
using InstagramApp.Models;
using InstagramApp.ViewModels;
using Xamarin.Forms;

namespace InstagramApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            //USE IF VIEWMODEL NOT WORK
            //Posts_ListView.ItemsSource = Task.Run(async () => await App.dbContext.GetPostsAsync()).Result;
            (this.BindingContext as PostsViewModel)?.RefreshList();
        }



        private async void AddNewPostBtn_Clicked(object sender, EventArgs e)
        {
            var user = base.Parent.BindingContext as User;

            await Navigation.PushAsync(new AddPostPage
            {
                BindingContext =  user
            });
        }
               
        private async void PostImage_Tapped(object sender, EventArgs e)
        {
            var image = sender as Image;
            var post = image.BindingContext as Post;

            if (post == null)
            {
                return;
            }

            await Navigation.PushAsync(new PostDetailsPage
            {
                BindingContext = post,
            });
            
        }

        private async void PostImage_DoubleTapped(object sender, EventArgs e)
        {
            var user = base.Parent.BindingContext as User;
            var image = sender as Image;
            var post = image.BindingContext as Post;

            if (post.HasBeenLikedByUser == false)
            {
                post.LikeCount++;
                post.HasBeenLikedByUser = true;
            }
            else
            {
                post.LikeCount--;
                post.HasBeenLikedByUser = false;
            }

            await App.dbContext.Posts_SavePostAsync(post);
            (this.BindingContext as PostsViewModel)?.RefreshList();
        }

        private async void LikePost_Button_Clicked(object sender, EventArgs e)
        {
            var user = base.Parent.BindingContext as User;
            var button = sender as ImageButton;
            var post = button.BindingContext as Post;

            if (post.HasBeenLikedByUser == false)
            {
                post.LikeCount++;
                post.HasBeenLikedByUser = true;
            }
            else
            {
                post.LikeCount--;
                post.HasBeenLikedByUser = false;
            }

            await App.dbContext.Posts_SavePostAsync(post);
            (this.BindingContext as PostsViewModel)?.RefreshList();
        }

        private async void CommentPost_Button_Clicked(object sender, EventArgs e)
        {
            //var user = base.Parent.BindingContext;
            var button = sender as ImageButton;
            var post = button.BindingContext;

            await Navigation.PushAsync(new AddCommentPage
            {
                BindingContext = post
            });
        }
    }
}
