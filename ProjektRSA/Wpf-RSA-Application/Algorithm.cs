using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_RSA_Application
{
    class Algorithm
    {
        private RandomPrimeNumberGenerator randomPrimeNumberGenerator;
        public void runAlghoritm()
        {
            randomPrimeNumberGenerator = new RandomPrimeNumberGenerator();
            List<long> primeNumbers =  randomPrimeNumberGenerator.generateTwoPrimeNumbers();
            long n = multiplicationProduct(primeNumbers);
            long eulerN = countEuler(primeNumbers);

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

        private long multiplicationProduct(List<long> primeNumbers)
        {
            long result = 1;

            foreach (var primeNumber in primeNumbers)
            {
                result *= primeNumber;
            }
            return result;
        }


        private long countEuler(List<long> primeNumbers)
        {
            long result = 1;

            foreach (var primeNumber in primeNumbers)
            {
                result *= (primeNumber-1);
            }
            return result;
        }
        

    }
}
