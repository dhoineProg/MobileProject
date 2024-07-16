using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

namespace ElementsUI
{
    public class CreateButton
    {
        Context mContext;
        public CreateButton(Context context)
        {
            this.mContext = context;
        }

        public Button OnCreate(string buttonText, int width, int height, int leftMargin, int righMargin,float gdr)
        {
            LinearLayout.LayoutParams linParams = new LinearLayout.LayoutParams(
                width,height
                );
            linParams.LeftMargin = leftMargin;
            linParams.RightMargin = righMargin;
            var button = new Button(mContext);
            button.LayoutParameters = linParams;
            button.Text = buttonText;
            var gd = new GradientDrawable();
            gd.SetCornerRadius(gdr);
            button.SetTextColor(Color.ParseColor("#428BF9"));
            gd.SetColor(Color.Argb((int)(255*0.03) ,0, 16, 36));
            button.SetBackgroundDrawable(gd);
            return button;
        }
    }
}