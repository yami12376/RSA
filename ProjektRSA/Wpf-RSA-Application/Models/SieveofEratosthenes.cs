using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Wpf_RSA_Application.Annotations;

namespace Wpf_RSA_Application.Utilities
{
    internal class SieveOfEratosthenes
    {
        private const long N = 9 * 1234567L;
        private bool[] _tableOfNumbers;
        private List<long> _primeNumbersList;

        //to musi isc poza model
        public List<long> Run()
        {
            _primeNumbersList = new List<long>();
            _tableOfNumbers = new bool[N];                  //by default they're all false

            for (uint i = 2; i < N; i++)
            {
                _tableOfNumbers[i] = true;                  //set all numbers to true
            }
                                                            //weed out the non primes by finding mutiples 
            for (uint j = 2; j < N; j++)
            {
                if (_tableOfNumbers[j])//is true
                {
                    for (long p = 2; (p * j) < N; p++)
                    {
                        _tableOfNumbers[p * j] = false;
                    }
                }
            }

            for (long i = 0; i < _tableOfNumbers.LongLength; i++)
            {
                if (_tableOfNumbers[i] == true)
                {
                    _primeNumbersList.Add(i);
                }
            }

            return _primeNumbersList;
                                                            //Uptill here e[] sorta of contains a list of primes
                                                            //the index represent the actual number and the value at the index represents if the number is prime
                                                            //Example:
                                                            //e[4], e[100] will all be false since 2,4,100 are not primes
                                                            //e[5], e[7], e[11], e[13] will all be true because 5,7,11,13 are all prime numbers
        }
    }
}
