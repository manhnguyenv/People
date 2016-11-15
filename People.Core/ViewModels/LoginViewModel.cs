using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using People.Core.Services;

namespace People.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    LoginCommand.RaiseCanExecuteChanged();
                }

            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    LoginCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public MvxCommand RegisterCommand { get; }


        private IPeopleService _peopleService;



        public MvxCommand LoginCommand { get; }

        public LoginViewModel(IPeopleService peopleService)
        {
            _peopleService = peopleService;

            RegisterCommand = new MvxCommand(RegisterExecute);
            LoginCommand = new MvxCommand(LoginExecute, CanLoginExecute);
        }

        private bool CanLoginExecute()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private async void LoginExecute()
        {
            var result = await _peopleService.LoginAsync(Username, Password);
            if (result)
            {
                ShowViewModel<PeopleListViewModel>();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void RegisterExecute()
        {
            this.ShowViewModel<RegisterViewModel>();
        }
    }
}
