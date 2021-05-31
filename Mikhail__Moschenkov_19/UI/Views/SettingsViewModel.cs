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
    class SettingsViewModel : BindableBase
    {
        public UI.DarkModLogic.DarkMod dMod { get; set; } = Classes.StaticModel.DM;

        public ICommand ChangeMod_btn_click
        {
            get
            {
                return new CommandHandler(() => dMod.ChangeMod(), () => Classes.StaticModel.model.CanExecute);
            }
        }

        
    }
}
