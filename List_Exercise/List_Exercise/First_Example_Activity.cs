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

namespace List_Exercise
{
    [Activity(Label = "First_Example_Activity")]
    public class First_Example_Activity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.First_Example_Layout);

            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1);
        }
    }
}