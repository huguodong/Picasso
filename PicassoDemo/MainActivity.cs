using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Squareup.Picasso;

namespace PicassoDemo
{
    [Activity(Label = "PicassoDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        ImageView img;
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            img = FindViewById<ImageView>(Resource.Id.imageView1);
            Picasso.With(this).Load("http://i.imgur.com/DvpvklR.png").Into(img);
        }
    }
}

