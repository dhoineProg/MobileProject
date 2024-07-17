using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using ElementsUI;
using Android.App;
using Android.Content.Res;
using Android.Webkit;
using AndroidX.AppCompat.App;
using Android.OS;
using Android.Widget;
using static Android.Views.View;
namespace AndroidApp
{


    [Activity(Label = "Scroll View Events", MainLauncher = true)]
    public class MainActivity : Activity
    {

        LinearLayout parentLayout;
        List<TextView> textViews;
        private int originalColor;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var elements = new Elements(this);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            parentLayout = FindViewById<LinearLayout>(Resource.Id.parent_layout);
            AddElementsToParentLayout();
        }

        public enum AndroidTheme
        {
            Light,
            Dark
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
            var verticalRecicler = new VerticalReciclerBlock(this);
            var addBlock = new AddBlockWithCross(this);
            if (IsInDarkMode())
            {
                var mButton = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                        120, 15, 15, 40f, Color.Rgb(247, 249, 250));
                mButton.Touch += CustomButton_Click;
                var mButton2 = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                    120, 15, 15, 40f, Color.Rgb(247, 247, 247));
                mButton2.Touch += CustomButton_Click;
                var cross = createButton.OnCreate("", 60, 60, 850, 500, 60f, Color.Rgb(247, 247, 257));
                cross.LayoutParameters = new LinearLayout.LayoutParams(60, 60);
                cross.SetBackgroundColor(Color.ParseColor("#c2c2c2"));
                cross.SetBackgroundResource(Resource.Drawable.cross);
                var ButtonBottom = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                         120, 0, 0, 40f, Color.Rgb(247, 247, 247));
                ButtonBottom.Touch += CustomButton_Click;
                // Создание и добавление элементов в parentLayout
                parentLayout.SetBackgroundColor(Color.ParseColor("#191919"));
                // Добавляем блоки
                var block1 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block1, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 13, "Subheader", null, false);
                editelements.SetBlockWidth(block1, 100, 100);
                blocks.Add(block1);
                var block2 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block2, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", null, false);
                blocks.Add(block2);
                var block3 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block3, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block3);
                var block4 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block4, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block4);
                var block5 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block5, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton, false);
                blocks.Add(block5);
                var block6 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block6, "Header",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton2, false);
                blocks.Add(block6);
                var block7 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block7, "Title",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block7);
                var block8 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block8, "Title",
                    Resource.Drawable.starblue, "#2a2a2b", "#c2c2c2",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block8);
                var block9 = createElements.CreateBlock();
                addBlock.AddBlock(block9, "Title", "Description",
                    Resource.Drawable.starblue, cross,
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Color.ParseColor("#2a2a2b"), Color.ParseColor("#c2c2c2"));
                blocks.Add(block9);
                var block10 = createElements.CreateBlock();
                verticalRecicler.AddElements(block10, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, 120, Color.ParseColor("#2a2a2b"), Color.ParseColor("#c2c2c2"));
                blocks.Add(block10);
                var block11 = createElements.CreateBlock();
                reciclerViewBlock.AddElements(block11, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, Color.ParseColor("#2a2a2b"), Color.ParseColor("#c2c2c2"));
                blocks.Add(block11);
                var buttonLayout = createElements.CreateBlock();
                buttonLayout.Orientation = Android.Widget.Orientation.Horizontal;
                var par = new LinearLayout.LayoutParams(100, 100);
                buttonLayout.LayoutParameters = par;
                buttonLayout.AddView(ButtonBottom);
                blocks.Add(buttonLayout);
                //Вывод блоков
                foreach (var block in blocks)
                {
                    editelements.SetMarginBlock(block, 90, 0, 10, 0);
                    parentLayout.AddView(block);
                }
            }
            else
            {
                var mButton = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                        120, 15, 15, 24f, Color.Argb(7, 0, 16, 36));
                mButton.Touch += CustomButton_Click;
                var mButton2 = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                    120, 15, 15, 24f, Color.Argb(7, 0, 16, 36));
                mButton2.Touch += CustomButton_Click;
                var cross = createButton.OnCreate("", 60, 60, 850, 500, 60f, Color.Argb(7, 0, 16, 36));
                cross.LayoutParameters = new LinearLayout.LayoutParams(60, 60);
                cross.SetBackgroundColor(Color.ParseColor("#c2c2c2"));
                cross.SetBackgroundResource(Resource.Drawable.cross);
                var ButtonBottom = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                         120, 0, 0, 24f, Color.Argb(7, 0, 16, 36));
                ButtonBottom.Touch += CustomButton_Click;
                // Создание и добавление элементов в parentLayout
                parentLayout.SetBackgroundColor(Color.Rgb(246,246,245));
                // Добавляем блоки
                var block1 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block1, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 13, "Subheader", null, false);
                editelements.SetBlockWidth(block1, 100, 100);
                blocks.Add(block1);
                var block2 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block2, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", null, false);
                blocks.Add(block2);
                var block3 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block3, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block3);
                var block4 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block4, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block4);
                var block5 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block5, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton, false);
                blocks.Add(block5);
                var block6 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block6, "Header",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton2, false);
                blocks.Add(block6);
                var block7 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block7, "Title",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block7);
                var block8 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block8, "Title",
                    Resource.Drawable.starblue, "#FFFFFF", "#333333",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block8);
                var block9 = createElements.CreateBlock();
                addBlock.AddBlock(block9, "Title", "Description",
                    Resource.Drawable.starblue, cross,
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Color.ParseColor("#FFFFFF"), Color.ParseColor("#333333"));
                blocks.Add(block9);
                var block10 = createElements.CreateBlock();
                verticalRecicler.AddElements(block10, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, 60, Color.ParseColor("#ffffff"), Color.ParseColor("#333333"));
                blocks.Add(block10);
                var block11 = createElements.CreateBlock();
                reciclerViewBlock.AddElements(block11, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, Color.ParseColor("#FFFFFF"), Color.ParseColor("#333333"));
                blocks.Add(block11);
                var buttonLayout = createElements.CreateBlock();
                buttonLayout.Orientation = Android.Widget.Orientation.Horizontal;
                var par = new LinearLayout.LayoutParams(100, 100);
                buttonLayout.LayoutParameters = par;
                buttonLayout.AddView(ButtonBottom);
                blocks.Add(buttonLayout);
                //Вывод блоков
                foreach (var block in blocks)
                {
                    editelements.SetMarginBlock(block, 90, 0, 10, 0);
                    parentLayout.AddView(block);
                }
            }
        }

        private bool IsInDarkMode()
        {
            // Логика определения темного режима
            var currentNightMode = Resources.Configuration.UiMode & UiMode.NightMask;
            return currentNightMode == UiMode.NightYes;
        }

        private void CustomButton_Click(object? sender, TouchEventArgs e)
        {
            var button = (Button)sender;
            var shape = new GradientDrawable();
            if (!IsInDarkMode())
            {
                shape.SetCornerRadius(40);
                if (e.Event.Action == MotionEventActions.Up || e.Event.Action == MotionEventActions.Cancel)
                {
                    shape.SetColor(Color.Argb(7, 0, 16, 36));
                    button.SetBackgroundDrawable(shape);
                }
                if (e.Event.Action == MotionEventActions.Down)
                {
                    shape.SetColor(Color.Argb(30, 0, 16, 36));
                    button.SetBackgroundDrawable(shape);
                }
            }
            else
            {
                shape.SetCornerRadius(40);
                if (e.Event.Action == MotionEventActions.Up || e.Event.Action == MotionEventActions.Cancel)
                {
                    shape.SetColor(Color.Rgb(247, 247, 247));
                    button.SetBackgroundDrawable(shape);
                }
                if (e.Event.Action == MotionEventActions.Down)
                {
                    shape.SetColor(Color.Rgb(235, 236, 237));
                    button.SetBackgroundDrawable(shape);
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}