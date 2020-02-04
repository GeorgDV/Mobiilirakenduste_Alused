using CrossPlatformApp.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CrossPlatformApp
{
    public partial class App : Application
    {
        static ApplicationDatabase _dbContext;
        public static ApplicationDatabase dbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new ApplicationDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return _dbContext;
            }
        }

        //public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent();
            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));


            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
