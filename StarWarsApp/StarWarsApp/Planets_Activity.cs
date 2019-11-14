using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StarWarsApp.Core;

namespace StarWarsApp
{
    [Activity(Label = "Planets_Activity")]
    public class Planets_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Planets_Layout);

            var searchBar2 = FindViewById<EditText>(Resource.Id.searchEditTextPlanets);
            var searchButton2 = FindViewById<Button>(Resource.Id.searchButtonPlanets);
            var planetListView = FindViewById<ListView>(Resource.Id.planetsListView);

            searchButton2.Click += async delegate
            {
                string searchWord = searchBar2.Text;
                string queryString = "https://swapi.co/api/planets/?search=" + searchWord;
                var data = await DataServicePlanets.GetStarWarsPlanets(queryString);
                planetListView.Adapter = new StarWarsPlanetsAdapter(this, data.Results);
            };

        }
    }
}