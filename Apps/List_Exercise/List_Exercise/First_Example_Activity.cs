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
        List<WeatherInfo> _items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //var items = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Valentine's Day", "Easter Day", "Christmas Day", "Independence Day", "New Year's Day", "Big Money Day", "Birthday", "Coconut Day", "International Hamburger Day", "My Mom's Birthday", "My Cat's Death Anniversary Day", "Friday The 13th", "Some Weird Day" };

            _items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name="Weekday:", Temperature="Temperature:", WindSpeed="Windspeed:"},
                new WeatherInfo(){Name = "Esmaspäev", Temperature = "12C", WindSpeed = "4m/s"},
                new WeatherInfo(){Name = "Teisipäev", Temperature = "9C", WindSpeed = "5m/s"},
                new WeatherInfo(){Name = "Kolmapäev", Temperature = "6C", WindSpeed = "3m/s"},
                new WeatherInfo(){Name = "Neljapäev", Temperature = "8C", WindSpeed = "2m/s"},
                new WeatherInfo(){Name = "Reede", Temperature = "11C", WindSpeed = "3m/s"},
                new WeatherInfo(){Name = "Laupäev", Temperature = "10C", WindSpeed = "5m/s"},
                new WeatherInfo(){Name = "Pühapäev", Temperature = "7C", WindSpeed = "7m/s"},

            };

            ListAdapter = new BasicAdapter(this, _items);


            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var item = _items[args.Position];

                Toast.MakeText(Application, item.Name, ToastLength.Short).Show();
            };
        }
    }
}