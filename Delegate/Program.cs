using System;
namespace Delegate
{   /// <summary>
/// This class is to demonstrate delegate concept
/// </summary>
    class Delegatedemo
    {
       
        public delegate void delegate1(int a, int b);
        /// <summary>
        /// this method is to add two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public  void add(int a, int b)
            {
                Console.WriteLine( a + b);
            }
        /// <summary>
        /// this method is to subtract two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
            public void sub(int a, int b)
            {
                Console.WriteLine( a - b);
            }/// <summary>
            /// this deals with creation of objects and displaying.
            /// </summary>
            /// <param name="args"></param>
       public static void Main(string[] args)
        {
            Delegatedemo obj = new Delegatedemo();
            delegate1 del = new delegate1(obj.add);
            delegate1 del1 = new delegate1(obj.sub);
            del(1, 2);
            del1(2, 1);
        }

    }
}
