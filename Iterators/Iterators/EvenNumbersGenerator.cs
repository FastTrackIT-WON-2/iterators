using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class EvenNumbersGenerator : IEnumerable<int>
    {
        private readonly IEnumerable<int> _source;

        public EvenNumbersGenerator(IEnumerable<int> source)
        {
            _source = source ?? Enumerable.Empty<int>();
        }

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
            foreach (int nr in _source)
            {
                if (nr % 2 == 0)
                {
                    yield return nr;
                }
            }
        }
    }
}
