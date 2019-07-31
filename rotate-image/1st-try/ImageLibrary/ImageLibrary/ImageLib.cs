using System;

namespace ImageLibrary
{
    public class ImageLib
    {
        public ImageLib()
        {
        }

        public int[,] Rotate(int[,] matrix)
        {
            int oldValue = matrix[0, 0];
            matrix[0, 0] = matrix[1, 0];
            matrix[1, 0] = matrix[1, 1];
            matrix[1, 1] = matrix[0, 1];
            matrix[0, 1] = oldValue; 
            return matrix;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}