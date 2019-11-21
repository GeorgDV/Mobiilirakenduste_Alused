using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StarWarsApp.Core;
using Newtonsoft.Json;
using static Android.Widget.AdapterView;

namespace StarWarsApp
{
    [Activity(Label = "Movies_Activity")]
    public class Movies_Activity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Movies_Layout);

            var moviesListView = FindViewById<ListView>(Resource.Id.moviesListView);

            string queryString = "https://swapi.co/api/films/";
            var data = await DataServiceMovies.GetStarWarsMovies(queryString);
            moviesListView.Adapter = new StarWarsMoviesAdapter(this, data.Results);

            moviesListView.ItemClick += (object sender, ItemClickEventArgs e) =>
            {
                //var clickPostitionText = moviesListView.GetItemAtPosition(e.Position); // Show text
                //var clickPostitionID = Convert.ToString(e.Position); // Show index
                var movieDetails = data.Results[e.Position];

                var intent = new Intent(this, typeof(MovieDetailsActivity));
                intent.PutExtra("movieDetails", JsonConvert.SerializeObject(movieDetails));
                StartActivity(intent);
            };
        }
    }
}