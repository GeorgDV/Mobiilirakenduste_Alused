using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace Layout_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button _button_challenge_1;
        Button _button_challenge_2;
        Button _button_challenge_3;
        Button _button_challenge_4;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _button_challenge_1 = FindViewById<Button>(Resource.Id.button_challenge_1);
            _button_challenge_2 = FindViewById<Button>(Resource.Id.button_challenge_2);
            _button_challenge_3 = FindViewById<Button>(Resource.Id.button_challenge_3);
            _button_challenge_4 = FindViewById<Button>(Resource.Id.button_challenge_4);

            _button_challenge_1.Click += Challenge1_Click;
            _button_challenge_2.Click += Challenge2_Click;
            _button_challenge_3.Click += Challenge3_Click;
            _button_challenge_4.Click += Challenge4_Click;


            void Challenge1_Click(object sender, EventArgs e)
            {
                SetContentView(Resource.Layout.challenge1_layout);
            }

            void Challenge2_Click(object sender, EventArgs e)
            {
                SetContentView(Resource.Layout.challenge2_layout);
            }

            void Challenge3_Click(object sender, EventArgs e)
            {
                SetContentView(Resource.Layout.challenge3_layout);

            }

            void Challenge4_Click(object sender, EventArgs e)
            {
                SetContentView(Resource.Layout.challenge4_layout);

            }

        }
    }
}