using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorManagerLibrary.Models;

namespace VectorManager
{
    class ImputReader
    {
        public Dot endPoint1 { get; set; }
        public Dot endPoint2 { get; set; }
        public ImputReader(string[] values)
        {
            string[] stringEndPoint1 = values[0].Split(',');
            string[] stringEndPoint2 = values[1].Split(',');
            int x = ValidateDotValue(stringEndPoint1[0]);
            int y = ValidateDotValue(stringEndPoint1[1]);
            this.endPoint1 = new Dot(x, y);
            x = ValidateDotValue(stringEndPoint2[0]);
            y = ValidateDotValue(stringEndPoint2[1]);
            this.endPoint2 = new Dot(x, y);
            //this.endPoint1.px = ValidateDotValue(stringEndPoint1[0]);
            //this.endPoint1.py = ValidateDotValue(stringEndPoint1[1]);
            //this.endPoint2.px = ValidateDotValue(stringEndPoint2[0]);
            //this.endPoint2.py = ValidateDotValue(stringEndPoint2[1]);
        }

        private int ValidateDotValue(string value)
        {
            if (int.TryParse(value, out var num))
            {
                return num;
            }
            else
            {
                throw new ArgumentException("Value is not a number");
            }
        }
    }
}
