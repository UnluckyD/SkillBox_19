using BankSystemApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankSystemApp
{
    /// <summary>
    /// Логика взаимодействия для ClientEditorWindow.xaml
    /// </summary>
    public partial class ClientEditorWindow : Window
    {
        public ClientEditorWindow()
        {
            InitializeComponent();
        }

        public ClientEditorWindow(ClientsDB row) : this()
        {
            VM.Client = row;
            VM.Copy(row);
        }
    }
}
