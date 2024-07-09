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
        LinearLayout parentLayout;
        List<TextView> textViews;
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
            var blocks = new List<LinearLayout>();
            var createElements = new CreateElements(this);
            var elements = new Elements(this);
            var editelements = new EditElements(this);
            var createButton = new CreateButton(this);
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
            // Добавляем блоки
            var block1 = createElements.CreateBlock(900,220);
            elements.AddLabelAndImageToBlock(block1,"Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", null, false);
            blocks.Add(block1);
            var block2 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block2,"Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", null, false);
            blocks.Add(block2);
            var block3 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block3,"Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), null, null, false);
            blocks.Add(block3);
            var block4 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block4,"Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), null, null, false);
            blocks.Add(block4);
            var block5 = createElements.CreateBlock(900, 400);
            elements.AddLabelAndImageToBlock(block5,"Header", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton, false);
            blocks.Add(block5);
            var block6 = createElements.CreateBlock(900, 400);
            elements.AddLabelAndImageToBlock(block6,"Header", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Subheader", mButton2, false);
            blocks.Add(block6);
            var block7 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block7,"Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            blocks.Add(block7);
            var block8 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block8,"Title", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            blocks.Add(block8);
            var block9 = createElements.CreateBlock(900, 220);
            elements.AddLabelAndImageToBlock(block9,"Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", null, true);
            blocks.Add(block9);
            var block10 = createElements.CreateBlock(900, 620);
            var block11 = createElements.CreateBlock(900, 620);
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                elements.AddLabelAndImageToBlock(block10, "Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", ButtonForBBlock, true);
                elements.AddLabelAndImageToBlock(block11, "Title", Resource.Drawable.starblue, "#e8e9eb", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), "Description", ButtonForBBlock2, true);
            }  
            blocks.Add(block10);
            blocks.Add(block11);


            foreach (var block in blocks)
            {
                editelements.SetMarginBlock(block, 90, 90, 15);
                parentLayout.AddView(block);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}