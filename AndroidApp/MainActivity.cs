using Android;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Security.Cryptography.X509Certificates;
using Xamarin.Essentials;
using ElementsUI;
using AndroidX.Core.Widget;

namespace AndroidApp
{
    
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    [Activity(Label = "Scroll View Events", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Elements elements;
        private LinearLayout parentLayout;
        private List<TextView> textViews;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            elements = new Elements(this);
            

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            parentLayout = FindViewById<LinearLayout>(Resource.Id.parent_layout);

            AddElementsToParentLayout();

        }
        private void AddElementsToParentLayout()
        {
            // Создание и добавление элементов в parentLayout
            CreateButton createButton = new CreateButton(this);
            Button mButton = createButton.OnCreate("Click", 0, 0);
            Button mButton2 = createButton.OnCreate("Click", 0, 0);
            LinearLayout.LayoutParams buttonParams = new LinearLayout.LayoutParams(
                 ViewGroup.LayoutParams.MatchParent,
                 ViewGroup.LayoutParams.WrapContent);
            buttonParams.SetMargins(0, 50, 0, 0);
            mButton.LayoutParameters = buttonParams;
            CreateButton createButton2 = new CreateButton(this);
            Button ButtonForBBlock = createButton.OnCreate("Click", 0, 0);
            Button ButtonForBBlock2 = createButton.OnCreate("Click", 0, 0);
            LinearLayout.LayoutParams ButtonParams = new LinearLayout.LayoutParams(
                 ViewGroup.LayoutParams.MatchParent,
                 ViewGroup.LayoutParams.WrapContent);
            buttonParams.SetMargins(0, 50, 0, 0);
            mButton.LayoutParameters = buttonParams;

            // Добавляем блоки с кнопками
            LinearLayout block1 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader",null,false);
            LinearLayout block2 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader",null,false);
            LinearLayout block3 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"),null,null,false);
            LinearLayout block4 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"),null,null,false);
            LinearLayout block5 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton,false);
            elements.ChangeBlockWidth(block5, 900, 400);
            LinearLayout block6 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton2,false);
            elements.ChangeBlockWidth(block6, 900, 400);
            LinearLayout block7 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            LinearLayout block8 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            LinearLayout block9 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            LinearLayout block10 = elements.AddAnyElementsToBlock(Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                "#FFFFFF" ,Typeface.CreateFromAsset(Assets, "Roboto.ttf"), true, ButtonForBBlock);
            elements.ChangeBlockWidth(block10, 900, 800);
            LinearLayout block11 = elements.AddAnyElementsToBlock(Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), true, ButtonForBBlock2);
            elements.ChangeBlockWidth(block11, 900, 800);
            LinearLayout block12 = elements.AddAnyElementsToBlock(Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), true, null);
            elements.ChangeBlockWidth(block12, 900, 600);
            LinearLayout block13 = elements.AddAnyElementsToBlock(Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                Resource.Drawable.starblue, "Title", "Description",
                "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), true, null);
            elements.ChangeBlockWidth(block13, 900, 600);



            // Добавляем блоки в parentLayout
            parentLayout.AddView(block1);
            parentLayout.AddView(block2);
            parentLayout.AddView(block3);
            parentLayout.AddView(block4);
            parentLayout.AddView(block5);
            parentLayout.AddView(block6);
            parentLayout.AddView(block7);
            parentLayout.AddView(block8);
            parentLayout.AddView(block9);
            parentLayout.AddView(block10);
            parentLayout.AddView(block11);
            parentLayout.AddView(block12);
            parentLayout.AddView(block13);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}