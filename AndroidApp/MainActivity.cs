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

    [Activity(Label = "Scroll View Events", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Elements elements;
        EditElements editelements;
        LinearLayout parentLayout;
        CreateButton createButton;
        List<TextView> textViews;
        List<LinearLayout> blocks;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var elements = new Elements(this);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            parentLayout = FindViewById<LinearLayout>(Resource.Id.parent_layout);
            AddElementsToParentLayout();
        }
        private void AddElementsToParentLayout()
        {
            // Создание и добавление элементов в parentLayout
            createButton = new CreateButton(this);
            var mButton = createButton.OnCreate("Click", 0, 0);
            var mButton2 = createButton.OnCreate("Click", 0, 0);
            var ButtonForBBlock = createButton.OnCreate("Click", 0, 0);
            var ButtonForBBlock2 = createButton.OnCreate("Click", 0, 0);
            LinearLayout.LayoutParams buttonParams = new LinearLayout.LayoutParams(
                 ViewGroup.LayoutParams.MatchParent,
                 ViewGroup.LayoutParams.WrapContent);
            buttonParams.SetMargins(0, 50, 0, 0);
            mButton.LayoutParameters = buttonParams;
            // Добавляем блоки с кнопками
            var block1 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", null, false);
            var block2 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", null, false);
            var block3 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), null, null, false);
            var block4 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), null, null, false);
            var block5 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton, false);
            //editelements.ChangeBlockWidth(block5, 900, 400);
            var block6 = elements.AddLabelAndImageToBlock("Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton2, false);
            //editelements.ChangeBlockWidth(block6, 900, 400);
            var block7 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            var block8 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            var block9 = elements.AddLabelAndImageToBlock("Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
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
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}