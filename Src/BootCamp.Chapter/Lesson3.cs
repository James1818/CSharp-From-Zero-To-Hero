using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {

        }

        public static int returnInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float returnBMI(float weight, float height)
        {
            return (float)Math.Round(weight / height / height, 2);
        }
        public static float returnFloat(string message)
        {
            Console.WriteLine(message);
            return (float) Convert.ToDouble(Console.ReadLine());
        }
        public static string returnString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
