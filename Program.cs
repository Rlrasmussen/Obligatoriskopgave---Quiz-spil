using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatoriskopgave___Quiz_spil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variabler
            int liv = 10;
            Console.WriteLine($"Liv: {liv}");

            //Opretter array til at opbevare mine 25 ord
            string[] myWords = new string[] { "datamatiker", "switch", "array", "string", "integer", "boolean", "float", 
            "metode", "enum", "scoope", "static", "random", "console", "readkey", "writeline", "main", "readline",
            "double", "byte","compare", "char", "convert", "length", "while", "loop"};

            //Vælg et tilfældigt tal
            Random random = new Random();
            int randomNumber = random.Next(0,25);

            //Vælg tilfældigt ord
            string randomOrd = myWords[randomNumber].ToUpper();
            int ordLength = randomOrd.Length;
            
            //Opret svar array
            char[] ordSvar = new char[ordLength];
            for (int i = 0; i<ordLength; i++)
            {    
                ordSvar[i] = '_';
            }
            //Print svar array
            for (int i =0; i<ordLength; i++)
            {
                Console.Write(ordSvar[i]);
            }
            Console.WriteLine(" ");

            //Gæt et bogstav
            while (liv>0)
            {
                Console.WriteLine("Gæt et bogstav");
                char inputChar = Char.ToUpper(Console.ReadKey().KeyChar, CultureInfo.InvariantCulture);
                Console.WriteLine(" ");
                if (randomOrd.Contains(inputChar))
                {
                    for (int i =0; i<ordLength; i++)
                    {
                        if (randomOrd[i] == inputChar)
                        {
                            ordSvar[i] = inputChar;
                        }

                        Console.Write(ordSvar[i]);
                    }
                }
                else
                {
                    liv--;
                    Console.WriteLine("Det er forkert. Du mister 1 liv");
                    Console.WriteLine($"Liv: {liv}");
                }
                Console.WriteLine(" ");

                //Vinder besked
                //Hvis ordSvar ikke længere indeholder _
                if (!ordSvar.Contains('_') )
                {
                    Console.WriteLine("YOU WIN");
                    Console.Beep();
                    Console.ReadKey();
                    break;
                }
                 
                //Printer antal liv
                Console.WriteLine($"Liv: {liv}");
            }

            //Game over besked
            if (liv == 0)
            {
                Console.WriteLine($"Game over. Ordet var {randomOrd}");
                Console.ReadKey();
            }
            
        }
    }
}
