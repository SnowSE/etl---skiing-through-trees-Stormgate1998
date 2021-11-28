using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
using static System.IO.File;


namespace Skiing_Amongst_Trees
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            int down;
            int side;
            int xpostition;
            int ypostition = xpostition = 0;
            int result = 0;
            bool isTree;
            string[] list = new string[323];
            Console.WriteLine("Please input the down part of the slope");
            down = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the side part of the slope");
            side = int.Parse(Console.ReadLine());

            foreach (string line in ReadLines(@"C:\Users\student\source\repos\etl---skiing-through-trees-Stormgate1998\Skiing_Amongst_Trees\TreeMap.txt"))
            {
                list[counter] = line; 
                counter++;
            } 

            for(int i= 0; i < list.Length; i+= down)
            {
                while(xpostition < list[i].Length)
                {
                    isTree = Char.IsPunctuation(list[i][xpostition]);
                    if (!isTree){
                        result++;
                    }
                    xpostition += side;
                }
                xpostition %= list[i].Length;

            }
            Console.WriteLine(result);
        }

        
    }
}
