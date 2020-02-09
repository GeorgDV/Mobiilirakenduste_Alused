using LoginFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginFormApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoggedInPage : ContentPage
    {
        public LoggedInPage()
        {
            InitializeComponent();
        }

        private async void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            var user = (User)BindingContext;
            await App.dbContext.DeleteUserAsync(user);
            await Navigation.PopAsync();
        }
    }
}