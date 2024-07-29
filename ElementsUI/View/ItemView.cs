using Android.Content;
using Android.Views;


namespace ElementsUI.View
{
    public class ItemView : LinearLayout
    {
        #region Fields

        readonly TextView _textView;
        readonly ImageView _imageView;

        #endregion

        #region ctor

        public ItemView(Context context) : base(context)
        {
            Orientation = Orientation.Horizontal;
            LayoutParameters = new ViewGroup.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);

            _textView = new TextView(context);
            _imageView = new ImageView(context);
            AddView(_textView);
            AddView(_imageView);
        }

        #endregion

    }
}
