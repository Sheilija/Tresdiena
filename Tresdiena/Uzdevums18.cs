using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresdiena
{
    class Uzdevums18
    {
        public static void Trijsturis()
        //šī funkcija ir statiska un nevarēs pieņmt nekādas objekta vērtības
        {
            Console.Write("ievadi skaitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            //to int arī ir statiska funkcija

            //piemēram, ja rakstu public static void Krasa()
            // tad nevarēs rakstīt this.Krasa, jo static to neatļaus

            // Izvada skaitļus no 1 lidz N
            //
            for (int rinda = 1; rinda <= skaitlis; rinda++)
            {
                //izvada skaitļus rindā no 1 līdz rindas kārtas numuram
                for (int Kolonna = 1; Kolonna <= rinda; Kolonna++)
                //for (int Kolonna = skaitlis - rinda; Kolonna >= 1; Kolonna--)
                {
                    Console.Write(Kolonna);
                }
                Console.WriteLine();
            }

        }
        public static void ApgrieztsMasivs()
        {
            //1. paprasām lietotājam , cik skaitļus viņš norādīs
            //2.paprasīt ievadīt N skaitļus

            Console.Write("Cik skaitļus ievadīsi?");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] skaitli = new int[N];


            for (int i = 0; i < N; i++)
            {
                Console.Write("Ievadi " + i + ". skaitli");
                //varam likt i pozicijā, jo i ir no 0 līdz N
                skaitli[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = N - 1; i >= 0; i--)
            {

                Console.WriteLine(skaitli[i]);
            }
        }
        public static void SkaitlisN()
        {
            //skaitlu masivu svarīgi nodefinēt pirms cikla
            //tas ir predefinēts masīvs
            int[] masivs = { 0, 10, 20, 30, 40, 50 };
            Console.WriteLine("Ievadi skaitli, kurš atrodas masīvā:");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < masivs.Length; i++)
            {

                if (masivs[i] == skaitlis)
                {
                    Console.WriteLine("Skaitlis nav atrasts!");
                    Console.WriteLine("Pozīcija = " + i);
                    return;
                }
            }
            Console.WriteLine("skaitlis nav atrasts!");

            int pozicija = Array.IndexOf(masivs, skaitlis);
            if (pozicija == -1)
            {
                Console.WriteLine("Skaitlis nav atrasts!");
            }
            //ši funkcija vienmēr atgriež skaitlisku vērtību
            //ja elements nav atrasts, viņš atgriež -1
        }
    }
}
