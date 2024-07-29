using AndroidX.RecyclerView.Widget;
using ElementsUI.ViewModels;

namespace ElementsUI.View
{
    public class ItemViewHolderVertical : RecyclerView.ViewHolder
    {

        #region  Fields

        public ImageView _imageView;
        public TextView _titleTextView;
        public TextView _subtitleTextView;

        #endregion

        #region ctor

        public ItemViewHolderVertical(Android.Views.View itemView, ImageView imageView, TextView titleTextView, TextView subtitleTextView) : base(itemView)
        {
            _imageView = imageView;
            _titleTextView = titleTextView;
            _subtitleTextView = subtitleTextView;

        }

        #endregion

        #region Public methods

        public void Bind(Items item)
        {
            _imageView.SetImageResource(item.Img);
            _titleTextView.Text = item.Title;
            _subtitleTextView.Text = item.Subtitle;
        }

        #endregion

    }
}
