using System.Windows;
using System.Linq;
using BankSystem.DataAccess;

namespace BankSystem
{
    /// <summary>
    /// Логика взаимодействия для CreditWindow.xaml
    /// </summary>
    public partial class CreditWindow : Window
    {

        public CreditWindow()
        {
            InitializeComponent();
        }
        public CreditWindow(ClientsDB _client, Model model) : this()
        {
            VMCC.model = model;
            VMCC.Client = _client;
            VMCC.Credit = VMCC.model.Credits.FirstOrDefault(c => c.Id == VMCC.Client.creditID);
            if (VMCC.Credit == null)
                VMCC.Credit = new Credit();
        }
    }
}
