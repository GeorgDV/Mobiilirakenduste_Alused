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

        private async void AddNewPostBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPostPage
            {
                BindingContext = new Post()
            });
        }

        private async void Posts_ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PostDetailsPage
                {
                    BindingContext = e.SelectedItem as Post,
                });
            }
        }
    }
}
