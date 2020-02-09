﻿using LoginFormApp.Models;
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

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
            string username = UserNameEntry.Text;
            string password = PasswordEntry.Text;
            if ((username == "" && password == "") || (username == "" || password == ""))
            {
                OutputLabel.Text = "Username and/or Password field cannot be empty!";
            }
            else if (UserExists(username, password))
            {
                var user = App.dbContext.GetUserByNameAndPassword(username, password).Result;
                OutputLabel.Text = "";
                UserNameEntry.Text = "";
                PasswordEntry.Text = "";

                var loggedInPage = new LoggedInPage();
                loggedInPage.BindingContext = user;
                await Navigation.PushAsync(loggedInPage);
            }
            else if (!UserExists(username, password))
            {
                OutputLabel.Text = "User does not exist!";
            }
            else
            {
                OutputLabel.Text = "Unexpected error occured.";
            }

        }

        private async void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
            string newUsername = UserNameEntry.Text;
            string newPassword = PasswordEntry.Text;

            if ((newUsername == "" && newPassword == "") || (newUsername == "" || newPassword == ""))
            {
                OutputLabel.Text = "Username and/or Password field cannot be empty!";
            }
            else if ((!UserExists(newUsername, newPassword)) && (newUsername != string.Empty && newPassword != string.Empty))
            {
                var newUser = new User() { UserName = newUsername, Password = newPassword };
                await App.dbContext.SaveUserAsync(newUser);
                OutputLabel.Text = "User successfully registered!";
                UserNameEntry.Text = "";
                PasswordEntry.Text = "";
            }
            else if (UserExists(newUsername, newPassword))
            {
                OutputLabel.Text = "User already exists!";
            }
            else
            {
                OutputLabel.Text = "Unexpected error occured.";
            }
        }

        private bool UserExists(string username, string password)
        {
            var GetUser = App.dbContext.GetUserByNameAndPassword(username, password);
            var user = GetUser.Result;

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
