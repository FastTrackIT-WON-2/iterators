using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterators
{
    public class ThreeElementsCollection<T> : IEnumerable<T>
    {
        public ThreeElementsCollection(T element1, T element2, T element3)
        {
            Element1 = element1;
            Element2 = element2;
            Element3 = element3;
        }

        public T Element1 { get; }

        public T Element2 { get; }

        public T Element3 { get; }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumeratorInternal();
        }

        private IEnumerator<T> GetEnumeratorInternal()
        {
            Console.WriteLine("Begin");
            yield return default;

            Console.WriteLine("Iteration 2");
            yield return Element1;

            Console.WriteLine("Iteration 3");
            yield return Element2;

            Console.WriteLine("Iteration 4");
            yield return Element3;

            Console.WriteLine("End");
        }
    }
}
