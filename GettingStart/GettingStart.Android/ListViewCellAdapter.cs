using Android.App;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using GettingStart.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.Android;

namespace GettingStart.Droid
{
    public class ListViewCellAdapter : BaseAdapter<MockListData>
    {

        Activity context;
        IList<MockListData> tableItems = new List<MockListData>();

        public IEnumerable<MockListData> Items
        {
            set
            {
                tableItems = value.ToList();
            }
        }

        public ListViewCellAdapter(Activity context, CustomListView view)
        {
            this.context = context;
            tableItems = view.Items.ToList();
        }

        public override MockListData this[int position]
        {
            get
            {
                return tableItems[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = tableItems[position];
            var testSkill = new Random();

            var view = convertView;
            if (view == null)
            {
                // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.ListViewCell, null);
            }

            // Bind data to view
            view.FindViewById<TextView>(Resource.Id.Text1).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Category;
            view.FindViewById<ProgressBar>(Resource.Id.SkillBar).Progress = testSkill.Next(100); 

            // grab the old image and dispose of it
            if (view.FindViewById<ImageView>(Resource.Id.Image).Drawable != null)
            {
                using (var image = view.FindViewById<ImageView>(Resource.Id.Image).Drawable as BitmapDrawable)
                {
                    if (image != null)
                    {
                        if (image.Bitmap != null)
                        {
                            //image.Bitmap.Recycle ();
                            image.Bitmap.Dispose();
                        }
                    }
                }
            }

            // If a new image is required, display it
            if (!String.IsNullOrWhiteSpace(item.ImageName))
            {
                context.Resources.GetBitmapAsync(item.ImageName).ContinueWith((t) => {
                    var bitmap = t.Result;
                    if (bitmap != null)
                    {
                        view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(bitmap);
                        bitmap.Dispose();
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                // clear the image
                view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(null);
            }

            return view;
        }

        public override int Count
        {
            get { return tableItems.Count; }
        }
    }
}