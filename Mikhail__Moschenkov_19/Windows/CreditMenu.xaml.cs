using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Linq;
using MsgBoxAlertClass;

namespace Mikhail__Moschenkov_19
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
