using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics;

namespace LibraryClasses
{
    public class CreateButton
    {
        Context mContext;
        public CreateButton(Context context)
        {
            this.mContext = context;
        }

        public Button OnCreate(string buttonText, int width, int height)
        {
            Button button = new Button(mContext);
            button.Text = buttonText;
            button.SetTextColor(Color.ParseColor("#428BF9"));
            button.SetBackgroundColor(Color.ParseColor("#dedede"));
            return button;
        }
    }
}