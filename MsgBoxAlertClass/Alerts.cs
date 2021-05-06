using System.Windows;

namespace MsgBoxAlertClass
{
    public static class Alerts
    {
        /// <summary>
        /// MsgBox 
        /// Button OK 
        /// Image Error
        /// </summary>
        /// <param name="msg">Error text</param>
        public static void MsgError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// MsgBox
        /// Button OK 
        /// Image Warning
        /// </summary>
        /// <param name="msg">Warning text</param>
        public static void MsgWarning(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
