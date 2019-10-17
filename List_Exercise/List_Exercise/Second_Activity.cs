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
    [Activity(Label = "Second_Activity")]
    public class Second_Activity : Activity
    {
        List<Car> _items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second_Layout);

            _items = new List<Car>()
            {
                new Car(){Name = "Audi", Manufacturer = "Germany", Model = "R8", KW= "316 kW", Year= "2006"},
                new Car(){Name = "BMW", Manufacturer = "Germany", Model = "700", KW= "30 kW", Year= "1956"},
                new Car(){Name = "Opel", Manufacturer = "Germany", Model = "Speedster", KW= "108 kW", Year= "2001"},
                new Car(){Name = "Citroën", Manufacturer = "France", Model = "C8", KW= "94 kW", Year= "2002"},
                new Car(){Name = "Škoda", Manufacturer = "Czech Republic", Model = "Octavia", KW= "44 kW", Year= "1996"},
                new Car(){Name = "Peugeot", Manufacturer = "France", Model = "2008", KW= "122 kW", Year= "2013"},
                new Car(){Name = "Fiat", Manufacturer = "Italy", Model = "500X", KW= "88 kW", Year= "2014"},
                new Car(){Name = "Ferrari", Manufacturer = "Italy", Model = "812 Superfast", KW= "588 kW", Year= "2017"},
                new Car(){Name = "Maserati", Manufacturer = "Italy", Model = "Levante", KW= "440 kW", Year= "2016"},
            };

            var listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new BasicAdapterCar(this, _items);


        }
    }
}