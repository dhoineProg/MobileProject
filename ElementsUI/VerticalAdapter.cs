using Android.Graphics.Drawables;
using Android.Views;
using Android.Graphics;
using AndroidX.RecyclerView.Widget;
using static Android.Icu.Text.CaseMap;

namespace ElementsUI
{
    public class VerticalAdapter : RecyclerView.Adapter
    {
        readonly List<Items> items;
        public int imgID;
        public Typeface tf;
        static int numElement;
        Color ct;

        public VerticalAdapter(List<Items> items, int imgID, Typeface tf, Color ct)
        {
            this.items = items;
            this.imgID = imgID;
            this.tf = tf;
            this.ct = ct;
        }

        public override int ItemCount => items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            (holder as ItemViewHolderVertical).Bind(items[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            GradientDrawable gd = new GradientDrawable();
           //gd.SetColor(Color.ParseColor("#edeef0"));
            gd.SetCornerRadius(23f);
            var view = new LinearLayout(parent.Context);
            view.Orientation = Orientation.Horizontal;
            view.SetPadding(30, 30, 0, 30);          
            var layoutParams = new LinearLayout.LayoutParams(900, 200);
            layoutParams.SetMargins(10, 0, 20, 0);
            view.LayoutParameters = layoutParams;
            view.SetBackgroundDrawable(gd);
            var imageView = new ImageView(parent.Context);
            imageView.LayoutParameters = new LinearLayout.LayoutParams(100, 100);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imgID);
            var textLayout = new LinearLayout(parent.Context);
            textLayout.Orientation = Orientation.Vertical;
            textLayout.LayoutParameters = new LinearLayout.LayoutParams(0, ViewGroup.LayoutParams.MatchParent, 1);
            textLayout.SetPadding(30, 0, 0, 0);
            var titleTextView = new TextView(parent.Context);
            titleTextView.TextSize = 20;
            titleTextView.SetTypeface(tf, TypefaceStyle.Normal);
            titleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            titleTextView.SetTextColor(ct); 
            var subtitleTextView = new TextView(parent.Context);
            subtitleTextView.TextSize = 14f;
            subtitleTextView.Gravity = GravityFlags.Start | GravityFlags.CenterVertical;
            subtitleTextView.SetTypeface(tf, TypefaceStyle.Normal);
            subtitleTextView.SetTextColor(Color.ParseColor("#9299A2"));
            textLayout.AddView(titleTextView);
            textLayout.AddView(subtitleTextView);
            view.AddView(imageView);
            view.AddView(textLayout);
            return new ItemViewHolderVertical(view, imageView, titleTextView, subtitleTextView);
        }
    }
}
