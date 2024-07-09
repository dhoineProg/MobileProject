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

        public TextView CreateLabel(string text)
        {

            TextView textView = new TextView(_context);
            textView.Text = text;
            return textView;
        }
        public void SetBlockWidth(LinearLayout block, int width, int height)
        {
            LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams)block.LayoutParameters;
            layoutParams.Width = width;
            layoutParams.Height = height;
            block.LayoutParameters = layoutParams;
        }


        public LinearLayout CreateBlock(int topMargin, int bottomMargin, int leftMargin)
        {
            LinearLayout block = new LinearLayout(_context);
            block.Orientation = Orientation.Vertical;
            block.SetPadding(16, 16, 16, 16);
            block.Elevation = 40;
            GradientDrawable background = new GradientDrawable();
            //background.SetCornerRadius(80f);

            block.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent)
            {

                TopMargin = topMargin,
                BottomMargin = bottomMargin,
                LeftMargin = leftMargin
            };

            SetBlockWidth(block, 900, 220);

            return block;
        }


        public ImageView LoadImageFromResources(int resourceId)
        {
            ImageView imageView = new ImageView(_context);
            imageView.SetImageResource(resourceId);
            return imageView;
        }

        public void ChangeBlockWidth(LinearLayout block, int width, int height)
        {
            LinearLayout.LayoutParams layoutParams = (LinearLayout.LayoutParams)block.LayoutParameters;
            layoutParams.Width = width;
            layoutParams.Height = height;
            block.LayoutParameters = layoutParams;
        }

        public void ChangeBlockWidth(LinearLayout block, string newColor)
        {
            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            block.SetBackgroundDrawable(background);
        }

        public LinearLayout AddLabelAndImageToBlock(string headerText, int imageResourceId,  string newColor, Typeface tf, string subheaderText = null, Button button = null, bool imageOnLeft = true)
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
            headerTextView.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);

            // Создаем TextView для субзаголовка
            TextView subheaderTextView = new TextView(_context);
            subheaderTextView.Text = subheaderText;
            subheaderTextView.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);

            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView);
            verticalLayout.AddView(subheaderTextView);

            // Создаем ImageView для изображения
            ImageView imageView = new ImageView(_context);
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
            LinearLayout newBlock = CreateBlock(60, 82, 40); // Задаем отступы для блока
            newBlock.AddView(horizontalLayout);

            if (button != null)
            {
                button.LayoutParameters = new LinearLayout.LayoutParams(
                    ViewGroup.LayoutParams.MatchParent,
                    ViewGroup.LayoutParams.WrapContent);
                newBlock.AddView(button);
            }
            else
            {
                button = null;
            }

            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            newBlock.SetBackgroundDrawable(background);

            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(newBlock);

            return newBlock;
        }

        public LinearLayout AddAnyElementsToBlock(int imageResourceId1,string headerText1, string subheaderText1,
                                                  int imageResourceId2,string headerText2, string subheaderText2,
                                                  int imageResourceId3, string headerText3, string subheaderText3,
                                                  int imageResourceId4, string headerText4, string subheaderText4,
                                                  string newColor, Typeface tf, bool imageOnLeft = true, Button button = null)
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
            TextView headerTextView1 = new TextView(_context);
            headerTextView1.Text = headerText1;
            headerTextView1.SetTextColor(Color.ParseColor("#333333"));
            headerTextView1.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            TextView headerTextView2 = new TextView(_context);
            headerTextView2.Text = headerText2;
            headerTextView2.SetTextColor(Color.ParseColor("#333333"));
            headerTextView2.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView2.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            TextView headerTextView3 = new TextView(_context);
            headerTextView3.Text = headerText3;
            headerTextView3.SetTextColor(Color.ParseColor("#333333"));
            headerTextView3.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView3.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            TextView headerTextView4 = new TextView(_context);
            headerTextView4.Text = headerText4;
            headerTextView4.SetTextColor(Color.ParseColor("#333333"));
            headerTextView4.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView4.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);

            // Создаем TextView для субзаголовка
            TextView subheaderTextView1 = new TextView(_context);
            subheaderTextView1.Text = subheaderText1;
            subheaderTextView1.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView1.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            TextView subheaderTextView2 = new TextView(_context);
            subheaderTextView2.Text = subheaderText2;
            subheaderTextView2.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView2.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView2.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            TextView subheaderTextView3 = new TextView(_context);
            subheaderTextView3.Text = subheaderText3;
            subheaderTextView3.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView3.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView3.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            TextView subheaderTextView4 = new TextView(_context);
            subheaderTextView4.Text = subheaderText4;
            subheaderTextView4.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView4.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView4.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);

            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView1);
            verticalLayout.AddView(headerTextView2);
            verticalLayout.AddView(headerTextView3);
            verticalLayout.AddView(headerTextView4);
            verticalLayout.AddView(subheaderTextView1);
            verticalLayout.AddView(subheaderTextView2);
            verticalLayout.AddView(subheaderTextView3);
            verticalLayout.AddView(subheaderTextView4);

            // Создаем ImageView для изображения
            ImageView imageView1 = new ImageView(_context);
            imageView1.SetImageResource(imageResourceId1);
            imageView1.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            ImageView imageView2 = new ImageView(_context);
            imageView2.SetImageResource(imageResourceId2);
            imageView2.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            ImageView imageView3 = new ImageView(_context);
            imageView3.SetImageResource(imageResourceId3);
            imageView3.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            ImageView imageView4 = new ImageView(_context);
            imageView4.SetImageResource(imageResourceId4);
            imageView4.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);

            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
            if (imageOnLeft)
            {
                horizontalLayout.AddView(imageView1);
                horizontalLayout.AddView(imageView2);
                horizontalLayout.AddView(imageView3);
                horizontalLayout.AddView(imageView4);
                horizontalLayout.AddView(verticalLayout);
            }
            else
            {
                horizontalLayout.AddView(verticalLayout);
                horizontalLayout.AddView(imageView1);
                horizontalLayout.AddView(imageView2);
                horizontalLayout.AddView(imageView3);
                horizontalLayout.AddView(imageView4);
            }

            // Создаем новый вертикальный LinearLayout для блока
            LinearLayout newBlock = CreateBlock(60, 82, 40); // Задаем отступы для блока
            newBlock.AddView(horizontalLayout);

            if (button != null)
            {
                button.LayoutParameters = new LinearLayout.LayoutParams(
                    ViewGroup.LayoutParams.MatchParent,
                    ViewGroup.LayoutParams.WrapContent);
                newBlock.AddView(button);
            }
            else
            {
                button = null;
            }

            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            newBlock.SetBackgroundDrawable(background);

            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(newBlock);

            return newBlock;
        }

        public LinearLayout AddAnyElementsToBlock(int imageResourceId1, string headerText1, string subheaderText1,
                                                  int imageResourceId2, string headerText2, string subheaderText2,
                                                  string newColor, Typeface tf, Button button = null)
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
            TextView headerTextView1 = new TextView(_context);
            headerTextView1.Text = headerText1;
            headerTextView1.SetTextColor(Color.ParseColor("#333333"));
            headerTextView1.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            TextView headerTextView2 = new TextView(_context);
            headerTextView2.Text = headerText2;
            headerTextView2.SetTextColor(Color.ParseColor("#333333"));
            headerTextView2.SetTypeface(tf, TypefaceStyle.Bold);
            headerTextView2.SetTextSize(Android.Util.ComplexUnitType.Sp, 22f);
            TextView headerTextView3 = new TextView(_context);

            // Создаем TextView для субзаголовка
            TextView subheaderTextView1 = new TextView(_context);
            subheaderTextView1.Text = subheaderText1;
            subheaderTextView1.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView1.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView1.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);
            TextView subheaderTextView2 = new TextView(_context);
            subheaderTextView2.Text = subheaderText2;
            subheaderTextView2.SetTextColor(Color.ParseColor("#9299A2"));
            subheaderTextView2.SetTypeface(tf, TypefaceStyle.Normal);
            subheaderTextView2.SetTextSize(Android.Util.ComplexUnitType.Sp, 16f);

            // Добавляем TextView для заголовка и субзаголовка в вертикальный LinearLayout
            verticalLayout.AddView(headerTextView1);
            verticalLayout.AddView(headerTextView2);

            verticalLayout.AddView(subheaderTextView1);
            verticalLayout.AddView(subheaderTextView2);


            // Создаем ImageView для изображения
            ImageView imageView1 = new ImageView(_context);
            imageView1.SetImageResource(imageResourceId1);
            imageView1.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);
            ImageView imageView2 = new ImageView(_context);
            imageView2.SetImageResource(imageResourceId2);
            imageView2.LayoutParameters = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.WrapContent,
                ViewGroup.LayoutParams.WrapContent);


            // Добавляем вертикальный LinearLayout и ImageView в горизонтальный LinearLayout
             horizontalLayout.AddView(imageView1);
             horizontalLayout.AddView(imageView2);
             horizontalLayout.AddView(verticalLayout);


            // Создаем новый вертикальный LinearLayout для блока
            LinearLayout newBlock = CreateBlock(60, 82, 40); // Задаем отступы для блока
            newBlock.AddView(horizontalLayout);

            if (button != null)
            {
                button.LayoutParameters = new LinearLayout.LayoutParams(
                    ViewGroup.LayoutParams.MatchParent,
                    ViewGroup.LayoutParams.WrapContent);
                newBlock.AddView(button);
            }
            else
            {
                button = null;
            }

            GradientDrawable background = new GradientDrawable();
            background.SetCornerRadius(26f);
            background.SetColor(Color.ParseColor(newColor));
            newBlock.SetBackgroundDrawable(background);

            // Добавляем новый блок в родительский LinearLayout
            blocks.Add(newBlock);
            return newBlock;
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
