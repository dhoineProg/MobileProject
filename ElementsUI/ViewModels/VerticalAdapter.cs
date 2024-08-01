using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using ElementsUI.View;

namespace ElementsUI.ViewModels
{
    public class VerticalAdapter : RecyclerView.Adapter
    {
        #region Declaration

        static int numElement;

        #endregion

        #region Fields

        readonly List<Items> items;

        public int imgID;

        public Typeface tf;

        Color ct;

        #endregion

        #region ctor

        public VerticalAdapter(List<Items> items, int imgID, Typeface tf, Color ct)
        {
            this.items = items;
            this.imgID = imgID;
            this.tf = tf;
            this.ct = ct;
        }

        #endregion

        #region Private methods

        LinearLayout CreateItemView(Context context)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(23f);

            var view = new LinearLayout(context);
            view.Orientation = Orientation.Horizontal;
            view.SetPadding(30, 30, 0, 30);

            var layoutParams = new LinearLayout.LayoutParams(900, 200);
            layoutParams.SetMargins(10, 0, 20, 0);
            view.LayoutParameters = layoutParams;

            view.SetBackgroundDrawable(gd);
            return view;
        }

        ImageView CreateImageView(Context context)
        {
            var imageView = new ImageView(context);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(100, 100);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imgID);
            return imageView;
        }

        LinearLayout CreateTextLayout(Context context, Typeface tf, Color ct)
        {
            var textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1);
            textLayout.SetPadding(30, 0, 0, 0);

            var titleTextView = new TextView(context);
            titleTextView.TextSize = 20;
            titleTextView.SetTypeface(tf, TypefaceStyle.Normal);
            titleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            titleTextView.SetTextColor(ct);

            var subtitleTextView = new TextView(context);
            subtitleTextView.TextSize = 14f;
            subtitleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            subtitleTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subtitleTextView.SetTextColor(Color.ParseColor("#9299A2"));

            textLayout.AddView(titleTextView);
            textLayout.AddView(subtitleTextView);

            return textLayout;
        }

        #endregion

        #region Overriden based methods

        public override int ItemCount => items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            (holder as ItemViewHolderVertical).Bind(items[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = CreateItemView(parent.Context);
            var imageView = CreateImageView(parent.Context);
            var textLayout = CreateTextLayout(parent.Context, tf, ct);

            view.AddView(imageView);
            view.AddView(textLayout);

            return new ItemViewHolderVertical(view, imageView, textLayout.GetChildAt(0) as TextView, textLayout.GetChildAt(1) as TextView);
        }

        #endregion
    }
}
