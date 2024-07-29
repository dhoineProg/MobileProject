using Android.Content;
using Android.Views;


namespace ElementsUI.View
{
    public class ItemViewVertical : LinearLayout
    {

        #region Fields

        readonly TextView _textView;
        readonly ImageView _imageView;

        #endregion

        #region ctor

        public ItemViewVertical(Context context) : base(context)
        {
            Orientation = Orientation.Vertical;
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
