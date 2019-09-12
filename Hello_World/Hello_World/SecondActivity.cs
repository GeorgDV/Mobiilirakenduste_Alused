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

namespace Hello_World
{
    [Activity(Label = "Second_Activity")]
    public class SecondActivity : Activity
    {
        //Button button;...
        EditText _lisa_arv_1;
        EditText _lisa_arv_2;
        Button _liida_tehe;
        Button _lahuta_tehe;
        Button _korruta_tehe;
        Button _jaga_tehe;
        TextView _vastus_1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);

            _lisa_arv_1= FindViewById<EditText>(Resource.Id.lisa_arv_1);
            _lisa_arv_2 = FindViewById<EditText>(Resource.Id.lisa_arv_2);
            _liida_tehe = FindViewById<Button>(Resource.Id.liida_tehe);
            _lahuta_tehe = FindViewById<Button>(Resource.Id.lahuta_tehe);
            _korruta_tehe = FindViewById<Button>(Resource.Id.korruta_tehe);
            _jaga_tehe = FindViewById<Button>(Resource.Id.jaga_tehe);
            _vastus_1 = FindViewById<TextView>(Resource.Id.vastus_1);

            _liida_tehe.Click += Liida_Click;
            _lahuta_tehe.Click += Lahuta_Click;
            _korruta_tehe.Click += Korruta_Click;
            _jaga_tehe.Click += Jaga_Click;

            void Liida_Click(object sender, EventArgs e)
            {
                double arv1 = Convert.ToDouble(_lisa_arv_1.Text);
                double arv2 = Convert.ToDouble(_lisa_arv_2.Text);
                double vastus = arv1 + arv2;
                _vastus_1.Text = Convert.ToString(vastus);
            }

            void Lahuta_Click(object sender, EventArgs e)
            {
                double arv1 = Convert.ToDouble(_lisa_arv_1.Text);
                double arv2 = Convert.ToDouble(_lisa_arv_2.Text);
                double vastus = arv1 - arv2;
                _vastus_1.Text = Convert.ToString(vastus);
            }

            void Korruta_Click(object sender, EventArgs e)
            {
                double arv1 = Convert.ToDouble(_lisa_arv_1.Text);
                double arv2 = Convert.ToDouble(_lisa_arv_2.Text);
                double vastus = arv1 * arv2;
                _vastus_1.Text = Convert.ToString(vastus);
            }

            void Jaga_Click(object sender, EventArgs e)
            {
                double arv1 = Convert.ToDouble(_lisa_arv_1.Text);
                double arv2 = Convert.ToDouble(_lisa_arv_2.Text);
                double vastus = arv1 / arv2;
                _vastus_1.Text = Convert.ToString(vastus);
            }

            //_button.Click += Button_Click;

            //private void Button_Click(object sender, EventArgs e)
            //{

            //}
        }
    }
}