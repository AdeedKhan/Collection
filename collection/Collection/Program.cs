namespace Collection

{
    using System.Collections;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(true);
            foreach (var o in arrayList)
                Console.WriteLine(o);
        }
    }
}
