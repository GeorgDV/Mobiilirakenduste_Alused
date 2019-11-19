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
using List_Exercise.Core;

namespace List_Exercise
{
    [Activity(Label = "Third_Activity")]
    public class Third_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.StarWars_People_Layout);

            var searchBar = FindViewById<TextView>(Resource.Id.editText1);
            var listView = FindViewById<ListView>(Resource.Id.listView1);
            var searchBtn = FindViewById<Button>(Resource.Id.srchBtn_01);

            searchBtn.Click += async delegate
            {
                string searchWord = searchBar.Text;
                var queryString = "https://swapi.co/api/people/?search=" + searchWord;
                var data = await DataService.GetStarWarsPeople(queryString);
                listView.Adapter = new BasicAdapterStarWars(this, data.Results);
            };
        }
    }

}