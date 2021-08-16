using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public static class Fibonacci
    {
        public static IEnumerable<long> Get(int n)
        {
            int lastN1 = 0;
            int lastN2 = 1;

            yield return 0;

            for (int i = 1; i <= n; i++)
            {
                int currentN = lastN1 + lastN2;
                yield return currentN;

                lastN2 = lastN1;
                lastN1 = currentN;
            }
        }

        public static long[] GetClassic(int n)
        {
            if (n < 0)
            {
                return new long[0];
            }

            if (n == 0)
            {
                return new long[] { 0 };
            }

            if (n == 1)
            {
                return new long[] { 0, 1 };
            }

            // For n >= 2
            long[] result = new long[n + 1];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result;
        }
    }
}
