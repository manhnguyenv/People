using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace People.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        public MvxCommand RegisterCommand { get; }

        public LoginViewModel()
        {
            RegisterCommand = new MvxCommand(RegisterExecute);
        }

        private void RegisterExecute()
        {
            this.ShowViewModel<RegisterViewModel>();
        }
    }
}
