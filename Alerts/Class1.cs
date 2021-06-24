using System.Windows;

namespace Alerts
{
    static class Alerts
    {
        public static void MsgError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void MsgWarning(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
