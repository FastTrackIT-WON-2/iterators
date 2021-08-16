using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterators
{
    public class NumbersGenerator : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        private IEnumerator<int> GetEnumeratorInternal()
        {
            int nr = 0;
            while (true)
            {
                yield return nr;
                nr++;
            }
        }
    }
}
