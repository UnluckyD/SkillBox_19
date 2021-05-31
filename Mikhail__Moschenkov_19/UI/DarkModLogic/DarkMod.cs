using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BankSystemApp.UI.DarkModLogic
{
    public class DarkMod : BindableBase
    {
        static Brush brushLight = new SolidColorBrush(Color.FromArgb(255, 157, 218, 252));
        static Brush brushDark = new SolidColorBrush(Color.FromArgb(255, 16, 44, 84));
        bool darkMod = false;
        public Brush brushBackgraund { get { return brushLight; } set { brushLight = value; RaisePropertyChanged("brushBackgraund"); } }
        public Brush brushForeground { get { return brushDark; } set { brushDark = value; RaisePropertyChanged("brushForeground"); } }

        public Brush GetBrush(bool darkMod)
        {
            if (darkMod)
                return new SolidColorBrush(Color.FromArgb(255, 16, 44, 84));
            else
                return new SolidColorBrush(Color.FromArgb(255, 157, 218, 252));
        }

        public void ChangeMod()
        {
            darkMod = !darkMod;
            brushBackgraund = GetBrush(darkMod);
            brushForeground = GetBrush(!darkMod);
        }
    }
}
