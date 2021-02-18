using System.Windows;

namespace MattermostAddinConnect.Security
{
    /// <summary>
    ///     Interaction logic for PasswordDialog.xaml
    /// </summary>
    public partial class PasswordDialog
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }

        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}