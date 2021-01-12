using Android.Content;
using Android.Graphics.Drawables;
using ThePresent;
using ThePresent.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchEntry), typeof(SearchEntryRenderer))]
namespace ThePresent.Droid
{
    
    public class SearchEntryRenderer : EntryRenderer
    {
        public SearchEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                
                
                var gd = new GradientDrawable();
                gd.SetCornerRadius(2);
                gd.SetColor(global::Android.Graphics.Color.White);

                var padTop = 20;
                var padBottom = 20;
                var padLeft = 20;
                var padRight = 20;

                Control.SetPadding(padLeft, padTop, padRight, padBottom);

                Control.SetBackground(gd);
            }
        }
    }
}