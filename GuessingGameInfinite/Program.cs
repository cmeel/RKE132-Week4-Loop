using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Arva ära, mis numbri peale robot mõtleb: ");
                int kasutajaSisend = Convert.ToInt32(Console.ReadLine());
                if (kasutajaSisend != cpuNumber)
                {
                    Console.WriteLine("Arvasid valesti, proovi uuesti!");
                }
                else
                {
                    loopActive = false;
                }
            }
            Console.WriteLine("Tubli, arvasid õigesti");
        }
    }
}
