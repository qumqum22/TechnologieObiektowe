using System;


namespace Vectors
{
    class VectorPolar3D :IVector
    {
        public Vector3D vector;

        public VectorPolar3D(double radius, double angleXY, double angleYZ)
        {
            double x = radius * Math.Cos(angleYZ) * Math.Cos(angleXY);
            double y = radius * Math.Cos(angleYZ) * Math.Sin(angleXY);
            double z = radius * Math.Sin(angleYZ);
            vector = new Vector3D(x, y, z);
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
