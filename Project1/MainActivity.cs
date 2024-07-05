using Android;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using LibraryClasses;
using System;
using System.Security.Cryptography.X509Certificates;
using Xamarin.Essentials;

namespace Project1
{
    
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            LinearLayout ParentBlock = new LinearLayout(this);
            ParentBlock.Orientation = Orientation.Vertical;
            ParentBlock.LayoutParameters = new ViewGroup.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.MatchParent);
            Elements elements = new Elements(this);
            ElementsST2 elementsST2 = new ElementsST2(this);
            elements.AddLabelAndImageToBlock("Header","Subheader", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets,"Roboto.ttf"));
            elements.AddLabelAndImageToBlock("Header", "Subheader", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"));
            elementsST2.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"));
            elementsST2.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"));

            elements.DisplayBlocks(ParentBlock);
            elementsST2.DisplayBlocks(ParentBlock);
            SetContentView(ParentBlock);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}