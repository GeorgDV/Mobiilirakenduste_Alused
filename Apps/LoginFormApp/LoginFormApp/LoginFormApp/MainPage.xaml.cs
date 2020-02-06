using LoginFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginFormApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            /*
            User newUser = newUser()

            if (!UserExists(newUsername, newPassword))
            {
                App.dbContext.SaveUserAsync()
            }
            */
        }

        private bool UserExists(string username, string password)
        {
            return Convert.ToBoolean(App.dbContext.GetUserByNameAndPassword(username, password));
        }
    }
}
