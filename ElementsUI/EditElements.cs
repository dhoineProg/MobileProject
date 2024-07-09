using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;


namespace ElementsUI
{
    public class EditElements
    {
        Context context;
        public EditElements(Context context_)
        {
            context = context_;
        }
        public void SetBlockWidth(LinearLayout block, int width, int height)
        {
            LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams)block.LayoutParameters;
            layoutParams.Width = width;
            layoutParams.Height = height;
            block.LayoutParameters = layoutParams;
        }
        public void SetMarginBlock(LinearLayout block, int topMargin, int bottomMargin, int leftMargin)
        {
            block.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent)
            {
                TopMargin = topMargin,
                BottomMargin = bottomMargin,
                LeftMargin = leftMargin
            };
        }
        public void ChangeBlockWidth(LinearLayout block, int width, int height)
        {
            LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams)block.LayoutParameters;
            layoutParams.Width = width;
            layoutParams.Height = height;
            block.LayoutParameters = layoutParams;
        }
        public void ChangeBlockColor(LinearLayout block, string newColor)
        {
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            block.SetBackgroundDrawable(background);
        }
    }
}
