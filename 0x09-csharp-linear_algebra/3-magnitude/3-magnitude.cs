using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// method that calculates and returns the length of a given vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>The magnitude, else -1 if not a 2D or 3D vector</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2);
        else if (vector.Length == 3)
            return Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2);
        return -1;
    }
}
