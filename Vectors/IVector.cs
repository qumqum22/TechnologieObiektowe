

namespace Vectors
{
    interface IVector
    {
        double Abs();
        double[] GetComponents();
        double[] GetPolarCoords();
        double Cdot(IVector vect);
    }
}


