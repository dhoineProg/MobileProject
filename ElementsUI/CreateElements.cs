using System;
using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics;
using System.Reflection.Emit;
using Android;
using Android.Graphics.Drawables;
using Android.Text;
using System.Collections.Generic;
using System.IO;
using Android.App;
using ElementsUI;

namespace ElementsUI
{
    public class CreateElements
    {
        Context context;
        EditElements edit;
        public CreateElements(Context context_)
        {
            context = context_;
        }
        public TextView CreateLabel(string text)
        {
            TextView textView = new TextView(context);
            textView.Text = text;
            return textView;
        }
        public LinearLayout CreateBlock(int topMargin, int bottomMargin, int leftMargin)
        {
            LinearLayout block = new LinearLayout(context);
            block.Orientation = Orientation.Vertical;
            block.SetPadding(16, 16, 16, 16);
            block.Elevation = 40;
            GradientDrawable background = new GradientDrawable();
            block.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent)
            {
                TopMargin = topMargin,
                BottomMargin = bottomMargin,
                LeftMargin = leftMargin
            };
            edit.SetBlockWidth(block, 900, 220);
            return block;
        }
        public ImageView LoadImageFromResources(int resourceId)
        {
            ImageView imageView = new ImageView(context);
            imageView.SetImageResource(resourceId);
            return imageView;
        }
    }
}
