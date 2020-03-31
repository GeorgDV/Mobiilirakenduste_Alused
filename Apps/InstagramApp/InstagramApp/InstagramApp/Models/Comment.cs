using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Models
{
    public class Comment
    {
        //USER INFO
        public string UserPhotoPath { get; set; }
        public string UserId { get; set; }

        //COMMENT INFO
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
