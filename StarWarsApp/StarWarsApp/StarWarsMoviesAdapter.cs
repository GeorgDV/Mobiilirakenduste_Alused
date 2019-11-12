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
    class StarWarsMoviesAdapter : BaseAdapter<MoviesDetails>
    {
        List<MoviesDetails> _items;
        Activity _context;

        public StarWarsMoviesAdapter(Activity context, List<MoviesDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override MoviesDetails this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.movies_row_layout, null);

            view.FindViewById<TextView>(Resource.Id.textViewMovies1).Text = "";
            view.FindViewById<TextView>(Resource.Id.textViewMoviesTitle).Text = "Title: " + item.Title;
            view.FindViewById<TextView>(Resource.Id.textViewMoviesYear).Text = "Year: " + item.Release_Date.Year.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewMoviesDirector).Text = "Director: " + item.Producer;
            view.FindViewById<TextView>(Resource.Id.textViewMoviesProducer).Text = "Producer: " + item.Director;
            view.FindViewById<TextView>(Resource.Id.textViewMoviesDesc).Text = item.Opening_Crawl;
            view.FindViewById<TextView>(Resource.Id.textViewMovies2).Text = "";

            return view;
        }
    }
}