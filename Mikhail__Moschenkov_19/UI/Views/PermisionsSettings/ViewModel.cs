using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views.PermisionsSettings
{
    class ViewModel
    {
        public Classes.Model model { get; set; } = Classes.StaticModel.model;

        public ICommand Save_btn_click
        {
            get
            {
                return new CommandHandler(() =>
                {
                    Classes.StaticModel.model.RepositiryAuthSave();
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
