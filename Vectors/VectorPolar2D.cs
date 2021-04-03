using System;


namespace Vectors
{
    class VectorPolar2D : IVector
    {
        public Vector2D vector;
        public VectorPolar2D(double radius, double angleXY)
        {
            double x = radius * Math.Cos(angleXY);
            double y = radius * Math.Sin(angleXY);
            vector = new Vector2D(x, y);
        }

        public double Abs()
        {
            return vector.Abs();
        }

        public double Cdot(IVector vect)
        {
            return vector.Cdot(vect);
        }

        public double[] GetPolarCoords()
        {
            return vector.GetPolarCoords();
        }

        public double[] GetComponents()
        {
            return vector.GetComponents();
        }
        
    }
}

