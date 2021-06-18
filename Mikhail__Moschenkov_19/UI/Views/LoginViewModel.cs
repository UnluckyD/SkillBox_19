using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BankSystemApp.UI.Views
{
    class LoginViewModel : BindableBase
    {
        public DarkModLogic.DarkMod darkMod { get; set; } = Views.DM;
        static Authorization.LogIn logIn = new Authorization.LogIn();
        static Authorization.SingUp singIn = new Authorization.SingUp();

        IView currentViewModel = logIn;
        public IView CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; RaisePropertyChanged("CurrentViewModel"); } }

        public ICommand LogIn_btn_click
        {
            get
            {
                return new CommandHandler(() => {
                    CurrentViewModel = logIn;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
        public ICommand SingUp_btn_click
        {
            get
            {
                return new CommandHandler(() => {
                    CurrentViewModel = singIn;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
    