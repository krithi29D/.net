using System;
using System.Collections.Generic;

public class Exercise19 {
  static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2,2));
            Console.WriteLine(SumTriple(12,10));
            Console.WriteLine(SumTriple(-5,2));          
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b)*3 : a + b;
        }
}



using System;
namespace exercises
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(103));
            Console.WriteLine(test(90));
            Console.WriteLine(test(89));
            Console.ReadLine();
        }
      public static bool test(int x)
        {
              if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
        }
  }
}


using System;
namespace exercises
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(103));
            Console.WriteLine(test(90));
            Console.WriteLine(test(89));
            Console.ReadLine();
        }
      public static bool test(int x)
        {
              if(Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
        }
  }
}







