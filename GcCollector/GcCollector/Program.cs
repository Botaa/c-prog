using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcCollector
{
    internal class Program
    {
        public class MyClass
        {
            public static int Count { get; set; }
            public MyClass()
            {
                Count++;
            }
             ~MyClass()
            {
                Count--;
            }

            public int Ki()
            {
                return Count;
            }
        }

        static void Main(string[] args)
        {
            int max = 0;
            while(true)
            {
                MyClass myObj = new MyClass();
                List<int> Lista = new List<int>();
                Lista.Add(myObj.Ki());
                if(max < Lista.Max())
                    max=Lista.Max();

                Console.WriteLine(max);
            }
        }
    }
}
