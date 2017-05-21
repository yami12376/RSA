using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Wpf_RSA_Application.Utilities
{
    internal class RandomPrimeNumberGenerator
    {
        private Random _random;
        private List<long> _primeNumbers;

        public RandomPrimeNumberGenerator()
        {
        }

        public RandomPrimeNumberGenerator(List<long> primeNumbers)
        {
            //?
        }

        public List<long> GenerateTwoPrimeNumbers()
        {
            var s = new SieveOfEratosthenes();
            var primeNumbersList = s.Run();
            var primeNumbersCount = primeNumbersList.Count();

            _random = new Random(); 
            _primeNumbers.Add(primeNumbersList.ElementAt(_random.Next(primeNumbersCount - 1000, primeNumbersCount + 1))); // Inclusive with primeNumbersCount
            _primeNumbers.Add(primeNumbersList.ElementAt(_random.Next(primeNumbersCount - 1000, primeNumbersCount + 1)));

            return _primeNumbers; 
        }
    }
}
