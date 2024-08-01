using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;



namespace ElementsUI.ViewModels
{
    public class Elements
    {
        #region Fields

        Context _context;

        Activity act;

        List<LinearLayout> blocks;

        #endregion

        #region ctor

        public Elements(Context context)
        {
            _context = context;
            blocks = new List<LinearLayout>();
        }

        #endregion

        #region Private methods

        void CreateHorizontalLayout(out LinearLayout horizontalLayout)
        {
            horizontalLayout = new LinearLayout(_context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
        }

        void CreateVerticalLayouts(out LinearLayout verticalLayoutLeft, out LinearLayout verticalLayoutRight)
        {
            verticalLayoutLeft = new LinearLayout(_context);
            verticalLayoutLeft.Orientation = Orientation.Vertical;
            verticalLayoutLeft.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayoutLeft.SetGravity(GravityFlags.Left);

            verticalLayoutRight = new LinearLayout(_context);
            verticalLayoutRight.Orientation = Orientation.Vertical;
            verticalLayoutRight.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayoutRight.SetGravity(GravityFlags.Right);
        }

        void CreateTitleView(string title, Typeface tf, out TextView titleView)
        {
            titleView = new TextView(_context);
            titleView.Text = title;
            titleView.SetTextColor(Color.ParseColor("#333333"));
            titleView.SetTypeface(tf, TypefaceStyle.Bold);
            titleView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            titleView.SetPadding(15, 15, 15, 40);
        }

        void SetupLayouts(LinearLayout horizontalLayout, LinearLayout verticalLayoutLeft, LinearLayout verticalLayoutRight, TextView titleView, Button btn)
        {
            verticalLayoutLeft.AddView(titleView);
            verticalLayoutRight.AddView(btn);
            horizontalLayout.AddView(verticalLayoutLeft);
            horizontalLayout.AddView(verticalLayoutRight);
        }

        void SetBlockBackground(LinearLayout block)
        {
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(52f);
            block.SetBackgroundDrawable(background);
        }

        #endregion

        #region Public methods

        public LinearLayout AddLabelAndImageToBlock(LinearLayout block, string headerText, int imageResourceId, string newColor, string newColorText, Typeface tf, Typeface tfs, TypefaceStyle tfsn, int textsize, int subtextsize, string subheaderText = null, Button button = null, bool imageOnLeft = true)
        {
            var CreateElements = new CreateElements(_context);
            var EditElements = new EditElements(_context);
            // Создаем горизонтальный LinearLayout
            var horizontalLayout = new LinearLayout(_context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
            horizontalLayout.SetGravity(GravityFlags.CenterVertical);
            // Создаем вертикальный LinearLayout для заголовка и субзаголовка
            var verticalLayout = new LinearLayout(_context);
            verticalLayout.Orientation = Orientation.Vertical;
            verticalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayout.SetGravity(GravityFlags.Center);
            // Создаем TextView для заголовка
            var headerTextView = new TextView(_context);
            headerTextView.Text = headerText;
            headerTextView.SetTextColor(Color.ParseColor(newColorText));
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, textsize);
            headerTextView.SetPadding(15, 35, 15, 15);

            // Создаем TextView для субзаголовка
            var subheaderTextView = new TextView(_context);
            subheaderTextView.Text = subheaderText;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, tfsn);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, subtextsize);
            subheaderTextView.SetPadding(15, 5, 15, 30);
            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView);
            verticalLayout.AddView(subheaderTextView);
            // Создаем ImageView для изображения
            var imageView = new ImageView(_context);
            imageView.SetImageResource(imageResourceId);
            imageView.SetPadding(15, 15, 30, 15);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
            if (imageOnLeft)
            {
                horizontalLayout.AddView(imageView);
                horizontalLayout.AddView(verticalLayout);
            }
            else
            {
                horizontalLayout.AddView(verticalLayout);
                horizontalLayout.AddView(imageView);
            }
            // Создаем новый вертикальный LinearLayout для блока
            block.AddView(horizontalLayout);
            block.Elevation = 2;

            if (button != null)
            {
                // Сначала проверяем, есть ли у button родительский элемент
                ViewGroup buttonParent = (ViewGroup)button.Parent;
                if (buttonParent != null)
                {
                    // Если есть, удаляем button из его родительского элемента
                    buttonParent.RemoveView(button);
                }

                // Теперь можно добавить button в block
                block.AddView(button);
            }
            else
            {
                button = null;
            }
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(64f);
            background.SetColor(Color.ParseColor(newColor));
            if (subheaderText == null)
            {
                headerTextView.SetPadding(10, 80, 60, 0);
                EditElements.SetBlockWidth(block, ViewGroup.LayoutParams.MatchParent, 200);
            }
            block.SetBackgroundDrawable(background);
            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(block);
            return block;
        }

        public LinearLayout AddToBlock(LinearLayout block, Button btn, string title = null, Typeface tf = null)
        {
            CreateHorizontalLayout(out var horizontalLayout);
            CreateVerticalLayouts(out var verticalLayoutLeft, out var verticalLayoutRight);
            CreateTitleView(title, tf, out var titleView);

            SetupLayouts(horizontalLayout, verticalLayoutLeft, verticalLayoutRight, titleView, btn);
            SetBlockBackground(block);
            block.AddView(horizontalLayout);
            blocks.Add(block);
            return block;
        }

        public void DisplayBlocks(ViewGroup parentLayout)
        {
            foreach (LinearLayout block in blocks)
            {
                parentLayout.AddView(block);
            }
        }

        #endregion

    }
}
