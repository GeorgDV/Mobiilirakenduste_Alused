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
using Newtonsoft.Json;

namespace StarWarsApp
{
    [Activity(Label = "MovieDetailsActivity")]
    public class MovieDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Movie_Details_Layout);
            // Create your application here

            var movieTitleTextView = FindViewById<TextView>(Resource.Id.textViewMDetailsTitle);
            var movieYearTextView = FindViewById<TextView>(Resource.Id.textViewMDetailsYear);
            var movieDirectorTextView = FindViewById<TextView>(Resource.Id.textViewMDetailsDirector);
            var movieProducerTextView = FindViewById<TextView>(Resource.Id.textViewMDetailsProducer);
            var movieDescTextView = FindViewById<TextView>(Resource.Id.textViewMDetailsDesc);

            var movieDetails = JsonConvert.DeserializeObject<Core.Models.MoviesDetails>(Intent.GetStringExtra("movieDetails"));
            movieTitleTextView.Text = movieDetails.Title;
            movieYearTextView.Text = movieDetails.Release_Date.Year.ToString();
            movieDirectorTextView.Text = "Directed by: " + movieDetails.Director;
            movieProducerTextView.Text = "Produced by: " + movieDetails.Producer;
            movieDescTextView.Text = movieDetails.Opening_Crawl;
        }
    }
}