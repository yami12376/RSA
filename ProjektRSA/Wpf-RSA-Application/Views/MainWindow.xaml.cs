using System.Windows;

namespace Wpf_RSA_Application.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var lol = new ViewModels.RsaViewModel();
            lol.RunAlgorithm();
        }

        private void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            var lol = new ViewModels.RsaViewModel();
            lol.GetRsaValues();
        }
    }
}
