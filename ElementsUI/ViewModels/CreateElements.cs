﻿using Android.Content;
using Android.Views;

namespace ElementsUI.ViewModels
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
        public LinearLayout CreateBlock()
        {
            var block = new LinearLayout(context);
            block.LayoutParameters = new LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.MatchParent,
            ViewGroup.LayoutParams.WrapContent);
            block.Orientation = Orientation.Vertical;
            block.SetPadding(28, 28, 28, 28);
            // Создаем и инициализируем LayoutParams
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
