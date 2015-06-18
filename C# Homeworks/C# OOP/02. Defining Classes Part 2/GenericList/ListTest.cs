namespace GenericList
{
    using System;

    class ListTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);

            list.Add(5);
            list.Add(10);
            list.Add(14);
            list.Insert(2, 124);
            list.Insert(3, 1);
            list.RemoveAt(2);

            Console.WriteLine("Using index of:\n{0}\n",list.IndexOf(124));

            list[3] = 1555;
            Console.WriteLine("ToString:");
            Console.WriteLine(list);

            Console.WriteLine("Min and Max:");
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
