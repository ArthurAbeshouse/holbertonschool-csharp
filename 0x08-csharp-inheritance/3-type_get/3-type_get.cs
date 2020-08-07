using System;
using System.Reflection;

/// <summary>
/// Print method
/// </summary>
public class Obj
{
    /// <summary>
    /// prints the names of the available 
    /// properties and methods of an object.
    /// </summary>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();
        PropertyInfo[] property_list = type.GetProperties();
        MethodInfo[] Method_list = type.GetMethods();

        Console.WriteLine(type.Name + " Properties:");

        foreach (var item in property_list)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine(type.Name + " Methods:");

        foreach (var item in Method_list)
        {
            Console.WriteLine(item.Name);
        }
    }
}
