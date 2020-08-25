using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates dot product of either two 2D or two 3D vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>The results, else -1 if not a 2D or 3D vector</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
            return vector1[0] * vector2[0] + vector1[1] * vector2[1];
        else if (vector1.Length == 3 && vector2.Length == 3)
            return vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
        return -1;
    }
}
