using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorManagerLibrary.Models;

namespace VectorManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArg = new string[] { "1,2", "2,1" };
            ImputReader newImput = new ImputReader(testArg);
            Vector vector1 = new Vector(newImput.endPoint1);
            Vector vector2 = new Vector(newImput.endPoint2);
            Vector result = vector1.VectorAdd(vector2);
            Console.WriteLine($"Result: {result.endPoint.px} {result.endPoint.py}");
            int dotScalar = vector1.VectorDotProduct(vector2);
            Console.WriteLine(dotScalar);

            double module = vector1.VectorLength();
            Console.WriteLine(module);

            Console.ReadKey();

        }
    }
}
