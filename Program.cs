using System;

namespace christmasTree
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (args.Length > 0)
            {
                Draw(String.Join(" ",args));
            }
            else
            {
                string text = "Merry Christmas And Happy New Year";
                Draw(text);
            }
        }
        static void Draw(string text)
        {
            int colorIndex = 0;
            if (text.Length % 2 != 0)
            {
                int size = ((text.Length / 2) + 5);
                int SaveSize = size;
                for (int i = 1; i < text.Length + 1; i += 2)
                {
                    if (colorIndex > 2)
                    {
                        colorIndex = ChangeColor();
                    }
                    string subString = text.Substring(0, i);
                    Console.WriteLine(String.Format("{0, " + size.ToString() + "}", subString));
                    size++;
                    colorIndex++;
                }
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(String.Format("{0, " + (SaveSize + 1).ToString() + "}", "|||"));
                }
            }
            else
            {
                int size = ((text.Length / 2) + 5);
                int SaveSize = size;
                for (int i = 2; i < text.Length + 2; i += 2)
                {
                    if (colorIndex > 2)
                    {
                        colorIndex = ChangeColor();
                    }
                    string subString = text.Substring(0, i);
                    Console.WriteLine(String.Format("{0, " + size.ToString() + "}", subString));
                    size++;
                    colorIndex++;
                }
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(String.Format("{0, " + SaveSize.ToString() + "}", "||"));

                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static int ChangeColor()
        {
            if (Console.ForegroundColor == ConsoleColor.White)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return 0;
            }
            if (Console.ForegroundColor == ConsoleColor.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return 0;
            }
            if (Console.ForegroundColor == ConsoleColor.Green)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return 0;
            }
            if (Console.ForegroundColor == ConsoleColor.Red)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return 0;
            }
            if (Console.ForegroundColor == ConsoleColor.Blue)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return 0;
            }
            return 0;
        }
    }
}

/*One Way
 * 
 * int colorIndex = 0;
                string text = "merry christmas and happy new year";
                if(text.Length % 2 != 0)
                {
                    int size = ((text.Length / 2) + 5);
                    int SaveSize = size;
                    for (int i = 1; i < text.Length + 1; i += 2)
                    {
                        if (colorIndex > 2)
                        {
                            colorIndex = ChangeColor();
                        }
                        string subString = text.Substring((text.Length / 2) - i / 2, i);
                        Console.WriteLine(String.Format("{0, " + size.ToString() + "}", subString));
                        size++;
                        colorIndex++;
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(String.Format("{0, " + (SaveSize + 1).ToString() + "}", "|||"));
                    }
                }
                else
                {
                    int size = ((text.Length / 2) + 5);
                    int SaveSize  = size;
                    for (int i = 2; i < text.Length + 2; i += 2)
                    {
                        if (colorIndex > 2)
                        {
                            colorIndex = ChangeColor();
                        }
                        string subString = text.Substring((text.Length / 2) - i / 2, i);
                        Console.WriteLine(String.Format("{0, " + size.ToString() + "}", subString));
                        size++;
                        colorIndex++;
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(String.Format("{0, " + SaveSize.ToString() + "}", "||"));

                    }
                }
 */
