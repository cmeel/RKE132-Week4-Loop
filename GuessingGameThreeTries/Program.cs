using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis võidab mängu arvuti
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int failedTries = 0;

            while (failedTries < 3)
            {
                Console.WriteLine("Arva ära, mis numbri peale robot mõtleb: ");
                int kasutajaSisend = Convert.ToInt32(Console.ReadLine());
                if (kasutajaSisend != cpuNumber)
                {
                    failedTries++;
                    if (failedTries == 3) Console.WriteLine("Kaotasid!");
                    else Console.WriteLine($"Arvasid valesti, proovi uuesti! Saad veel {3 - failedTries} korda proovida.");
                }
                else if (failedTries == 3)
                {
                    Console.WriteLine("Arvasid numbrit liiga mitu korda valesti");
                }
                else if (kasutajaSisend == cpuNumber)
                {
                    Console.WriteLine("Tubli, arvasid õigesti! Võitsid!");
                    break;
                }
            }
        }
    }
}
