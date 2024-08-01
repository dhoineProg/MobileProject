using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using static Android.Views.View;


namespace ElementsUI.ViewModels
{
    public class ReciclerViewBlock
    {
        #region Fields

        RecyclerView recyclerView;
        Context context;

        #endregion

        #region ctor

        public ReciclerViewBlock(Context context)
        {
            this.context = context;
        }

        #endregion

        #region Private methods
        void CustomButtonWhite_Click(object? sender, TouchEventArgs e)
        {
            var button = (Button)sender;
            var shape = new GradientDrawable();
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
        void CustomButtonDark_Click(object? sender, TouchEventArgs e)
        {
            var button = (Button)sender;
            var shape = new GradientDrawable();
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

        List<Items> CreateItemsList(int imgID)
        {
            return new List<Items>
            {
                new Items { Img = imgID, Title = "Item 1", Subtitle = "Subtitle 1" },
                new Items { Img = imgID, Title = "Item 2", Subtitle = "Subtitle 2" },
                new Items { Img = imgID, Title = "Item 3", Subtitle = "Subtitle 3" },
                new Items { Img = imgID, Title = "Item 1", Subtitle = "Subtitle 1" },
                new Items { Img = imgID, Title = "Item 2", Subtitle = "Subtitle 2" },
                new Items { Img = imgID, Title = "Item 3", Subtitle = "Subtitle 3" },
                new Items { Img = imgID, Title = "Item 1", Subtitle = "Subtitle 1" },
                new Items { Img = imgID, Title = "Item 2", Subtitle = "Subtitle 2" },
                new Items { Img = imgID, Title = "Item 3", Subtitle = "Subtitle 3" }
            };
        }

        RecyclerView CreateRecyclerView(List<Items> items, int imgID)
        {
            var recyclerView = new RecyclerView(context);
            recyclerView.SetLayoutManager(new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false));
            var adapter = new MyAdapter(items, imgID);
            recyclerView.SetAdapter(adapter);
            return recyclerView;
        }

        LinearLayout CreateUpperBlockView(string header, Typeface tf, Typeface tfn, Color color, Color ct)
        {
            var upperBlockView = new LinearLayout(context);
            upperBlockView.Orientation = Android.Widget.Orientation.Horizontal;

            var leftUpperblock = new LinearLayout(context);
            leftUpperblock.Orientation = Android.Widget.Orientation.Vertical;

            var rightUpperblock = new LinearLayout(context);
            rightUpperblock.Orientation = Android.Widget.Orientation.Vertical;

            var headerView = new TextView(context);
            headerView.Text = header;
            headerView.SetPadding(40, 20, 15, 20);
            headerView.SetTextColor(ct);
            headerView.SetTypeface(tf, TypefaceStyle.Bold);
            headerView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22);
            leftUpperblock.AddView(headerView);

            var buttonUp = new Button(context);
            buttonUp.Text = "Button";
            buttonUp.TextSize = 14;
            buttonUp.SetPadding(300, 20, 0, 20);
            var gd = new GradientDrawable();
            buttonUp.SetTextColor(Color.ParseColor("#428BF9"));
            gd.SetColor(color);
            buttonUp.SetBackgroundDrawable(gd);
            buttonUp.SetTypeface(tfn, TypefaceStyle.Bold);
            rightUpperblock.AddView(buttonUp);

            upperBlockView.AddView(leftUpperblock);
            upperBlockView.AddView(rightUpperblock);

            return upperBlockView;
        }

        LinearLayout CreateMiddleBlock(RecyclerView recyclerView)
        {
            var middleBlock = new LinearLayout(context);
            middleBlock.AddView(recyclerView);
            return middleBlock;
        }

        LinearLayout CreateLowerBlockView(Color color, Color ct)
        {
            var lowerBlockView = new LinearLayout(context);
            lowerBlockView.Orientation = Android.Widget.Orientation.Horizontal;

            var gdbd = new GradientDrawable();
            gdbd.SetCornerRadius(40f);

            var buttonDown = new Button(context);
            buttonDown.SetTextColor(Color.ParseColor("#428BF9"));
            buttonDown.Text = "Button";

            if (color == Color.ParseColor("#2a2a2b"))
            {
                gdbd.SetColor(Color.Rgb(247, 247, 247));
                buttonDown.SetBackgroundDrawable(gdbd);
                buttonDown.Touch += CustomButtonDark_Click;
            }
            else
            {
                gdbd.SetColor(Color.Argb(7, 0, 16, 36));
                buttonDown.SetBackgroundDrawable(gdbd);
                buttonDown.Touch += CustomButtonWhite_Click;
            }

            lowerBlockView.AddView(buttonDown);
            return lowerBlockView;
        }

        void SetBlockStyle(LinearLayout block, Color color)
        {
            block.Elevation = 2;
            var gdBlock = new GradientDrawable();
            gdBlock.SetCornerRadius(64f);
            gdBlock.SetColor(color);
            block.SetBackgroundDrawable(gdBlock);
        }

        #endregion

        #region Public methods

        public LinearLayout AddElements(LinearLayout block, string header, Typeface tf, Typeface tfn, int imgID, Color color, Color ct)
        {
            var items = CreateItemsList(imgID);
            var recyclerView = CreateRecyclerView(items, imgID);
            var upperBlockView = CreateUpperBlockView(header, tf, tfn, color, ct);
            var middleBlock = CreateMiddleBlock(recyclerView);
            var lowerBlockView = CreateLowerBlockView(color, ct);

            block.AddView(upperBlockView);
            block.AddView(middleBlock);
            block.AddView(lowerBlockView);

            SetBlockStyle(block, color);

            return block;
        }

        #endregion
    }
}
