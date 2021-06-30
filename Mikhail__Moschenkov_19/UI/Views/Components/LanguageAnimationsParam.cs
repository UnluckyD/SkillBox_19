using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankSystemApp.UI.Views.Components
{
    public class LanguageAnimationsParam : BindableBase
    {
        static double max = 118;
        static double min = 30;
        static double inc = 0.005;
        static double h = min;

        public double Height { get { return h; } set { h = value; RaisePropertyChanged("Height"); } }

        public void StartAnimation()
        {
            if (Height <= min + 1)
            {
                Thread thread = new Thread(() => {
                    for (double i = min; i < max; i += inc)
                        App.Current.Dispatcher.Invoke(() => { Height = i; });
                })
                {
                    IsBackground = true
                };
                thread.Start();
            }
            else
            {
                Thread thread = new Thread(() => {
                    for (double i = max; i > min; i -= inc)
                        App.Current.Dispatcher.Invoke(() => { Height = i; });
                })
                {
                    IsBackground = true
                };
                thread.Start();
            }
        }
    }
}
