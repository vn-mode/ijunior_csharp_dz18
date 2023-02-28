using System;

namespace vn_mode_csharp_dz_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterUserStringDeep = 0;
            int counterSymbolsDifference = 0;

            char userSymbolOne = '(';
            char userSymbolTwo = ')';

            string userSymbolString;

            Console.WriteLine($"Введите строку используя только символы {userSymbolOne} и {userSymbolTwo}");

            userSymbolString = Console.ReadLine();


            foreach (var everyTextSymbol in userSymbolString)
            {

                if (counterSymbolsDifference >= 0)
                {

                    if (everyTextSymbol == userSymbolOne)
                    {
                        counterSymbolsDifference++;
                    }
                    else if (everyTextSymbol == userSymbolTwo)
                    {

                        if (counterUserStringDeep < counterSymbolsDifference)
                        {
                            counterUserStringDeep = counterSymbolsDifference;
                        }

                        counterSymbolsDifference--;
                    }
                }
            }

            if (counterSymbolsDifference == 0)
            {
                Console.WriteLine("Глубина вложенности скобок =  " + counterUserStringDeep);
            }
            else
            {
                Console.WriteLine("Некорректное скобочное выражение");
            }
        }
    }
}

