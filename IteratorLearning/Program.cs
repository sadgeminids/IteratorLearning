using System;
using System.Collections;

public class CollectionClient
{
    static void Main(string[] args)
    {

        Collectionable collectAble = new Collectionable();
        foreach (int ele in collectAble)
            Console.WriteLine(ele);


        Collectiontor collector = new Collectiontor();
        foreach (int ele in collector)
            Console.WriteLine(ele);


        Console.ReadKey();
    }
}
