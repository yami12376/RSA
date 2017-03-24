using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Wpf_RSA_Application
{
    class RandomPrimeNumberGenerator
    {
        private Random random;
        private long primeNumber;
        public RandomPrimeNumberGenerator()
        {
            primeNumber = generatePrimeNumber();
        }

        public long generatePrimeNumber()
        {
            SieveofEratosthenes s = new SieveofEratosthenes();
            List<long> primeNumbersList = s.RunAlgorithm();
            int primeNumbersCount = primeNumbersList.Count();
            random = new Random();
            return primeNumbersList.ElementAt(random.Next(primeNumbersCount-1000, primeNumbersCount+1)); // Inclusive with primeNumbersCount
        }






    }
}
