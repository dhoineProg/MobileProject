using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ElementsUI;
using Android.Content;
using AndroidX.RecyclerView.Widget;
using Android.Transitions;

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
            var reciclerViewBlock = new ReciclerViewBlock(this);
            var addBlock = new AddBlockWithCross(this);
            // Создание и добавление элементов в parentLayout
            var mButton = createButton.OnCreate("Button",ViewGroup.LayoutParams.MatchParent,
                                                120,15,15,24f);
            var mButton2 = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                120, 15, 15, 24f);
            var cross = createButton.OnCreate("", 60, 60, 850,500, 60f);
            cross.LayoutParameters = new LinearLayout.LayoutParams(60, 60);
            cross.SetBackgroundColor(Color.ParseColor("#edeef0"));
            cross.SetBackgroundResource(Resource.Drawable.cross);
            var ButtonForBBlock = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                        120, 15, 15, 24f);
            var ButtonForBBlock2 = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                        120, 15, 15, 24f);
            var ButtonBottom = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                     120, 0, 0, 24f);
            var buttonUp = new Button(this);
            buttonUp.Text = "Button";
            buttonUp.TextSize = 14;
            buttonUp.SetPadding(300, 20, 0, 20);
            var gd = new GradientDrawable();
            var gd2 = new GradientDrawable();
            buttonUp.SetTextColor(Color.ParseColor("#428BF9"));
            gd.SetColor(Color.ParseColor("#FFFFFF"));
            buttonUp.SetBackgroundDrawable(gd);
            buttonUp.SetTypeface(Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold);
            var buttonUp2 = new Button(this);
            buttonUp2.Text = "Button";
            buttonUp2.TextSize = 14;
            buttonUp2.SetPadding(300, 20, 0, 20);
            buttonUp2.SetTextColor(Color.ParseColor("#428BF9"));
            gd2.SetColor(Color.ParseColor("#edeef0"));
            buttonUp2.SetBackgroundDrawable(gd2);
            buttonUp2.SetTypeface(Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold);
            var buttonUp3 = new Button(this);
            buttonUp3.Text = "Button";
            buttonUp3.TextSize = 14;
            buttonUp3.SetPadding(300, 20, 0, 20);
            buttonUp3.SetTextColor(Color.ParseColor("#428BF9"));
            buttonUp3.SetBackgroundDrawable(gd);
            buttonUp3.SetTypeface(Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold);
            var buttonUp4 = new Button(this);
            buttonUp4.Text = "Button";
            buttonUp4.TextSize = 14;
            buttonUp4.SetPadding(300, 20, 0, 20);
            buttonUp4.SetTextColor(Color.ParseColor("#428BF9"));
            buttonUp4.SetBackgroundDrawable(gd2);
            buttonUp4.SetTypeface(Typeface.CreateFromAsset(Assets, "Roboto.ttf"), TypefaceStyle.Bold);
            // Добавляем блоки
            var block1 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block1,"Header",
                Resource.Drawable.starblue, "#FFFFFF",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 13, "Subheader", null, false);
            editelements.SetBlockWidth(block1,100,100);
            blocks.Add(block1);
            var block2 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block2,"Header",
                Resource.Drawable.starblue, "#edeef0",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", null, false);
            blocks.Add(block2);
            var block3 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block3,"Header",
                Resource.Drawable.starblue, "#FFFFFF",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
            blocks.Add(block3);
            var block4 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block4,"Header",
                Resource.Drawable.starblue, "#edeef0",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
            blocks.Add(block4);
            var block5 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block5,"Header",
                Resource.Drawable.starblue, "#FFFFFF",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton, false);
            blocks.Add(block5);
            var block6 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block6,"Header",
                Resource.Drawable.starblue, "#edeef0",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton2, false);
            blocks.Add(block6);
            var block7 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block7,"Title",
                Resource.Drawable.starblue, "#FFFFFF",
                Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
            blocks.Add(block7);
            var block8 = createElements.CreateBlock();
            elements.AddLabelAndImageToBlock(block8,"Title",
                Resource.Drawable.starblue, "#edeef0",
                Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
            blocks.Add(block8);
            var block9 = createElements.CreateBlock();
            addBlock.AddBlock(block9, "Title", "Description",
                Resource.Drawable.starblue, cross,
                Typeface.CreateFromAsset(Assets,"Roboto.ttf"));
            blocks.Add(block9);
            var block10 = createElements.CreateBlock();
            elements.AddToBlock(block10, buttonUp, "Header", 
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"));
            var block11 = createElements.CreateBlock();
            elements.AddToBlock(block11, buttonUp2, "Header",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"));
            var block12 = createElements.CreateBlock();
            elements.AddToBlock(block12, buttonUp3, "Header",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"));
            var block13 = createElements.CreateBlock();
            elements.AddToBlock(block13, buttonUp4, "Header",
                Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"));
            int count = 4;
            for (int i = 0; i < count; i++)
            {
                elements.AddLabelAndImageToBlock(block10, "Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.DefaultBold, TypefaceStyle.Normal, 18, 13, "Description", ButtonForBBlock, true);
                elements.AddLabelAndImageToBlock(block11, "Title", Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.DefaultBold, TypefaceStyle.Normal, 18, 13, "Description", ButtonForBBlock2, true);
                elements.AddLabelAndImageToBlock(block12, "Title", Resource.Drawable.starblue, "#FFFFFF", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.DefaultBold, TypefaceStyle.Normal, 18, 13, "Description", null, true);
                elements.AddLabelAndImageToBlock(block13, "Title", Resource.Drawable.starblue, "#edeef0", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.DefaultBold, TypefaceStyle.Normal, 18, 13, "Description", null, true);       
            }             
            blocks.Add(block10);
            blocks.Add(block11);
            blocks.Add(block12);
            blocks.Add(block13);
            var block14 = createElements.CreateBlock();
            reciclerViewBlock.AddElements(block14, "Header", Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue);
            blocks.Add(block14);     
            var buttonLayout = createElements.CreateBlock();
            buttonLayout.Orientation = Orientation.Horizontal;
            LinearLayout.LayoutParams par = new LinearLayout.LayoutParams(100, 100);
            buttonLayout.LayoutParameters = par;
            buttonLayout.AddView(ButtonBottom);
            blocks.Add(buttonLayout); 
            //Вывод блоков
            foreach (var block in blocks)
            {
                editelements.SetMarginBlock(block, 90, 0, 10,0);
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