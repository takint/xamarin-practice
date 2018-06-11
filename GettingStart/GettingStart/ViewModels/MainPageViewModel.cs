using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStart.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand NavidateToTestPageCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
            NavidateToTestPageCommand = new DelegateCommand(NavidateToTestPage);
        }


        private void NavidateToTestPage()
        {
            _navigationService.NavigateAsync("FirstPage");
        }
    }
}
