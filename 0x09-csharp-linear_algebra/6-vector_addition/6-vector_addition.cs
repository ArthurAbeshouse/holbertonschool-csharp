using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>The result, else -1 if not a 2D or 3D vector</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] Vector2 = { 0, 0 };
            Vector2[0] = vector1[0] + vector2[0];
            Vector2[1] = vector1[1] + vector2[1];
            return Vector2;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] Vector3 = { 0, 0, 0 };
            Vector3[0] = vector1[0] + vector2[0];
            Vector3[1] = vector1[1] + vector2[1];
            Vector3[1] = vector1[2] + vector2[2];
            return Vector3;
        }
        return new double[] { -1 };
    }
}
