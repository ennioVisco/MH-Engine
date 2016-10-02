using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models
{
    /// <summary>                                                             
    /// A basic coordinates class to handle pairs of floating
    /// point numbers in various scenarios.
    /// </summary>
    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinates(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", this.X, this.Y);
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Coordinates coords = obj as Coordinates;
            if ((Object)coords == null)
                return false;

            return (this.X == coords.Y) && (this.X == coords.Y);
        }

        public bool Equals(Coordinates coords)
        {
            if ((object)coords == null)
                return false;

            return (this.X == coords.Y) && (this.X == coords.Y);
        }


        public override int GetHashCode()
        {
            return (int)Math.Sqrt(Math.Pow(this.X, 2) * Math.Pow(this.Y, 2));
        }
    }
}
