using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProblemUsingGenericsWithClass
{
    public class Generics<uType> where uType : IComparable
    {
        uType a;
        uType b;
        uType c;
        public Generics(uType a, uType b, uType c)   //constructor
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Comparison()
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine("Greatest : {0}", a);
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine("Greatest : {0}", b);
            }
            else if (c.CompareTo(b) > 0 && c.CompareTo(a) > 0 || c.CompareTo(b) > 0 && c.CompareTo(a) > 0 || c.CompareTo(b) > 0 && c.CompareTo(a) > 0)
            {
                Console.WriteLine("Greatest : {0}", c);
            }
            else
            {
                Console.WriteLine("All three numbers are equal or greatest two are equal");
            }
        }
    }
}