using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class NewClass
    {
        public void SayHello(string name)
        {
            //Console.WriteLine($"Hello, {name}! Welcome to C#.");
            Console.WriteLine("This is a new file in a new class");
        }
        public int CalcArea(int length, int width)
        {
            
            int area = length * width;
            return area;
        }
        public static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country); 
        }
    }
}
