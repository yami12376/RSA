using System.Collections.Generic;

namespace Wpf_RSA_Application.Utilities
{
    internal class SieveOfEratosthenes
    {
        private const long N = 9 * 1234567L;
        private bool[] _tableOfNumbers;
        private List<long> _primeNumbersList;

        //to musi isc poza model
        public List<long> CalculatePrimes()
        {
            _primeNumbersList = new List<long>();
            _tableOfNumbers = new bool[N];

            for (uint i = 2; i < N; i++)
            {
                _tableOfNumbers[i] = true;
            }

            for (uint j = 2; j < N; j++)
            {
                if (!_tableOfNumbers[j]) continue;
                for (long p = 2; (p * j) < N; p++)
                {
                    _tableOfNumbers[p * j] = false;
                }
            }

            for (long i = 0; i < _tableOfNumbers.LongLength; i++)
            {
                if (_tableOfNumbers[i])
                {
                    _primeNumbersList.Add(i);
                }
            }

            return _primeNumbersList;
        }
    }
}
