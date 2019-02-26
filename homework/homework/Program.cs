using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        public static int[] convertVector(string a)
        {
            string[] res = a.Split(',');
            int[] aux = new int[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                aux[i] = Int32.Parse(res[i]);
            }
            return aux;
        }
        public static int[] sumVectors(int[]arr, int[] arr2)
        {
            int[] aux = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                aux[i] = arr[i] + arr2[i];
            }
            return aux;
        }
        static void Main(string[] args)
        {
            
            string a = args[0];
            string b = args[1];
            int[] arr = convertVector(a);
            int[] arr2 = convertVector(b);
            int[] result = sumVectors(arr, arr2);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]); 
            }
        }
    }
}
