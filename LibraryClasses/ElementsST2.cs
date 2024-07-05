using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using LibraryClasses;
using System.Linq;
using System.Text;

namespace LibraryClasses
{
    public class ElementsST2
    {
        private Context _context;

        private List<LinearLayout> blocks;
        public ElementsST2(Context context)
        {
            _context = context;
            blocks = new List<LinearLayout>();
        }

        public TextView CreateLabel(string text)
        {
            TextView textView = new TextView(_context);
            textView.Text = text;
            return textView;
        }

        public LinearLayout CreateBlock(int topMargin, int bottomMargin,int leftMargin)
        {
            LinearLayout block = new LinearLayout(_context);
            block.Orientation = Orientation.Vertical;
            block.SetPadding(16, 16, 16, 16);
            block.Elevation = 40;
            GradientDrawable background = new GradientDrawable();
           // background.SetCornerRadius(30f);

            block.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent)
            {
                TopMargin = topMargin,
                LeftMargin = leftMargin,
                BottomMargin = bottomMargin
            };
            Elements element = new Elements(_context);
            element.SetBlockWidth(block, 980, 220);
            return block;
        }

        public ImageView LoadImageFromResources(int resourceId)
        {
            ImageView imageView = new ImageView(_context);
            imageView.SetImageResource(resourceId);
            return imageView;
        }

        public void AddLabelAndImageToBlock(string headerText, int imageResourceId, string newColor, Typeface tf)
        {
            // Создаем горизонтальный LinearLayout
            LinearLayout horizontalLayout = new LinearLayout(_context);
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
            TextView headerTextView = new TextView(_context);
            headerTextView.Text = headerText;
            headerTextView.SetTextColor(Color.ParseColor("#333333"));
            //headerTextView.SetTypeface(Typeface.SansSerif, TypefaceStyle.Bold);
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);


            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView);


            // Создаем ImageView для изображения
            ImageView imageView = new ImageView(_context);
            imageView.SetImageResource(imageResourceId);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);

            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
            horizontalLayout.AddView(verticalLayout);
            horizontalLayout.AddView(imageView);

            // Создаем новый вертикальный LinearLayout для блока
            LinearLayout newBlock = CreateBlock(60,160, 32);
            newBlock.AddView(horizontalLayout);
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            newBlock.SetBackgroundDrawable(background);


            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(newBlock);
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