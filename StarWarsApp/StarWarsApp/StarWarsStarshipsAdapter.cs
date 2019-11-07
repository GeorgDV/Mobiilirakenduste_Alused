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
using StarWarsApp.Core.Models;

namespace StarWarsApp
{
    class StarWarsStarshipsAdapter : BaseAdapter<StarshipsDetails>
    {
        List<StarshipsDetails> _items;
        Activity _context;

        public StarWarsStarshipsAdapter(Activity context, List<StarshipsDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override StarshipsDetails this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            View view = convertView;

            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.starships_row_layout, null);

            view.FindViewById<TextView>(Resource.Id.textViewStarships1).Text = "Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.textViewStarships2).Text = "Class: " + item.Starship_Class;
            view.FindViewById<TextView>(Resource.Id.textViewStarships3).Text = "Model: " + item.Model;
            view.FindViewById<TextView>(Resource.Id.textViewStarships4).Text = "Manufacturer: " + item.Manufacturer;
            view.FindViewById<TextView>(Resource.Id.textViewStarships5).Text = "Length: " + item.Length.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewStarships6).Text = "Cargo Space: " + item.Cargo_Capacity.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewStarships7).Text = "Consumables: " + item.Consumables;
            view.FindViewById<TextView>(Resource.Id.textViewStarships8).Text = "Crew: " + item.Crew.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewStarships9).Text = "Passengers: " + item.Passengers.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewStarships10).Text = "Max Atm. Speed: " + item.Max_Atmosphering_Speed;
            view.FindViewById<TextView>(Resource.Id.textViewStarships11).Text = "Hyperdrive: " + item.Hyperdrive_Rating;
            view.FindViewById<TextView>(Resource.Id.textViewStarships12).Text = "Mglt: " + item.Mglt.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewStarships13).Text = "Cost (Credits): " + item.Cost_In_Credits;



            return view;
        }

    }
}