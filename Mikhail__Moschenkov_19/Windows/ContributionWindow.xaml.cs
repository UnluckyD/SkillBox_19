using System.Windows;
using System.Linq;
using BankSystem.DataAccess;

namespace BankSystem
{
    /// <summary>
    /// Логика взаимодействия для ContributionWindow.xaml
    /// </summary>
    public partial class ContributionWindow : Window
    {
        public ContributionWindow()
        {
            InitializeComponent();
        }

        public ContributionWindow(ClientsDB _client, Model model) : this()
        {
            VMCC.model = model;
            VMCC.Client = _client;
            VMCC.Contribution = model.Contributions.FirstOrDefault(c => c.Id == VMCC.Client.contributionID);
            if (VMCC.Contribution == null)
                VMCC.Contribution = new Contribution();
        }
    }
}
