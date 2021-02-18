using System.Windows;

namespace MattermostAddinConnect.Security
{
    /// <summary>
    ///     Interaction logic for InvalidCertificateDialog.xaml
    /// </summary>
    public partial class InvalidCertificateDialog
    {
        public InvalidCertificateDialog()
        {
            InitializeComponent();
        }

        private void OnAcceptClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void OnAbortClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}