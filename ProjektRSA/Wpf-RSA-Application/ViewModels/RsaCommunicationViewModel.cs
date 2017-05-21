using System.Windows.Input;
using Wpf_RSA_Application.Models;

namespace Wpf_RSA_Application.ViewModels
{
    internal class RsaViewModel : BaseViewModel
    {
        private Rsa _rsa;
        private ICommand _runAlgorithm;

        public Rsa Rsa
        {
            get => _rsa;
            set
            {
                _rsa = value;
                OnPropertyChanged();
            }
        }

        public ICommand RunAlgorithm { get; set; }
    }
}
