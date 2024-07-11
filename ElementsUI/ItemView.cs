using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4;
using ElementsUI;


namespace ElementsUI
{
    public class ItemView : LinearLayout
    {
        readonly TextView _textView;

        public ItemView(Context context) : base(context)
        {
            Orientation = Orientation.Vertical;
            LayoutParameters = new ViewGroup.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);

            _textView = new TextView(context);
            AddView(_textView);
        }

        public void SetText(string text)
        {
            _textView.Text = text;
        }
    }
}
