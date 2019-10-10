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
    class BasicAdapter : BaseAdapter<WeatherInfo>
    {
        List<WeatherInfo> _items;
        Activity _context;

        public BasicAdapter(Activity context, List<WeatherInfo> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override WeatherInfo this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count;  }
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.Weather_Row, null);

            view.FindViewById<TextView>(Resource.Id.text_view1).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.text_view2).Text = item.Temperature;
            view.FindViewById<TextView>(Resource.Id.text_view3).Text = item.WindSpeed;
            return view;
        }
    }
}