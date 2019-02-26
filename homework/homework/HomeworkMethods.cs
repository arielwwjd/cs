using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class HomeworkMethods
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
        public static int[] sumVectors(int[] arr, int[] arr2)
        {
            int[] aux = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                aux[i] = arr[i] + arr2[i];
            }
            return aux;
        }
    }
}
