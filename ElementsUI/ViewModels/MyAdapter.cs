using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using ElementsUI.View;

namespace ElementsUI.ViewModels
{
    public class MyAdapter : RecyclerView.Adapter
    {
        readonly List<Items> items;
        public int imgID;

        public MyAdapter(List<Items> items, int imgID)
        {
            this.items = items;
            this.imgID = imgID;
        }

        public override int ItemCount => items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            (holder as ItemViewHolder).Bind(items[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(Color.ParseColor("#edeef0"));
            gd.SetCornerRadius(23f);
            var view = new LinearLayout(parent.Context);
            view.Orientation = Orientation.Horizontal;
            view.SetPadding(30, 30, 0, 30);
            var layoutParams = new LinearLayout.LayoutParams(420, 420);
            layoutParams.SetMargins(30, 30, 30, 50);
            view.LayoutParameters = layoutParams;
            // Добавление тени
            view.Elevation = 2f;
            view.SetBackgroundDrawable(gd);
            var imageView = new ImageView(parent.Context);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(128, 128);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imgID);
            var textLayout = new LinearLayout(parent.Context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1);
            textLayout.SetPadding(0, 0, 0, 0);
            var titleTextView = new TextView(parent.Context);
            titleTextView.TextSize = 18f;
            titleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            var subtitleTextView = new TextView(parent.Context);
            subtitleTextView.TextSize = 14f;
            subtitleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            textLayout.AddView(titleTextView);
            textLayout.AddView(subtitleTextView);
            view.AddView(imageView);
            view.AddView(textLayout);
            return new ItemViewHolder(view, imageView, titleTextView, subtitleTextView);
        }
    }
}
