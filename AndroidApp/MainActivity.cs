using Android.AdServices.AppSetIds;
using Android.Animation;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Hardware.Lights;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView;
using ElementsUI;
using static Android.Icu.Text.ListFormatter;

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
            var miniblocks = new List<LinearLayout>();
            var createElements = new CreateElements(this);
            var elements = new Elements(this);
            var editelements = new EditElements(this);
            var createButton = new CreateButton(this);
            // Создание и добавление элементов в parentLayout
            var mButton = createButton.OnCreate("Button",800,120,60,0,24f);
            mButton.Click += MyButton_Click;
            var mButton2 = createButton.OnCreate("Button", 800, 120, 60,0, 24f);
            mButton2.Click += MyButton_Click;
            var cross = createButton.OnCreate("Button", 60, 60, 850,500, 60f);
            var ButtonForBBlock = createButton.OnCreate("Button", 800, 120, 60,0, 24f);
            ButtonForBBlock.Click += MyButton_Click;
            var ButtonForBBlock2 = createButton.OnCreate("Button",800,120, 60,0,24f);
            ButtonForBBlock2.Click += MyButton_Click;
            var ButtonBottom = createButton.OnCreate("Button", 800, 120, 60, 0, 24f);

            // Добавляем блоки
            var block1 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block1,"Header",
                Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 20, 13, "Subheader", null, false);
            editelements.SetBlockWidth(block1,100,100);
            blocks.Add(block1);
            var block2 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block2,"Header",
                Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 20, 13, "Subheader", null, false);
            blocks.Add(block2);
            var block3 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block3,"Header",
                Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 20, 13, null, null, false);
            blocks.Add(block3);
            var block4 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block4,"Header",
                Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 20, 13, null, null, false);
            blocks.Add(block4);
            var block5 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block5,"Header",
                Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 20, 13, "Subheader", mButton, false);
            blocks.Add(block5);
            var block6 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block6,"Header",
                Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold, TypefaceStyle.Normal, 16, 13, "Subheader", mButton2, false);
            blocks.Add(block6);
            var block7 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block7,"Title",
                Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", null, true);
            blocks.Add(block7);
            var block8 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block8,"Title",
                Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", null, true);
            blocks.Add(block8);
            var block9 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block9,"Title",
                Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", cross, true);
            blocks.Add(block9);
            var block10 = createElements.CreateBlock();
            elements.AddToBlock(block10, "Header", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), null);
            var block11 = createElements.CreateBlock();
            elements.AddToBlock(block11, "Header", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), null);
            var block12 = createElements.CreateBlock();
            elements.AddToBlock(block12, "Header", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), null);
            var block13 = createElements.CreateBlock();
            elements.AddToBlock(block13, "Header", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), null);
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                elements.AddLabelAndImageToBlock(block10, "Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", ButtonForBBlock, true);
                elements.AddLabelAndImageToBlock(block11, "Title", Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", ButtonForBBlock2, true);
                elements.AddLabelAndImageToBlock(block12, "Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", null, true);
                elements.AddLabelAndImageToBlock(block13, "Title", Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Normal, TypefaceStyle.Normal, 16, 13, "Description", null, true);       
            }  
            
            blocks.Add(block10);
            blocks.Add(block11);
            blocks.Add(block12);
            blocks.Add(block13);
            var buttonLayout = createElements.CreateBlock();
            buttonLayout.Orientation = Orientation.Horizontal;
            editelements.SetBlockWidth(buttonLayout,1000,220);
            buttonLayout.AddView(ButtonBottom);
            blocks.Add(buttonLayout);
            
            foreach (var block in blocks)
            {
                editelements.SetMarginBlock(block, 90, 90, 10,0);
                parentLayout.AddView(block);
            }
            editelements.SetMarginBlock(buttonLayout, 0, 0, 0, 100);
            
        }

        public void MyButton_Click(object sender, EventArgs e)
        {
            var gd = new GradientDrawable();
            gd.SetColor(Color.Argb((int)(255 * 0.06), 0, 16, 36));
            var button = (Button)sender;
            button.Background = gd;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}