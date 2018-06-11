using GettingStart.CustomControls;
using Prism.Commands;
using Prism.Mvvm;
using Xamarin.Forms;

namespace GettingStart.ViewModels
{
    public class FirstPageViewModel : BindableBase
    {
        private string _testText = "Test text";
        public string TestText
        {
            get { return _testText; }
            set { SetProperty(ref _testText, value); }
        }

        CustomListView customListView;

        public DelegateCommand TestCommand { get; set; }

        public FirstPageViewModel()
        {
            TestCommand = new DelegateCommand(Test);


            customListView = new CustomListView
            {
                Items = MockListData.GetList(),
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }

        private void Test()
        {
        }
    }
}
