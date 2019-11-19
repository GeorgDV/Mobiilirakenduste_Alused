using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace List_Exercise
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toListActivityButton = FindViewById<Button>(Resource.Id.listActivityButton);
            var tosecondActivityButton = FindViewById<Button>(Resource.Id.secondActivityButton);
            var tothirdActivityButton = FindViewById<Button>(Resource.Id.thirdActivityButton);

            toListActivityButton.Click += ToListActivityButton_Click;
            tosecondActivityButton.Click += ToSecondActivityButton_Click;
            tothirdActivityButton.Click += ToThirdActivityButton_Click;

        }

        private void ToListActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(First_Example_Activity));
            this.StartActivity(intent);
        }

        private void ToSecondActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Second_Activity));
            this.StartActivity(intent);
        }
        private void ToThirdActivityButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Third_Activity));
            this.StartActivity(intent);
        }
    }

}