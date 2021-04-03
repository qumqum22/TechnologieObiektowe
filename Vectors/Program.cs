using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            IVector[] vectors =
            {
                new Vector2D(5,5),
                new Vector2D(6,8),
                new VectorPolar2D(10,53),
                new Vector2D(3,18),
                new VectorPolar3D(6, 45, 45),
                new Vector3D(2,2,2),
                new Vector3D(2,4,6),
                new Vector3D(6,8,10),
                new Vector2D(6,8),
                new VectorPolar2D(6, 30),
                new VectorPolar2D(6, 30),
                new VectorPolar3D(2, 30, 90),
                new VectorPolar2D(6, 45),
                new VectorPolar3D(6, 45, 45)
                
            };
            
            ShowVectors(vectors);
            Console.WriteLine();
            ShowPolarCoords(vectors);
            Console.WriteLine();
            ShowScalars(vectors);
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void ShowVectors(IVector[] arrayOfVectors)
        {
            foreach (IVector vect in arrayOfVectors)
            {
                int length = vect.GetComponents().Length;
                double[] result = new double[length];
                result = vect.GetComponents();
                Console.Write("Vector: [ ");
                for (int i = 0; i < length; i++)
                    Console.Write(result[i] + " ");

                Console.Write("] Abs:\t");
                Console.WriteLine(vect.Abs());
            }
        }
        public static void ShowPolarCoords(IVector[] arrayOfVectors)
        {
            foreach (IVector vect in arrayOfVectors)
            {
                int length = vect.GetPolarCoords().Length;
                double[] result = new double[length];
                result = vect.GetPolarCoords();
                Console.Write("Polar coordinates: [ ");
                for (int i = 0; i < length; i++)
                    Console.Write(result[i] + " ");

                Console.WriteLine("] ");
            }
        }

        public static void ShowScalars(IVector[] arrayOfVectors)
        {
            for(int i =0; i < arrayOfVectors.Length -1; i++)
            {
                Console.WriteLine(arrayOfVectors[i].Cdot(arrayOfVectors[i+1]));
            }
        }
    }
}
