using Android.Content;
using Android.Graphics;

namespace ElementsUI
{
    public class CreateButton
    {
        Context mContext;
        public CreateButton(Context context)
        {
            this.mContext = context;
        }

        public Button OnCreate(string buttonText, int width, int height)
        {
            var button = new Button(mContext);
            button.Text = buttonText;
            button.SetTextColor(Color.ParseColor("#428BF9"));
            button.SetBackgroundColor(Color.ParseColor("#dedede"));
            return button;
        }
    }
}