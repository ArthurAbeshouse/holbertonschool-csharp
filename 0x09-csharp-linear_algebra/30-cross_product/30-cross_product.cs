using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>If either vector is not a 3D vector, it returns a vector containing -1</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] results = new double[vector1.Length];
            results[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
            results[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
            results[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
            return results;
        }
        return new double[] { -1 };
    }
}
