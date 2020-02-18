using InstagramApp.Models;
using System;
using System.Collections.Generic;
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

            //Posts =  App.dbContext.GetPostsAsync;
        }
    }
}
