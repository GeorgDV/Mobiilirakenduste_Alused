using InstagramApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.ViewModels
{
    public class PostsViewModel : INotifyPropertyChanged
    {
        public  PostsViewModel()
        {
            Posts = new List<Post>();

            Posts = Task.Run(async () => await App.dbContext.GetPostsAsync()).Result;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        //public List<Post> Posts { get; set; }
        private List<Post> _posts;
        public List<Post> Posts
        {
            get
            {
                return _posts;
            }

            set
            {
                if (_posts != value)
                {
                    _posts = value;
                    OnPropertyChanged(nameof(Posts));
                }
            }

        }
    }
}
