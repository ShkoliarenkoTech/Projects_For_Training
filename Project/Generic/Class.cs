using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;
namespace Generic
{
    class ClassMyList<T>
    {
        private T[] _Array = Array.Empty<T>();

        public T this[int index]
            {
                get
                {
                     return _Array[index];
                }
                set
                {
                _Array[index] = value;
                }

            } 

        public int Count { get { return _Array.Length; } }

        public void Add(T value)

        {
            var newArray = new T [_Array.Length + 1];
            for (int i = 0; i < _Array.Length; i++)
            {
                newArray[i] = _Array[i];
            }
            newArray[_Array.Length] = value;
            _Array = newArray;
        }
        
    }
}
