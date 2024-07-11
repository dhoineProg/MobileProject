using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using static Android.Webkit.WebSettings;
namespace ElementsUI
{
    public class AddBlockWithCross
    {
        Context context;
        public AddBlockWithCross(Context context) { this.context = context; }

        public LinearLayout AddBlock(LinearLayout block, string Title, string subTitle, int imgid, Button button, Typeface tf)
        {
            var CreateElements = new CreateElements(context);
            var EditElements = new EditElements(context);
            var horizontalLayout = new LinearLayout(context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
            var horizontalLayout2 = new LinearLayout(context);
            horizontalLayout2.Orientation = Orientation.Horizontal;
            horizontalLayout2.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
            //Создаем вертикальный layout 
            var verticalLayoutleft = new LinearLayout(context);
            verticalLayoutleft.Orientation = Orientation.Vertical;
            verticalLayoutleft.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayoutleft.SetGravity(GravityFlags.Left);
            var verticalLayoutright = new LinearLayout(context);
            verticalLayoutright.Orientation = Orientation.Vertical;
            verticalLayoutright.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayoutright.SetGravity(GravityFlags.Right);
            // Создаем TextView для заголовка
            var headerTextView = new TextView(context);
            headerTextView.Text = Title;
            headerTextView.SetTextColor(Color.ParseColor("#333333"));
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 18);
            headerTextView.SetPadding(15, 35, 15, 15);

            // Создаем TextView для субзаголовка
            var subheaderTextView = new TextView(context);
            subheaderTextView.Text = subTitle;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 14);
            subheaderTextView.SetPadding(15, 5, 15, 30);
            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayoutleft.AddView(headerTextView);
            verticalLayoutleft.AddView(subheaderTextView);
            // Создаем ImageView для изображения
            var imageView = new ImageView(context);
            imageView.SetImageResource(imgid);
            imageView.SetPadding(15, 15, 30, 15);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
                
            horizontalLayout.AddView(imageView);
            horizontalLayout.AddView(verticalLayoutleft);
            verticalLayoutright.AddView(button);
            horizontalLayout2.AddView(verticalLayoutright);

            // Создаем новый вертикальный LinearLayout для блока
            block.AddView(horizontalLayout);
            block.AddView(horizontalLayout2);
            block.Elevation = 2;
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(64f);
            background.SetColor(Color.ParseColor("#FFFFFF"));
            block.SetBackgroundDrawable(background);
            // Добавляем новый блок в родительский LinearLayout
            return block;
        }
    }
}
