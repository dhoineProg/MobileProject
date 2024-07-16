using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using static Android.Webkit.WebSettings;
using static Android.Icu.Text.CaseMap;
namespace ElementsUI
{
    public class AddBlockWithCross
    {
        Context context;
        public AddBlockWithCross(Context context) { this.context = context;}

        public LinearLayout AddBlock(LinearLayout block, string title, string subTitle, int imgid, Button button, Typeface tf, Color color)
        {
            // Создаем горизонтальный LinearLayout
            var horizontalLayout = new LinearLayout(context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                 900,
               200);
            horizontalLayout.SetGravity(GravityFlags.CenterVertical);
            var leftLayout = new LinearLayout(context);
            leftLayout.Orientation = Orientation.Vertical;
            leftLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1f);
            // Создаем TextView для заголовка
            var headerTextView = new TextView(context);
            headerTextView.Text = title;
            headerTextView.SetTextColor(Color.ParseColor("#333333"));
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 20);
            headerTextView.SetPadding(15, 0, 15, 15);

            // Создаем TextView для субзаголовка
            var subheaderTextView = new TextView(context);
            subheaderTextView.Text = subTitle;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 14);
            subheaderTextView.SetPadding(15, 0, 15, 0);
            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            // Создаем ImageView для изображения
            var imageView = new ImageView(context);
            imageView.SetImageResource(imgid);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
            horizontalLayout.AddView(imageView);
            imageView.SetPadding(15, 15, 30, 15);
            leftLayout.AddView(headerTextView);
            leftLayout.AddView(subheaderTextView);
            horizontalLayout.AddView(leftLayout);
            leftLayout.SetPadding(5,40,0,0);
            horizontalLayout.AddView(button);
           //button.SetPadding(16, 0, 0, 100);

            // Создаем новый вертикальный LinearLayout для блока
            block.AddView(horizontalLayout);
            block.Elevation = 2;

            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(64f);
            background.SetColor(color);
            block.SetBackgroundDrawable(background);
            // Добавляем новый блок в родительский LinearLayout
            return block;
        }
    }
}
