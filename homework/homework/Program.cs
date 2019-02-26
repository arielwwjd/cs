using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a = args[0];
            string b = args[1];
            int[] arr = HomeworkMethods.convertVector(a);
            int[] arr2 = HomeworkMethods.convertVector(b);
            int[] result = HomeworkMethods.sumVectors(arr, arr2);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]); 
            }
        }
    }
}
