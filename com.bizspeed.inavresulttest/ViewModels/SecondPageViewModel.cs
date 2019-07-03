using System;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace com.bizspeed.inavresulttest.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        private readonly INavigationService navigationService;

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public async override void OnNavigatingTo(INavigationParameters parameters)
        {
            Title = "SecondPage Page";

            await Task.CompletedTask;

            throw new Exception("Test Exception");
        }
    }
}
