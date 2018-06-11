using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStart.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            customListView.Items = MockListData.GetList();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Task.Delay(1000);
        }
    }
}
