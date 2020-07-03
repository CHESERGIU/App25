using System;

namespace App25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minim = 0;
            int count = 0;
            do
            {
                input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                else
                {
                    count++;
                    int value = int.Parse(input);
                    for (int i = 0; i < count; i++)
                    {
                        if (value < minim)
                        {
                            minim = value;
                        }
                        count--;
                    }
                }
            } while (!(input == "0"));
            Console.WriteLine(minim);
        }
    }
}
