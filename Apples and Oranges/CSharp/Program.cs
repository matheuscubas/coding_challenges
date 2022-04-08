using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
    public class Program
    {
        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            List<int> apples = new List<int> { -2, 2, 1 };
            List<int> oranges = new List<int> { 5, -6 };


            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var fallenApples = new List<int>();
            var fallenOranges = new List<int>();

            foreach (var apple in apples)
            {
                if(apple + a >= s && apple + a <= t)
                {
                    fallenApples.Add(apple);
                }
            }

            foreach (var orange in oranges)
            {
                if(orange + b >= s && orange + b <= t)
                {
                fallenOranges.Add(orange);
                }
            }

            Console.WriteLine(fallenApples.Count);
            Console.WriteLine(fallenOranges.Count);
            
            Console.ReadLine();
        }
    }
}
