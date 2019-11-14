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
    [Activity(Label = "Starships_Activity")]
    public class Starships_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Starships_Layout);

            var searchBar3 = FindViewById<EditText>(Resource.Id.searchEditTextStarships);
            var searchButton3 = FindViewById<Button>(Resource.Id.searchButtonStarships);
            var starshipsListView = FindViewById<ListView>(Resource.Id.starshipsListView);

            searchButton3.Click += async delegate
            {
                string searchWord = searchBar3.Text;
                string queryString = "https://swapi.co/api/starships/?search=" + searchWord;
                var data = await DataServiceStarships.GetStarWarsStarships(queryString);
                starshipsListView.Adapter = new StarWarsStarshipsAdapter(this, data.Results);

            };

        }
    }
}