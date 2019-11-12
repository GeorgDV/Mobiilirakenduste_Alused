using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;
using System;
using Android.Content;

namespace StarWarsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toPeopleBtn = FindViewById<Button>(Resource.Id.toPeopleButton);
            var toPlanetsBtn = FindViewById<Button>(Resource.Id.toPlanetsButton);
            var toStarshipsBtn = FindViewById<Button>(Resource.Id.toStarshipsButton);
            var toMoviesListBtn = FindViewById<Button>(Resource.Id.toMoviesListButton);

            toPeopleBtn.Click += ToPeopleBtn_Click;
            toPlanetsBtn.Click += ToPlanetsBtn_Click;
            toStarshipsBtn.Click += ToStarshipsBtn_Click;
            toMoviesListBtn.Click += ToMoviesListBtn_Click;

        }

        private void ToPeopleBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(People_Activity));
            this.StartActivity(intent);
        }
        private void ToPlanetsBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Planets_Activity));
            this.StartActivity(intent);
        }
        private void ToStarshipsBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Starships_Activity));
            this.StartActivity(intent);
        }
        private void ToMoviesListBtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Movies_Activity));
            this.StartActivity(intent);
        }
    }
}