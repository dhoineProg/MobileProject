﻿using System;
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
    public class CreateElements
    {
        Context context;
        EditElements edit;
        public CreateElements(Context context_)
        {
            context = context_;
        }
        public TextView CreateLabel(string text)
        {
            var textView = new TextView(context);
            textView.Text = text;
            return textView;
        }
        public LinearLayout CreateBlock(int width, int height)
        {
            var block = new LinearLayout(context);
            block.Orientation = Orientation.Vertical;
            block.SetPadding(16, 16, 16, 16);
            block.Elevation = 40;
            GradientDrawable background = new GradientDrawable();
            // Создаем и инициализируем LayoutParams
            LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(
                ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.MatchParent);
            layoutParams.Width = width;
            layoutParams.Height = height;
            block.LayoutParameters = layoutParams;

            return block;
        }
        public ImageView LoadImageFromResources(int resourceId)
        {
            var imageView = new ImageView(context);
            imageView.SetImageResource(resourceId);
            return imageView;
        }
    }
}
