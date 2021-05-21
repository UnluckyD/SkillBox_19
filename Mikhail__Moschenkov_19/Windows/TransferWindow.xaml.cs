using System.Linq;
using System.Windows;
using BankSystemApp.DataAccess;

namespace BankSystemApp
{
    /// <summary>
    /// Логика взаимодействия для TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        public TransferWindow()
        {
            InitializeComponent();
        }

        public TransferWindow(ClientsDB _client, Classes.Model model) : this()
        {
            VM.model = model;
            dataGrid_client.ItemsSource = model.Clients.Where(c => c != _client);
            VM.TransferClient = _client;
        }
    }
}
