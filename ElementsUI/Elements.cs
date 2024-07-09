using System;
using Android.Widget;
using Android.Content;
using Android.Views;
using Android.Graphics;
using System.Reflection.Emit;
using Android;
using Android.Graphics.Drawables;
using Android.Text;
using System.Collections.Generic;
using System.IO;
using Android.App;
using ElementsUI;



namespace ElementsUI
{
    public class Elements
    {
        Context _context;
        Activity act;
        List<LinearLayout> blocks;
        
        public Elements(Context context)
        {
            _context = context;
            blocks = new List<LinearLayout>();
        }
        public LinearLayout AddLabelAndImageToBlock(LinearLayout block, string headerText, int imageResourceId, string newColor, Typeface tf, string subheaderText = null, Button button = null, bool imageOnLeft = true)
        {
            CreateElements CreateElements = new CreateElements(_context);
            EditElements EditElements = new EditElements(_context);
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
            verticalLayout.SetGravity(GravityFlags.Start);
            // Создаем TextView для заголовка
            var headerTextView = new TextView(_context);
            headerTextView.Text = headerText;
            headerTextView.SetTextColor(Color.ParseColor("#333333"));
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            // Создаем TextView для субзаголовка
            var subheaderTextView = new TextView(_context);
            subheaderTextView.Text = subheaderText;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView);
            verticalLayout.AddView(subheaderTextView);
            // Создаем ImageView для изображения
            var imageView = new ImageView(_context);
            imageView.SetImageResource(imageResourceId);
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
            EditElements.SetMarginBlock(block, 60, 82, 40); // Задаем отступы для блока
            block.AddView(horizontalLayout);

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
                button.LayoutParameters = new LinearLayout.LayoutParams(
                    ViewGroup.LayoutParams.MatchParent,
                    ViewGroup.LayoutParams.WrapContent);
                block.AddView(button);
            }
            else
            {
                button = null;
            }

            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            block.SetBackgroundDrawable(background);

            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(block);
            return block;
        }
        public LinearLayout AddAnyElementsToBlock(LinearLayout block, int imageResourceId1, string headerText1, string subheaderText1,
                                                  string newColor, Typeface tf, bool imageOnLeft = true, Button button = null)
        {
            CreateElements CreateElements = new CreateElements(_context);
            EditElements EditElements = new EditElements(_context);
            // Создаем горизонтальный LinearLayout
            var horizontalLayout = new LinearLayout(_context);
            horizontalLayout.Orientation = Orientation.Horizontal;
            horizontalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);
            horizontalLayout.SetGravity(GravityFlags.CenterVertical);

            // Создаем вертикальный LinearLayout для заголовка и субзаголовка
            LinearLayout verticalLayout = new LinearLayout(_context);
            verticalLayout.Orientation = Orientation.Vertical;
            verticalLayout.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                ViewGroup.LayoutParams.WrapContent,
                1.0f);
            verticalLayout.SetGravity(GravityFlags.Start);
            // Создаем TextView для заголовка
            var headerTextView1 = new TextView(_context);
            headerTextView1.Text = headerText1;
            headerTextView1.SetTextColor(Color.ParseColor("#333333"));
            headerTextView1.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            // Создаем TextView для субзаголовка
            var subheaderTextView1 = new TextView(_context);
            subheaderTextView1.Text = subheaderText1;
            subheaderTextView1.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView1.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView1);
            verticalLayout.AddView(subheaderTextView1);
            // Создаем ImageView для изображения
            var imageView1 = new ImageView(_context);
            imageView1.SetImageResource(imageResourceId1);
            imageView1.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
            if (imageOnLeft)
            {
                horizontalLayout.AddView(imageView1);
                horizontalLayout.AddView(verticalLayout);
            }
            else
            {
                horizontalLayout.AddView(verticalLayout);
                horizontalLayout.AddView(imageView1);
            }
            // Создаем новый вертикальный LinearLayout для блока
            EditElements.SetMarginBlock(block, 60, 82, 40); // Задаем отступы для блока
            block.AddView(horizontalLayout);
            var background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            block.SetBackgroundDrawable(background);
            // Добавляем новый блок в родительский LinearLayout
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
    }
}
