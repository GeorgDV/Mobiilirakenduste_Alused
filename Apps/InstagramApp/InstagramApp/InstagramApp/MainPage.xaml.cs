using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InstagramApp
{
    public partial class MainPage : ContentPage
    {
        public List<Post> Posts { get; set; }
        public Post selectedPost { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            Posts = await App.dbContext.GetPostsAsync();
            Posts_ListView.ItemsSource = Posts;
        }

        private async void AddPostBtn_Clicked(object sender, EventArgs e)
        {
            Post dummyPost = new Post();
            dummyPost.Title = "Test Post";
            dummyPost.Date = DateTime.Now;

            await App.dbContext.SavePostAsync(dummyPost);
        }

        private async void DeletePostBtn_Clicked(object sender, EventArgs e)
        {
            if (selectedPost != null)
            {
                await App.dbContext.DeletePostAsync(selectedPost);
            }
        }

        private void Posts_ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            selectedPost = e.Item as Post;
        }

        private async void AddNewPostBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPostPage
            {
                BindingContext = new Post()
            });
        }
    }
}
