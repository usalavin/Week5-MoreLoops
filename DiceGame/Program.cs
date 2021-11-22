using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohrem, ongi mängu võitja
            //*täringuid vIsatakse kolm korda
            //programm kuulutab võitjat


            Random rnd = new Random();
            //arvuti vise
            int cpuScore = 0;
            int userScore = 0;

            for (int sum = 0; sum < 3; sum++)
            {
                int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

                




                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;

                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }

            if(cpuScore > userScore)
            {
                Console.WriteLine("arvuti võitis.");
            }
            else if(cpuScore < userScore)
            {
                Console.WriteLine("kasuataja võitis! Palju õnne!");
            }
            else
            {
                Console.WriteLine("Viik!");
            }
        }
    }

}