using System;

namespace _1._2._2_SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Microsoft .NET Framework 2 Application Development Foundation";

            string[] sa = s.Split(" ");
            for (int i = 0; i < sa.Length; i++)
                Console.Write("{0} ",sa[i]);
            Console.WriteLine();

            Array.Sort(sa);
            for (int i = 0; i < sa.Length; i++)
                Console.Write("{0} ", sa[i]);
            Console.WriteLine();

            s = string.Join(" ", sa); 
            Console.WriteLine(s);
        }
    }
}
