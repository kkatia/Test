using System;
using System.Linq;

namespace ReverseString
{
    class Reverse
    {        
      public void Reversing(string a)
        {
            char[] ar = a.ToArray<char>();

            for (int j = ar.Length - 1; j >= 0; j--)
            {
                Console.Write(ar[j]);
            }
            Console.WriteLine();
        }
            
    }

    class Program
    {
                static void Main()
        {
            string a="";
            Console.WriteLine("Input a string and get the reversed string: "+
                "\n Input 'exit' to quit the application.");
            while (a != "exit")
            {
                a = Console.ReadLine();
                Reverse re = new Reverse();
                re.Reversing(a);
            }

            Environment.Exit(0);
        }
    }
}
