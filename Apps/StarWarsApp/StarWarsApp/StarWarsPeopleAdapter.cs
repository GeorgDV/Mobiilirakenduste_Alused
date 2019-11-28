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
    class StarWarsPeopleAdapter : BaseAdapter<PeopleDetails>
    {
        List<PeopleDetails> _items;
        Activity _context;

        public StarWarsPeopleAdapter(Activity context, List<PeopleDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override PeopleDetails this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.people_row_layout, null);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = "Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = "Gender: " + item.Gender;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = "Birth Year: " + item.Birth_Year;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = "Eye Color: " + item.Eye_Color;
            view.FindViewById<TextView>(Resource.Id.textView5).Text = "Skin Color: " + item.Skin_Color;
            view.FindViewById<TextView>(Resource.Id.textView6).Text = "Hair Color: " + item.Hair_Color;
            view.FindViewById<TextView>(Resource.Id.textView7).Text = "Mass: " + item.Mass;
            view.FindViewById<TextView>(Resource.Id.textView8).Text = "Height: " + item.Height;
            return view;
        }
    }
}