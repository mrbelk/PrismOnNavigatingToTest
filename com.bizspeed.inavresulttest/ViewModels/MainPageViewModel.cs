using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace com.bizspeed.inavresulttest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogService;

        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
        {
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            GoToSecondCommand = new DelegateCommand(async () =>
            {
                var res = await this.navigationService.NavigateAsync("SecondPage");

                if (!res.Success)
                {
                    await dialogService.DisplayAlertAsync("Error", $"Error opening second page: {res.Exception.Message}", "OK", "Cancel");
                }
            });
        }

        public ICommand GoToSecondCommand
        {
            get;
            private set;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public override async void OnNavigatingTo(INavigationParameters parameters)
        {
            await Task.CompletedTask;
            Title = "Main Page";
        }
    }
}
