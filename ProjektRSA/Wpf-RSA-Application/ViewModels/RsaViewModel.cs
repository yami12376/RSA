using System.Windows.Input;
using Wpf_RSA_Application.Models;
using Wpf_RSA_Application.Utilities;

namespace Wpf_RSA_Application.ViewModels
{
    internal class RsaViewModel : BaseViewModel
    {
        private ushort _n;
        private ushort _e;
        private int _d;
        private byte _plainByte;
        private int _encryptedByte;
        private int _decryptedByte;

        public ushort N
        {
            get => _n;
            set
            {
                _n = value;
                OnPropertyChanged();
            }
        }

        public ushort E
        {
            get => _e;
            set
            {
                _e = value;
                OnPropertyChanged();
            }
        }

        public int D
        {
            get => _d;
            set
            {
                _d = value;
                OnPropertyChanged();
            }
        }

        public byte PlainByte
        {
            get => _plainByte;
            set
            {
                _plainByte = value;
                OnPropertyChanged();
            }
        }

        public int EncryptedByte
        {
            get => _encryptedByte;
            set
            {
                _encryptedByte = value;
                OnPropertyChanged();
            }
        }

        public int DecryptedByte
        {
            get => _decryptedByte;
            set
            {
                _decryptedByte = value;
                OnPropertyChanged();
            }
        }

        public string PublicKey => $"Pair: n = {N}, e = {E}";

        public string PrivateKey => $"Pair: d = {D}, n = {N}";

        public void GetRsaValues()
        {
            var values = RsaProvider.Run();
            N = values.Item1;
            E = values.Item2;
            D = values.Item3;
        }

        public void RunAlgorithm()
        {
            var result = new RsaProvider();
            EncryptedByte = result.EncryptValue(PlainByte, E, N);
            DecryptedByte = result.DecryptValue(EncryptedByte, D, N);
        }
    }
}
