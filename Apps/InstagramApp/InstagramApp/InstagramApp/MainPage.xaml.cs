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
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // USE IF VIEWMODEL DONT WORK
            Posts_ListView.ItemsSource = Task.Run(async () => await App.dbContext.GetPostsAsync()).Result;
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

        private async void AddDummyPost_Clicked(object sender, EventArgs e)
        {
            Post dummyPost = new Post() { Title = "Dummy Post", Date = DateTime.Now };
            await App.dbContext.SavePostAsync(dummyPost);
        }
    }
}
