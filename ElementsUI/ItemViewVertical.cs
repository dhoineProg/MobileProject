using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4;
using ElementsUI;


namespace ElementsUI
{
    public class ItemViewVertical : LinearLayout
    {
        readonly TextView _textView;
        readonly ImageView _imageView;

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
    }
}
