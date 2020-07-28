using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> list = new HashSet<int>(list1);
        list.IntersectWith(list2);
        List<int> new_list = new List<int>();
        foreach(int i in list)
            new_list.Add(i);

        new_list.Sort();

        return new_list;
    }
}
