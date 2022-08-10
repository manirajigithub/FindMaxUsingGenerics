using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GreatestUsingParams

{
    public class Calculate<uType> where uType : IComparable
    {
        uType[] a;    //variable
        public Calculate(params uType[] array)   //constructor
        {
            this.a = array;
        }
        public void sort()
        {
            Array.Sort(this.a);
        }
        public uType Comparison()
        {
            return a[a.Length - 1];
        }
        public void Show()
        {
            foreach (var uType in a)
            {
                Console.WriteLine("value:" + uType);
            }
        }
    }
}