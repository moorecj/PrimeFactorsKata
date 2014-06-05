using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsKata
{
    public class PrimeFactors
    {
        
        public List<Int32> Generate( int number )
        {
            var primes = new List<Int32>();
            
            if(number < 2)
                return new List<Int32>();
        
            var potentialPrime = 2;

            while ( number != 1 )
            {

                number = ExtractPrimesFor(number, primes, potentialPrime);
                
                potentialPrime++;
            
            }

            return primes;
        }

        private static int ExtractPrimesFor(int number, List<int> primes, int potentialPrime)
        {
            while (number % potentialPrime == 0)
            {

                primes.Add(potentialPrime);

                number = number / potentialPrime;

            }

            return number;
        }

    }
}
