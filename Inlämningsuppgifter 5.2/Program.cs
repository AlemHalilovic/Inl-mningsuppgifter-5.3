using System;
namespace Övning_5._3._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vilken fotbollsklubb är den bästa", "Vem är the goat", "Hur många kontinenter finns det på vår jord", "Vilket djur är störst i världen" };
            string[] svar = { "Manchester United", "Harry Maguire", "7", "Adam" };
            bool spela = true;

            while (spela = true)
            {
                Console.WriteLine();
                Console.Write("Välj frågor mellan 1-4:");
                int val = int.Parse(Console.ReadLine());
                
                Console.WriteLine(frågor[val - 1]);
                string val2 = Console.ReadLine();

                if (val2 == svar[val - 1])
                {
                    Console.WriteLine("Rät svar!!!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Fel svar!!!");
                }

                Console.WriteLine("Vill du fortsätta j/n?");
                string fortsätta = Console.ReadLine();

                if (fortsätta == "j")
                {

                }
                else
                {
                    break;
                }

            }
            spela = false;
        }
    }
}