﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        public string ProfilePhotoPath { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}