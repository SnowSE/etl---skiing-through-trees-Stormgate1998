using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
using System.IO;


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
            int result = 0;
            int isTree;
            List<string> list = new List<string>();
            Console.Clear();
            Console.WriteLine("Please input the side part of the slope");
            side = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please input the down part of the slope");
            down = int.Parse(Console.ReadLine());

            using (StreamReader sr = new StreamReader(@"C:\Users\student\source\repos\etl---skiing-through-trees-Stormgate1998\Skiing_Amongst_Trees\TreeMap.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            xpostition = 0;
            result = 0;
            for(int i= 0; i < list.Count; i+= down)
            {
                    isTree = '#'.CompareTo(list[i][xpostition]);
                    if (isTree == 0){
                        result += 1;
                    }
                    xpostition += side;
                xpostition %= list[i].Length;
            }
            Console.WriteLine($"You ran into {result} trees");
        }  
    }
}
