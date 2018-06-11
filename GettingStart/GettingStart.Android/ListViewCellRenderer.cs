using Android.Content;
using GettingStart.CustomControls;
using GettingStart.Droid;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomListView), typeof(ListViewCellRenderer))]
namespace GettingStart.Droid
{
    public class ListViewCellRenderer : ListViewRenderer
    {
        private Context _context;

        public ListViewCellRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // unsubscribe
                Control.ItemClick -= OnItemClick;
            }

            if (e.NewElement != null)
            {
                // subscribe
                Control.Adapter = new ListViewCellAdapter(_context as Android.App.Activity, e.NewElement as CustomListView);
                Control.ItemClick += OnItemClick;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomListView.ItemsProperty.PropertyName)
            {
                Control.Adapter = new ListViewCellAdapter(_context as Android.App.Activity, Element as CustomListView);
            }
        }

        void OnItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            ((CustomListView)Element).NotifyItemSelected(((CustomListView)Element).Items.ToList()[e.Position - 1]);
        }
    }
}