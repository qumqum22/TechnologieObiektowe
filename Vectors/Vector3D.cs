using System;

namespace Vectors
{
    class Vector3D : Vector2D
    {
        private double Z { get; set; }

        public override double Abs()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public override double[] GetComponents()
        {
            return new double[] {X,Y,Z};
        }

        /// <summary>
        /// Returns an array with radius at first position, XY angle at second, and YZ angle at last position.
        /// </summary>
        /// <returns></returns>
        public override double[] GetPolarCoords()
        {
            double[] result = new double[3];
            
            double angleXY = Math.Atan(Y / X);
            double angleYZ = Math.Atan(Z / Y);
            result[0] = Abs();
            result[1] = angleXY * 180 / Math.PI;     
            result[2] = angleYZ * 180 / Math.PI;
            return result;
        }


        
        public Vector3D() :base()
        {
            Z = 0;
        }

        public Vector3D(double x, double y, double z) :base(x,y)
        {

            Z = z;
        }


    }
}
