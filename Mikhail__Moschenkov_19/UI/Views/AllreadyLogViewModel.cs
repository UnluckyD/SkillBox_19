using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    class AllreadyLogViewModel
    {
        public UI.DarkModLogic.DarkMod dMod { get; set; } = Classes.StaticModel.DM;
        public Classes.Connection connection { get; set; } = Classes.StaticModel.Connection;

        public ICommand LogOut_btn_click
        {
            get
            {
                return new CommandHandler(() =>
                {
                    connection.LogOut(); 
                }, () => Classes.StaticModel.model.CanExecute); }
        }
    }
}
