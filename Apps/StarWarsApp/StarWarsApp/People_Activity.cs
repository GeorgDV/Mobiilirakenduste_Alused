using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;


namespace StarWarsApp
{
    [Activity(Label = "People_Activity")]
    public class People_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.People_Layout);

            var searchBar1 = FindViewById<EditText>(Resource.Id.searchEditText);
            var searchButton1 = FindViewById<Button>(Resource.Id.searchButton);
            var peopleListView = FindViewById<ListView>(Resource.Id.peopleListView);
            //var drawable = (int)typeof(Resource.Drawable).GetField("Luke_skywalker.jpg").GetValue(null);

            searchButton1.Click += async delegate
            {
                string searchWord = searchBar1.Text;
                string queryString = "https://swapi.co/api/people/?search=" + searchWord;
                var data = await DataServicePeople.GetStarWarsPeople(queryString);
                peopleListView.Adapter = new StarWarsPeopleAdapter(this, data.Results);
            };
        }
    }
}