using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorManagerLibrary.Models
{
    public class Vector
    {
        public Dot endPoint { get; set; }
        public Vector(Dot endPoint)
        {
            this.endPoint = endPoint;
        }
        public Vector VectorAdd(Vector newVector)
        {
            //this.endPoint.px
            int x = this.endPoint.px + newVector.endPoint.px;
            int y = this.endPoint.py + newVector.endPoint.py;
            return new Vector(new Dot(x, y));
        }

        public int VectorDotProduct(Vector newVector)
        {
            return this.endPoint.px * newVector.endPoint.px + this.endPoint.py * newVector.endPoint.py;
        }

        public double VectorLength()
        {
            return Math.Sqrt(Math.Pow(this.endPoint.px, 2) + Math.Pow(this.endPoint.py, 2));
        }
    }
}
