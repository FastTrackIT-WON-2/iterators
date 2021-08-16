using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class MyIntegersCollection : IEnumerable<int>
    {
        private readonly int[] _elements;

        public MyIntegersCollection(params int[] elements)
        {
            _elements = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }
    }
}
