using System;
using System.Collections;
using System.Collections.Generic;

namespace hashes
{
    // TODO: Создайте класс ReadonlyBytes
    public class ReadonlyBytes : IEnumerable<byte>
    {
        public int Length => _list.Length;
        private readonly byte[] _list;
        private int _hash;

        public ReadonlyBytes(params byte[] array)
        {
            _list = array ?? throw new ArgumentNullException();

        }

        private void HashCodeInside()
        {
            const int fnvPrime = 3123423;
            foreach (var item in _list)
            {
                unchecked
                { 
                }
            }
        }

        public IEnumerator<byte> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}