using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryDemo
{
    class MyDictionary<T1, T2>
    {
        public T1[] array1;
        public T2[] array2;
        public MyDictionary()
        {
            array1 = new T1[0];
            array2 = new T2[0];
        }
        public void Add(T1 item1, T2 item2) 
        {
            T1[] tempArray1 = array1;
            T2[] tempArray2 = array2;
            array1 = new T1[array1.Length + 1];
            array2 = new T2[array2.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                array1[i] = tempArray1[i];
                array2[i] = tempArray2[i]; 
            }
            array1[array1.Length - 1] = item1;
            array2[array2.Length - 1] = item2;
        }
        public int Length
        {
            get { return array1.Length; }
        }

    }
}
