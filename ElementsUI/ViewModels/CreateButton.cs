using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;

namespace ElementsUI.ViewModels
{
    public class CreateButton
    {
        Context mContext;
        public CreateButton(Context context)
        {
            mContext = context;
        }

        public Button OnCreate(string buttonText, int width, int height, int leftMargin, int righMargin, float gdr, Color color)
        {
            LinearLayout.LayoutParams linParams = new LinearLayout.LayoutParams(
                width, height
                );
            linParams.LeftMargin = leftMargin;
            linParams.RightMargin = righMargin;
            var button = new Button(mContext);
            button.LayoutParameters = linParams;
            button.Text = buttonText;
            var gd = new GradientDrawable();
            gd.SetCornerRadius(gdr);
            button.SetTextColor(Color.ParseColor("#428BF9"));
            gd.SetColor(color);
            button.SetBackgroundDrawable(gd);
            return button;
        }
    }
}