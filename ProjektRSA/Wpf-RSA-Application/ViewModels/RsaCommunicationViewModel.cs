using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_RSA_Application.Models;

namespace Wpf_RSA_Application.ViewModels
{
    internal class RsaCommunicationViewModel : BaseViewModel
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
