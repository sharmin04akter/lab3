﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3

{
    class Triangle
    {
        int x;
        int y;
        int z;

        public Triangle()
        {
            x = 20;
            y = 20;
            z = 20;
        }
        public Triangle(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void ShowInfo()
        {
            Console.WriteLine("X : " + x);
            Console.WriteLine("Y : " + y);
            Console.WriteLine("Z : " + z);
        }
        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("The traingle is equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The traingle is isosceles");
            }
            else
            {
                Console.WriteLine("The traingle is scalene");
            }
        }
    }
}