using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső=LeesőSorsoló(golyók);
            Kiíró(golyók);
            do
            {

            } while (leeső!=8);

            
            Console.ReadKey();
        }

        static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
        }

        static int LeesőSorsoló(List<int> golyók)  //Hányadik golyó fog leesni a listából.
        {
            int szám = 0;
            Random gép = new Random();
            szám = gép.Next(golyók.Count);
            golyók.Remove(szám);

            return golyók[szám];
        }

        static void Kezdés(List<int> golyók)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i);
            }
        }
    }
}
