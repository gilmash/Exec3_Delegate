using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 1, 4, 6, 78, 43, 67, 244, 86, 33, 71 };

            List<int> EvenItems = GetEvenItems(items, n1 => n1 % 2 == 0);

            foreach (int item in EvenItems)
            {
                Console.WriteLine(item);
            }


        }

        static List<int> GetEvenItems(List<int> source , Func<int , bool> func)
        {
            var result = new List<int>();

            foreach(int item in source)
            {
                if(func(item)==true)
                {
                    result.Add(item);
                }
            }
            return result;
        }
       
    }
}
