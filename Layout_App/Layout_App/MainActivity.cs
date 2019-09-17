using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

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
                var intent = new Intent(this, typeof(Challenge1_Activity));
                this.StartActivity(intent);
            }

            void Challenge2_Click(object sender, EventArgs e)
            {
                var intent = new Intent(this, typeof(Challenge2_Activity));
                this.StartActivity(intent);
            }

            void Challenge3_Click(object sender, EventArgs e)
            {
                var intent = new Intent(this, typeof(ChallengeThree_Activity));
                this.StartActivity(intent);
            }

            void Challenge4_Click(object sender, EventArgs e)
            {
                var intent = new Intent(this, typeof(ChallengeFour_Activity));
                this.StartActivity(intent);
            }

        }
    }
}