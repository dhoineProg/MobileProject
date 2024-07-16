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
namespace AndroidApp
{


    [Activity(Label = "Scroll View Events", MainLauncher = true)]
    public class MainActivity : Activity
    {

        LinearLayout parentLayout;
        List<TextView> textViews;
        private int originalColor;
        Button button;
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
            var mButton = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                    120, 15, 15, 24f);
            button = mButton;
            var gdr = new GradientDrawable();
            gdr.SetCornerRadius(20f);
            originalColor = Color.Argb((int)(255 * 0.03), 0, 16, 36);
            gdr.SetColor(originalColor);
            button.SetBackgroundDrawable(gdr);
            button.Click += Button_Clicked;
            var mButton2 = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                120, 15, 15, 24f);
            var cross = createButton.OnCreate("", 60, 60, 850, 500, 60f);
            cross.LayoutParameters = new LinearLayout.LayoutParams(60, 60);
            cross.SetBackgroundColor(Color.ParseColor("#edeef0"));
            cross.SetBackgroundResource(Resource.Drawable.cross);
            var ButtonBottom = createButton.OnCreate("Button", ViewGroup.LayoutParams.MatchParent,
                                                     120, 0, 0, 24f);
            if (IsInDarkMode())
            {
                // Создание и добавление элементов в parentLayout
                parentLayout.SetBackgroundColor(Color.ParseColor("#edeef0"));
                // Добавляем блоки
                var block1 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block1, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 13, "Subheader", null, false);
                editelements.SetBlockWidth(block1, 100, 100);
                blocks.Add(block1);
                var block2 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block2, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", null, false);
                blocks.Add(block2);
                var block3 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block3, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block3);
                var block4 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block4, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block4);
                var block5 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block5, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton, false);
                blocks.Add(block5);
                var block6 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block6, "Header",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton2, false);
                blocks.Add(block6);
                var block7 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block7, "Title",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block7);
                var block8 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block8, "Title",
                    Resource.Drawable.starblue, "#edeef0",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block8);
                var block9 = createElements.CreateBlock();
                addBlock.AddBlock(block9, "Title", "Description",
                    Resource.Drawable.starblue, cross,
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Color.ParseColor("#edeef0"));
                blocks.Add(block9);
                var block10 = createElements.CreateBlock();
                verticalRecicler.AddElements(block10, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, 120, Color.ParseColor("#edeef0"));
                blocks.Add(block10);
                var block11 = createElements.CreateBlock();
                reciclerViewBlock.AddElements(block11, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, Color.ParseColor("#edeef0"));
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
                // Создание и добавление элементов в parentLayout
                parentLayout.SetBackgroundColor(Color.White);
                // Добавляем блоки
                var block1 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block1, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 13, "Subheader", null, false);
                editelements.SetBlockWidth(block1, 100, 100);
                blocks.Add(block1);
                var block2 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block2, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", null, false);
                blocks.Add(block2);
                var block3 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block3, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block3);
                var block4 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block4, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, null, null, false);
                blocks.Add(block4);
                var block5 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block5, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton, false);
                blocks.Add(block5);
                var block6 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block6, "Header",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Subheader", mButton2, false);
                blocks.Add(block6);
                var block7 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block7, "Title",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block7);
                var block8 = createElements.CreateBlock();
                elements.AddLabelAndImageToBlock(block8, "Title",
                    Resource.Drawable.starblue, "#FFFFFF",
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"),
                    Typeface.DefaultBold, TypefaceStyle.Normal, 22, 14, "Description", null, true);
                blocks.Add(block8);
                var block9 = createElements.CreateBlock();
                addBlock.AddBlock(block9, "Title", "Description",
                    Resource.Drawable.starblue, cross,
                    Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Color.ParseColor("#FFFFFF"));
                blocks.Add(block9);
                var block10 = createElements.CreateBlock();
                verticalRecicler.AddElements(block10, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto-bold.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, 120, Color.ParseColor("#ffffff"));
                blocks.Add(block10);
                var block11 = createElements.CreateBlock();
                reciclerViewBlock.AddElements(block11, "Header", Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Typeface.CreateFromAsset(Assets, "Roboto.ttf"), Resource.Drawable.starblue, Color.ParseColor("#FFFFFF"));
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

        private void Button_Clicked(object sender, EventArgs args)
        {
            ChangeColor(button);
        }

        private void ChangeColor(Button btn)
        {
            GradientDrawable gd = new GradientDrawable();
            // Меняем цвет кнопки на красный
            gd.SetColor(Color.Argb((int)(255 * 0.06), 0, 16, 36));
            gd.SetCornerRadius(24f);
            btn.SetBackgroundDrawable(gd);

            // Возвращаем исходный цвет кнопки 
            Android.OS.Handler handler = new Android.OS.Handler(Looper.MainLooper);
            handler.PostDelayed(() =>
            {
                gd.SetColor(originalColor);             
                btn.SetBackgroundDrawable(gd);
                
            }, 200);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}