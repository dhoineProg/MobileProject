using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using ElementsUI.View;

namespace ElementsUI.ViewModels
{
    public class MyAdapter : RecyclerView.Adapter
    {
        #region Fields

        readonly List<Items> items;
        public int imgID;

        #endregion

        #region ctor

        public MyAdapter(List<Items> items, int imgID)
        {
            this.items = items;
            this.imgID = imgID;
        }

        #endregion

        #region Private methods

        LinearLayout CreateBlockView(Android.Content.Context context)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Color.ParseColor("#edeef0"));
            gd.SetCornerRadius(23f);

            var view = new LinearLayout(context);
            view.Orientation = Orientation.Horizontal;
            view.SetPadding(30, 30, 0, 30);

            var layoutParams = new LinearLayout.LayoutParams(420, 420);
            layoutParams.SetMargins(30, 30, 30, 50);
            view.LayoutParameters = layoutParams;

            view.Elevation = 2f;
            view.SetBackgroundDrawable(gd);

            return view;
        }

        ImageView CreateImageView(Android.Content.Context context)
        {
            var imageView = new ImageView(context);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(128, 128);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imgID);

            return imageView;
        }

        LinearLayout CreateTextLayout(Android.Content.Context context)
        {
            var textLayout = new LinearLayout(context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1);
            textLayout.SetPadding(0, 0, 0, 0);

            return textLayout;
        }

        TextView CreateTitleTextView(Android.Content.Context context)
        {
            var titleTextView = new TextView(context);
            titleTextView.TextSize = 18f;
            titleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;

            return titleTextView;
        }

        TextView CreateSubtitleTextView(Android.Content.Context context)
        {
            var subtitleTextView = new TextView(context);
            subtitleTextView.TextSize = 14f;
            subtitleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;

            return subtitleTextView;
        }

        void SetupLayout(LinearLayout view, ImageView imageView, LinearLayout textLayout)
        {
            view.AddView(imageView);
            view.AddView(textLayout);
        }
        #endregion

        #region Overriden base methods

        public override int ItemCount => items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            (holder as ItemViewHolder).Bind(items[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = CreateBlockView(parent.Context);
            var imageView = CreateImageView(parent.Context);
            var textLayout = CreateTextLayout(parent.Context);
            var titleTextView = CreateTitleTextView(parent.Context);
            var subtitleTextView = CreateSubtitleTextView(parent.Context);

            SetupLayout(view, imageView, textLayout);
            textLayout.AddView(titleTextView);
            textLayout.AddView(subtitleTextView);

            return new ItemViewHolder(view, imageView, titleTextView, subtitleTextView);
        }

        #endregion

    }
}
