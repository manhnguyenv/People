using System;
using MvvmCross.Core.ViewModels;
using People.Core.Services;

namespace People.Core.ViewModels
{
public class RegisterViewModel : MvxViewModel
{
    private string _email;
    private string _password;
    private string _username;

    private readonly IPeopleService _peopleService;

    public MvxCommand RegisterCommand { get; }

    public RegisterViewModel(IPeopleService peopleService)
    {
        _peopleService = peopleService;
        RegisterCommand = new MvxCommand(RegisterExecute,RegisterCanExecute);
    }

    private bool RegisterCanExecute()
    {
        return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Email);
    }

    private async void RegisterExecute()
    {
        var result = await _peopleService.RegisterAsync(Username, Email, Password);
        if (result)
        {
            Close(this);
        }
        else
        {
            throw new NotImplementedException();
        }
    }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RegisterCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    RegisterCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    RegisterCommand.RaiseCanExecuteChanged();
                }
            }
        }
    }
}