using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace com.bizspeed.inavresulttest.ViewModels
{
    public abstract class ViewModelBase : BindableBase, INavigationAware
    {
        protected ViewModelBase()
        {
        }

        protected bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        protected string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public virtual Task Close()
        {
            return Task.CompletedTask;
        }

        protected virtual Dictionary<string, string> BuildErrorContext()
        {
            return new Dictionary<string, string>();
        }
    }
}
