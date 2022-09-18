using System;
namespace MyFirstConsoleApplication
{
    public static class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nNow I will prompt you asking for the width and height of window frames, \nand I will let you know how much material you need");

            Console.Write("\nGive me the width. ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("\nGive me the height. ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");
        }
    }
}



