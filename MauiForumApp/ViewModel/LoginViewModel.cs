using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiForumApp.ViewModel
{
    public partial class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(() =>
                {
                     LoginHandler();
                }
            );

        }

        private void LoginHandler()
        {
            Shell.Current.GoToAsync("..", true);
        }
    }
}
