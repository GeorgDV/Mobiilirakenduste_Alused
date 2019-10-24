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
    public class Third_Activity : ListActivity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var queryString = "https://swapi.co/api/people/?search=darth";

            var data = await DataService.GetStarWarsPeople(queryString);
            ListAdapter = new BasicAdapterStarWars(this, data.Results);
        }
    }
}