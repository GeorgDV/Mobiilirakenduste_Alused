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

            var searchBar = FindViewById<EditText>(Resource.Id.searchEditTextPlanets);
            var searchButton = FindViewById<Button>(Resource.Id.searchButtonPlanets);
            var peopleListView = FindViewById<ListView>(Resource.Id.planetsListView);

            searchButton.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/planets/?search=" + searchWord;
                var data = await DataServicePlanets.GetStarWarsPlanets(queryString);
                peopleListView.Adapter = new StarWarsPlanetsAdapter(this, data.Results);
            };

        }
    }
}