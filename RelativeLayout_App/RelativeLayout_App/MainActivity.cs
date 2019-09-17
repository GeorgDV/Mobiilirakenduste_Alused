using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace RelativeLayout_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button _challenge1_button;
        Button _challenge2_button;
        Button _challenge3_button;
        Button _challenge4_button;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _challenge1_button = FindViewById<Button>(Resource.Id.challenge1_button);
            _challenge2_button = FindViewById<Button>(Resource.Id.challenge2_button);
            _challenge3_button = FindViewById<Button>(Resource.Id.challenge3_button);


            _challenge1_button.Click += Challenge1_Click;
            _challenge2_button.Click += Challenge2_Click;
            _challenge3_button.Click += Challenge3_Click;

        }

        private void Challenge1_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge1_Activity));
            this.StartActivity(intent);
        }

        private void Challenge2_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge2_Activity));
            this.StartActivity(intent);
        }

        private void Challenge3_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge3_Activity));
            this.StartActivity(intent);
        }

    }
}