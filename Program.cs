using System;

namespace vn_mode_csharp_dz_18
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string userSymbolString;
                Console.WriteLine("Введите строку используя только символы '(' и ')'");

                userSymbolString = Console.ReadLine();

                int counterUserStringDeep = 0;
                int counterSymbolsDifference = 0;
                char userSymbolOne = '(';
                char userSymbolTwo = ')';

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

                if (counterSymbolsDifference < 0)
                {
                    Console.WriteLine("Некорректное скобочное выражение");
                }

                if (counterSymbolsDifference > 0)
                {
                    Console.WriteLine("Некорректное скобочное выражение");
                }

                if (counterSymbolsDifference == 0)
                {
                    Console.WriteLine("Глубина вложенности скобок =  " + counterUserStringDeep);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

