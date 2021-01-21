using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string>students=new MyDictionary<int,string>();
            students.Add(1,"Ali");
            students.Add(2, "Fethi");
            students.Add(3, "Ayşe");
            Console.WriteLine(students.Length);
            Console.WriteLine(students.array1[0]);
            Console.WriteLine(students.array2[0]);
            Console.ReadKey();
        }
    }
}
