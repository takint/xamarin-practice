using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStart.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(INavigationService navigationService)
        {
            InitializeComponent();
        }
    }
}