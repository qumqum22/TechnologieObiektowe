using System;


namespace Vectors
{
    class Vector2D : IVector
    {
        protected double X { get; set; }
        protected double Y { get; set; }

        public virtual double Abs()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public virtual double[] GetComponents()
        {
            return new double[] { X, Y };
        }

        public double Cdot(IVector vect)
        {
            double result;

            double[] vect1 = GetComponents();
            double[] vect2 = vect.GetComponents();

            if (vect1.Length == vect2.Length)
            {
                result = 0;
                int i = 0;
                foreach (double _ in vect1)
                {
                    result += vect1[i] * vect2[i];
                    i++;
                }

                return result;
            }
            Console.Write("Different dimensions of vectors! I can't calculate the scalar product.");
            return 0;
        }

        /// <summary>
        /// Returns an array with radius at first position, and angle in second position.
        /// </summary>
        /// <returns></returns>
        public virtual double[] GetPolarCoords()
        {
            double[] result = new double[2];
            double radius = Abs();
            double angle = Math.Atan(Y / X);
            result[0] = radius;
            result[1] = angle * 180 / Math.PI;      
            return result;
        }

        public Vector2D()
        {
            X = 0;
            Y = 0;
        }
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
