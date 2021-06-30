using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.Classes
{
    public static class StaticModel
    {
        public static UI.Localization.CurrentLanguage currentLanguage = new UI.Localization.CurrentLanguage();
        public static Model model = new Model();
        public static UI.Views.Components.LanguageAnimationsParam languageAnimations = new UI.Views.Components.LanguageAnimationsParam();
        public static Connection Connection = new Connection();
    }
}
