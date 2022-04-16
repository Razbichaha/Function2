using System;

namespace Function2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPlaer = 0; 
            int maxHealt = 10;
            
            while(true)
            {
                OutputMenu(ref inputPlaer);
                DrawBar(inputPlaer, maxHealt, ConsoleColor.Red, 0,"#");

            }
        }
        static void OutputMenu(ref int inputPlaer,int position=2)
        {
            bool thisIsInputOfValue = true;

            while (thisIsInputOfValue)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("Введите число от 0 до 10");
                string stringTemp = Console.ReadLine();
                bool isNumber = false;

                for (int i = 0; i < stringTemp.Length; i++)
                {
                if(char.IsNumber(stringTemp,i))
                    {
                        isNumber = true;
                    }
                }

                if(isNumber)
                {
                    inputPlaer = int.Parse(stringTemp);
                    if (inputPlaer > 0 & inputPlaer <= 10)
                    {
                        thisIsInputOfValue = false;
                    }
                }
                Console.Clear();
            }
        }

        static void DrawBar(int value,int maxValue,ConsoleColor color,int position, string symvol=" ")
        {
            Console.Clear();
            ConsoleColor defaulColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symvol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaulColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += symvol;
            }
            Console.Write(bar);
            Console.Write("]");
        }
    }
}
