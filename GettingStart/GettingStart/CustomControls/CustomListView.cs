using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GettingStart.CustomControls
{
    public class CustomListView : ListView
    {
        public static readonly BindableProperty ItemsProperty = BindableProperty.Create("Items",
            typeof(IEnumerable<MockListData>),
            typeof(CustomListView),
            new List<MockListData>());

        public IEnumerable<MockListData> Items
        {
            get { return (IEnumerable<MockListData>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        new public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (item != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
