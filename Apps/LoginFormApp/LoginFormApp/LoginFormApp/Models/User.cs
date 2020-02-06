using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginFormApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
