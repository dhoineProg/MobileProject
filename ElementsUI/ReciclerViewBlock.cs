using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using ElementsUI;
using Android.Support.V4;
using AndroidX.RecyclerView.Widget;


namespace ElementsUI
{
    public class ReciclerViewBlock
    {
        RecyclerView recyclerView;
        Context context;
        public ReciclerViewBlock(Context context)
        {
            this.context = context;
        }
        public LinearLayout AddElements(LinearLayout block, string header, Typeface tf, Typeface tfn, int imgID)
        {
            var items = new List<Items>
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
            var recyclerView = new RecyclerView(context);
            recyclerView.SetLayoutManager(new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false));
            var adapter = new MyAdapter(items);
            
            recyclerView.SetAdapter(adapter);

            var middleBlock = new LinearLayout(context);
            var editElements = new EditElements(context);
            var upperBlockView = new LinearLayout(context);
            upperBlockView.Orientation = Orientation.Horizontal;
            var leftUpperblock = new LinearLayout(context);
            leftUpperblock.Orientation = Orientation.Vertical;
            var rightUpperblock = new LinearLayout(context);
            rightUpperblock.Orientation = Orientation.Vertical;
            var lowerBlockView = new LinearLayout(context);
            lowerBlockView.Orientation = Orientation.Horizontal;
            LinearLayout.LayoutParams Params = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            LinearLayout.LayoutParams childParams = new LinearLayout.LayoutParams(0,
            ViewGroup.LayoutParams.WrapContent,
            0.3f);
            upperBlockView.LayoutParameters = Params;
            middleBlock.LayoutParameters = Params;
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
            headerView.SetPadding(40,20,15,20);
            headerView.SetTextColor(Color.ParseColor("#333333"));
            headerView.SetTypeface(tf, TypefaceStyle.Bold);
            headerView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22);
            leftUpperblock.AddView(headerView);
            var buttonUp = new Button(context);
            buttonUp.Text = "Button";
            buttonUp.TextSize = 14;
            buttonUp.SetPadding(300, 20, 0, 20);
            var gd = new GradientDrawable();
            buttonUp.SetTextColor(Color.ParseColor("#428BF9"));
            gd.SetColor(Color.ParseColor("#FFFFFF"));
            buttonUp.SetBackgroundDrawable(gd);
            buttonUp.SetTypeface(tfn, TypefaceStyle.Bold);
            rightUpperblock.AddView(buttonUp);
            block.AddView(upperBlockView);
            middleBlock.AddView(recyclerView);
            block.AddView(middleBlock);
            var gdbd = new GradientDrawable();
            gdbd.SetColor(Color.Argb((int)(255 * 0.03), 0, 16, 36));
            gdbd.SetCornerRadius(32f);
            var buttonDown = new Button(context);        
            buttonDown.SetTextColor(Color.ParseColor("#428BF9"));
            buttonDown.LayoutParameters = Params;
            buttonDown.Text = "Button";
            buttonDown.SetBackgroundDrawable(gdbd);
            lowerBlockView.AddView(buttonDown);
            block.AddView(lowerBlockView);
            block.Elevation = 2;
            var gdBlock = new GradientDrawable();
            gdBlock.SetCornerRadius(64f);
            gdBlock.SetColor(Color.ParseColor("#FFFFFF"));
            block.SetBackgroundDrawable(gdBlock);

            return block;
        }
    }
}
