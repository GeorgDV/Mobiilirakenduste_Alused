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
        }
    }
}