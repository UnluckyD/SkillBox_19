using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BankSystemApp.UI.Views
{
    class MainViewModel : BindableBase
    {
        public Brush brushLight { get; set; } = new SolidColorBrush(Color.FromArgb(255, 157, 218, 252));
        public Brush brushDark { get; set; } = new SolidColorBrush(Color.FromArgb(255, 16, 44, 84));
        LoginViewCP loginView = new LoginViewCP();
        ClientsViewModel clientsVM = new ClientsViewModel();

        IView currentViewModel;
        public IView CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; RaisePropertyChanged("CurrentViewModel"); } }

        public ICommand GitHub_btn_click
        {
            get { return new CommandHandler(() => Process.Start("https://github.com/UnluckyD/SkillBox_19"), () => true); }
        }

        public ICommand Login_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = loginView, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Clients_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = clientsVM, () => Classes.StaticModel.model.CanExecute); }
        }
    }
}
