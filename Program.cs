using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Escribe un numero entre 0 y 100, ¿Cual sera tu primera elección?");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Muy alto, elige uno más pequeño");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Muy bajo, elige uno más alto");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("Eres el ganador");
                    win = true;
                }


            } while (win == false);
            Console.ReadKey(true);
        }
    }
}

