using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4;
using AndroidX.CardView;
using ElementsUI;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace ElementsUI
{
    public class ItemViewHolder : RecyclerView.ViewHolder
    {
        public ImageView _imageView;
        public TextView _titleTextView;
        public TextView _subtitleTextView;

        public ItemViewHolder(Android.Views.View itemView, ImageView imageView, TextView titleTextView, TextView subtitleTextView) : base(itemView)
        {
            _imageView = imageView;
            _titleTextView = titleTextView;
            _subtitleTextView = subtitleTextView;

        }

        public void Bind(Items item)
        {
            _imageView.SetImageBitmap(BitmapFactory.DecodeResource(ItemView.Resources, Resource.Drawable.abc_star_black_48dp));
            _titleTextView.Text = item.Title;
            _subtitleTextView.Text = item.Subtitle;
        }
    }
}
