using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.UI.Views.Home
{
    class HomePageViewModel
    {
        public UI.DarkModLogic.DarkMod dMod { get; set; } = Views.DM;
        public Classes.Connection connection { get; set; } = Classes.StaticModel.Connection;
    }
}
