using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string ImgPath { get; set; }
        public DateTime Date { get; set; }
    }
}
