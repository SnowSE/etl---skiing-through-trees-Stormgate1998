using System;
using System.IO.File


namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (string line in System.IO.File.ReadLines(@"c:\test.txt"))
            {  
                Console.WriteLine(line);    
            }  
            Console.WriteLine("Hello World!"); 
        }
    }
}
