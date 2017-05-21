using System;
using System.Collections.Generic;
using System.Linq;

namespace Wpf_RSA_Application.Utilities
{
    internal class RandomPrimeNumberGenerator
    {
        private Random _random;
        private List<long> _primeNumbers;

        public List<long> GenerateTwoPrimeNumbers()
        {
            var sieve = new SieveOfEratosthenes();
            var primeNumbersList = sieve.CalculatePrimes();

            _random = new Random();
            _primeNumbers
                .Add(primeNumbersList
                .ElementAt(_random
                .Next(primeNumbersList.Count - 1000,
                primeNumbersList.Count + 1)));
            _primeNumbers
                .Add(primeNumbersList
                .ElementAt(_random
                .Next(primeNumbersList.Count - 1000,
                primeNumbersList.Count + 1)));

            return _primeNumbers;
        }
    }
}
