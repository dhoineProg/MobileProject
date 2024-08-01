using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;


namespace ElementsUI.ViewModels
{
    public class EditElements
    {
        #region Fields

        Context context;

        #endregion

        #region ctor

        public EditElements(Context context_)
        {
            context = context_;
        }

        #endregion

        #region Public methods
        public void SetBlockWidth(LinearLayout block, int width, int height)
        {
            block.LayoutParameters = new LinearLayout.LayoutParams(
                width, height
                )
            {
                Width = width,
                Height = height
            };
        }
        public void SetMarginBlock(LinearLayout block, int topMargin, int bottomMargin, int leftMargin, int rightMargin)
        {
            block.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent)
            {
                TopMargin = topMargin,
                BottomMargin = bottomMargin,
                LeftMargin = leftMargin,
                RightMargin = rightMargin
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

        #endregion
    }
}
