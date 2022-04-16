using System;

namespace Function2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPlaer = 0;
            int minHealt = 0;
            int maxHealt = 10;
            bool isExit = true;

            while (isExit)
            {
                Console.Write("\nЕсли хотите закрыть программу наберите exit \nДля продолжения нажмите enter - ");
                isExit = Console.ReadLine() != "exit";
                Console.Clear();

                GetDataFromUser(ref inputPlaer,maxHealt,minHealt);
                DrawBar(inputPlaer,minHealt, maxHealt, ConsoleColor.Red, 0,"#");
            }
        }
        static void GetDataFromUser(ref int inputPlaer,int maxValue,int minValue,int position=2)
        {
            bool thisIsInputOfValue = true;

            while (thisIsInputOfValue)
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("Введите число от "+minValue+" до "+maxValue);
                string stringTemp = Console.ReadLine();

                if (int.TryParse(stringTemp, out inputPlaer))
                {
                    if (inputPlaer > minValue & inputPlaer <= maxValue)
                    {
                        thisIsInputOfValue = false;
                    }
                }
                Console.Clear();
            }
        }

        static void DrawBar(int value,int minValue,int maxValue,ConsoleColor color,int position, string symvol=" ")
        {
            Console.Clear();
            ConsoleColor defaulColor = Console.BackgroundColor;
            string bar = "";
            value = Percent(value, minValue, maxValue);

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

        static int Percent(int value, int minValue, int maxValue)
        {
            int returnValue ;
            double percent = 100;
            double tempNumber = (Convert.ToDouble(value) / Convert.ToDouble(maxValue - minValue)) * percent;
            returnValue = Convert.ToInt32(maxValue / percent * tempNumber);
            return returnValue;
        }
    }
}
