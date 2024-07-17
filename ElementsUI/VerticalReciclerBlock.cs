using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using ElementsUI;
using Android.Support.V4;
using AndroidX.RecyclerView.Widget;
using static Android.Views.View;
using Android.Content.Res;
namespace ElementsUI
{
    public class VerticalReciclerBlock
    {
        RecyclerView recyclerView;
        Context context;
        public VerticalReciclerBlock(Context context)
        {
            this.context = context;
        }
        public LinearLayout AddElements(LinearLayout block, string header, Typeface tf, Typeface tfHeader, Typeface tfn, int imgID, int count,  Color color, Color ct)
        {
            var items = new List<Items>();
            for (int i = 0; i < count; i++)
            {             
                items.Add(new Items { Img = imgID, Title = "Title", Subtitle = "Description" });
            }
            
            var recyclerView = new RecyclerView(context);
            recyclerView.SetLayoutManager(new LinearLayoutManager(context, LinearLayoutManager.Vertical, false));
            var adapter = new VerticalAdapter(items, imgID, tf,ct);
            recyclerView.SetAdapter(adapter);
            var middleBlock = new LinearLayout(context);
            var editElements = new EditElements(context);
            var upperBlockView = new LinearLayout(context);
            upperBlockView.Orientation = Android.Widget.Orientation.Horizontal;
            var leftUpperblock = new LinearLayout(context);
            leftUpperblock.Orientation = Android.Widget.Orientation.Vertical;
            var rightUpperblock = new LinearLayout(context);
            rightUpperblock.Orientation = Android.Widget.Orientation.Vertical;
            var lowerBlockView = new LinearLayout(context);
            lowerBlockView.Orientation = Android.Widget.Orientation.Horizontal;
            LinearLayout.LayoutParams ParamsParent = new LinearLayout.LayoutParams(900, 750);
            LinearLayout.LayoutParams Params = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            LinearLayout.LayoutParams childParams = new LinearLayout.LayoutParams(0,
            ViewGroup.LayoutParams.WrapContent,
            0.3f);
            upperBlockView.LayoutParameters = Params;
            middleBlock.LayoutParameters = ParamsParent;
            lowerBlockView.LayoutParameters = Params;
            rightUpperblock.LayoutParameters = childParams;
            leftUpperblock.LayoutParameters = childParams;
            upperBlockView.SetGravity(GravityFlags.Top);
            middleBlock.SetGravity(GravityFlags.Center);
            lowerBlockView.SetGravity(GravityFlags.Bottom);
            leftUpperblock.SetGravity(GravityFlags.Left);
            rightUpperblock.SetGravity(GravityFlags.Right);
            upperBlockView.AddView(leftUpperblock);
            upperBlockView.AddView(rightUpperblock);
            var headerView = new TextView(context);
            headerView.Text = header;
            headerView.SetPadding(40, 20, 15, 20);
            headerView.SetTextColor(ct);
            headerView.SetTypeface(tfHeader, TypefaceStyle.Bold);
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
            block.AddView(upperBlockView);
            middleBlock.AddView(recyclerView);
            block.AddView(middleBlock);
            var gdbd = new GradientDrawable();          
            gdbd.SetCornerRadius(40f);
            var buttonDown = new Button(context);
            buttonDown.SetTextColor(Color.ParseColor("#428BF9"));
            buttonDown.LayoutParameters = Params;
            buttonDown.Text = "Button";
            buttonDown.SetBackgroundDrawable(gdbd);

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
            block.AddView(lowerBlockView);
            block.Elevation = 2;
            var gdBlock = new GradientDrawable();
            gdBlock.SetCornerRadius(64f);
            gdBlock.SetColor(color);
            block.SetBackgroundDrawable(gdBlock);
            return block;
        }
        private void CustomButtonWhite_Click(object? sender, TouchEventArgs e)
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
        private void CustomButtonDark_Click(object? sender, TouchEventArgs e)
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
    }
}
