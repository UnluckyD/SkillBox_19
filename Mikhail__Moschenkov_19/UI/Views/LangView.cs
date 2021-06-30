using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    class LangView
    {
        public DarkModLogic.DarkMod dMod { get; set; } = Views.DM;
        public Components.LanguageAnimationsParam languageAnimations { get; set; } = Classes.StaticModel.languageAnimations;
        Localization.CurrentLanguage currentLanguage = Classes.StaticModel.currentLanguage;
        public ICommand Ru_ru
        {
            get
            {
                return new CommandHandler(() =>
                {
                    languageAnimations.StartAnimation();
                    //Russian UI
                    currentLanguage.SetLanguage(Localization.Languages.ru_Ru);
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
        public ICommand En_en
        {
            get
            {
                return new CommandHandler(() =>
                {
                    languageAnimations.StartAnimation();
                    //English UI
                    currentLanguage.SetLanguage(Localization.Languages.en_En);
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
