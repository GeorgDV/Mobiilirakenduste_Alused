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
            var user = base.Parent.BindingContext;

            await Navigation.PushAsync(new AddPostPage
            {
                BindingContext =  user
            });
        }
               
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var stackLayout = sender as StackLayout;
            var post = stackLayout.BindingContext as Post;

            if (post == null)
            {
                return;
            }

            await Navigation.PushAsync(new PostDetailsPage
            {
                BindingContext = post,
            });
            
        }

        private async void TapGestureRecognizer_DoubleTapped(object sender, EventArgs e)
        {
            var stackLayout = sender as StackLayout;
            var post = stackLayout.BindingContext as Post;

            post.LikeCount++;

            await App.dbContext.Posts_SavePostAsync(post);
            (this.BindingContext as PostsViewModel)?.RefreshList();
        }
    }
}
