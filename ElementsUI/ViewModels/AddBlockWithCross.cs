using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
namespace ElementsUI.ViewModels
{
    public class AddBlockWithCross
    {

        #region Fields

        Context context;

        #endregion

        #region ctor

        public AddBlockWithCross(Context context) { this.context = context; }

        #endregion

        #region Private methods

        private LinearLayout CreateHorizontalLayout()
        {
            var horizontalLayout = new LinearLayout(context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(900, 200);
            horizontalLayout.SetGravity(GravityFlags.CenterVertical);
            return horizontalLayout;
        }

        private LinearLayout CreateVerticalLayout()
        {
            var leftLayout = new LinearLayout(context);
            leftLayout.Orientation = Orientation.Vertical;
            leftLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1f);
            return leftLayout;
        }

        private TextView CreateTitleTextView(string title, Typeface tf, Color ct)
        {
            var headerTextView = new TextView(context);
            headerTextView.Text = title;
            headerTextView.SetTextColor(ct);
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 20);
            headerTextView.SetPadding(15, 0, 15, 15);
            return headerTextView;
        }

        private TextView CreateSubtitleTextView(string subTitle, Typeface tf)
        {
            var subheaderTextView = new TextView(context);
            subheaderTextView.Text = subTitle;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 14);
            subheaderTextView.SetPadding(15, 0, 15, 0);
            return subheaderTextView;
        }

        private ImageView CreateImageView(int imgid)
        {
            var imageView = new ImageView(context);
            imageView.SetImageResource(imgid);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            return imageView;
        }

        private void AddElementsToLayouts(LinearLayout horizontalLayout, LinearLayout leftLayout, ImageView imageView, TextView headerTextView, TextView subheaderTextView, Button button)
        {
            horizontalLayout.AddView(imageView);
            imageView.SetPadding(15, 15, 30, 15);
            leftLayout.AddView(headerTextView);
            leftLayout.AddView(subheaderTextView);
            horizontalLayout.AddView(leftLayout);
            leftLayout.SetPadding(5, 40, 0, 0);
            horizontalLayout.AddView(button);
        }

        private void SetBlockBackground(LinearLayout block, Color color)
        {
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(64f);
            background.SetColor(color);
            block.SetBackgroundDrawable(background);
        }

        #endregion

        #region Public methods

        public LinearLayout AddBlock(LinearLayout block, string title, string subTitle, int imgid, Button button, Typeface tf, Color color, Color ct)
        {
            var horizontalLayout = CreateHorizontalLayout();
            var leftLayout = CreateVerticalLayout();
            var headerTextView = CreateTitleTextView(title, tf, ct);
            var subheaderTextView = CreateSubtitleTextView(subTitle, tf);
            var imageView = CreateImageView(imgid);

            AddElementsToLayouts(horizontalLayout, leftLayout, imageView, headerTextView, subheaderTextView, button);

            block.AddView(horizontalLayout);
            block.Elevation = 2;
            SetBlockBackground(block, color);

            return block;
        }

        #endregion

    }
}
