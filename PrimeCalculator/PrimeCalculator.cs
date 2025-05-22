using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeCalculator {
    public static class PrimeCalculator {
        public static ICollection<long> CalculatePrimes(int count) {
            ConcurrentDictionary<long, byte> primes = new ConcurrentDictionary<long, byte>();

            Parallel.For(2, count, i => {
                if (IsPrime(i)) primes.TryAdd(i, 0);
            });

            return primes.Keys;
        }

        public static bool IsPrime(long n) {
            long max = n / 2;

            for (long i = 2; i <= max; i++) {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
