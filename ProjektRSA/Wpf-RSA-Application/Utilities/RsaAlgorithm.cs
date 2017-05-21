using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_RSA_Application.Utilities
{
    internal class RsaAlgorithm
    {
        //trzeba ustalic, co to robi i zmienic nazwe
        private RandomPrimeNumberGenerator _randomPrimeNumberGenerator;

        public void Run()
        {
            _randomPrimeNumberGenerator = new RandomPrimeNumberGenerator();
            var primeNumbers =  _randomPrimeNumberGenerator.GenerateTwoPrimeNumbers();
            var n = MultiplicationProduct(primeNumbers);
            var eulerN = CountEuler(primeNumbers);

                //TODO 
                //https://pl.wikipedia.org/wiki/RSA_(kryptografia)
                //Wybieramy liczbę e(1 < e < φ(n)) względnie pierwszą z φ(n)
                //Znajdujemy liczbę d, gdzie jej różnica z odwrotnością liczby e jest podzielna przez φ(n) :
                //d ≡ e−1(mod φ(n))
                //Ta liczba może być też prościej określona wzorem:
                //d⋅e ≡ 1(mod φ(n))
                //Klucz publiczny jest definiowany jako para liczb(n, e), natomiast kluczem prywatnym jest para(n, d).
                // Szyfrowanie i deszyfrowanie
        }

        private static long MultiplicationProduct(IEnumerable<long> primeNumbers)
        {
            return primeNumbers.Aggregate<long, long>(1, (current, primeNumber) => current * primeNumber);
        }
        
        private static long CountEuler(IEnumerable<long> primeNumbers)
        {
            return primeNumbers.Aggregate<long, long>(1, (current, primeNumber) => current * (primeNumber - 1));
        }
    }
}
