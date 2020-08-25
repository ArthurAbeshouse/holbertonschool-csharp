using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector and a scalar
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>The result, else -1 if not a 2D or 3D vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] Vector2 = { 0, 0 };
            Vector2[0] = vector[0] * scalar;
            Vector2[1] = vector[1] * scalar;
            return Vector2;
        }
        else if (vector.Length == 3)
        {
            double[] Vector3 = { 0, 0, 0 };
            Vector3[0] = vector[0] * scalar;
            Vector3[1] = vector[1] * scalar;
            Vector3[2] = vector[2] * scalar;
            return Vector3;
        }
        return new double[] { -1 };
    }
}
