using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;

namespace StarWarsApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var searchBar = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton = FindViewById<Button>(Resource.Id.searchButton);
            var peopleListView = FindViewById<ListView>(Resource.Id.peopleListView);

            searchButton.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/people/?search=" + searchWord;
                var data = await DataService.GetStarWarsPeople(queryString);
                peopleListView.Adapter = new StarWarsPeopleAdapter(this, data.Results);
            };

        }
    }
}