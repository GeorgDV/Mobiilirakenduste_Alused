using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;
using List_Exercise.Core;

namespace List_Exercise
{
    class BasicAdapterStarWars : BaseAdapter<PeopleDetails>
    {
        List<PeopleDetails> _items;
        Activity _context;

        public BasicAdapterStarWars(Activity context, List<PeopleDetails> items) : base()
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.Third_Layout, null);

            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI1).Text = "Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI2).Text = "Gender: " + item.Gender;
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI3).Text = "Eye Color: " + item.Eye_Color;
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI4).Text = "Skin Color: " + item.Skin_Color;
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI5).Text = "Hair Color: " + item.Hair_Color;
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI6).Text = "Mass: " + item.Mass.ToString();
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI7).Text = "Height: " + item.Height.ToString();
            view.FindViewById<TextView>(Resource.Id.text_viewSWAPI8).Text = "Birth Year: " + item.Birth_Year;
            return view;
        }
    }
}