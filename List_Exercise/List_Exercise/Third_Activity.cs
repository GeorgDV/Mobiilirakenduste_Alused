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

            SetContentView(Resource.Layout.Third_Layout);

            var queryString = "https://swapi.co/api/people/?search=darth";
            var data = DataService.GetDataFromService(queryString);
        }
    }
}