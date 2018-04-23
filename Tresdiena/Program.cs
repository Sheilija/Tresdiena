using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresdiena
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uzdevums18 uzd = new Uzdevums18();
                uzd.Trijsturis();
            Console.ReadLine();*/
        }
        /*
        public static void Piemeri()
        {
            int?[] skaitluMasivs = new int?[8];
            int skaitlis = 0;
            //sis tips ir masiva tips
            skaitluMasivs[0] = 1;
            skaitluMasivs[1] = 2;
            skaitluMasivs[3] = 3;
            //..
            skaitluMasivs[7] = 8;
            skaitluMasivs[8] = 9;//šī rinda izmestu kļūdu
                                 //sākumā nodefinējam, kāds bus tips, šo rakstām tad, ja negribam norādīt, cik elementu būs masīvā
            int[] skaitluMasivs2 = new int[] {
           1, 3, 50, 100, 500
            };

            //īsā versija 
            int[] SkaitluMasivs2 = {
           1, 3, 50, 100, 500 };

            for (int i = 0; i < skaitluMasivs.Length; i++)
            //cikls darbojas, kamēr sasniegts masīva garums
            {
                //panem skaitli no masiva, kurš atrodas pozicijā "i"
                int? skaitlisNoMasiva = skaitluMasivs[i];
                //ja skaitlis no masīva ir vertība
                if (skaitlisNoMasiva.HasValue)
                {
                    Console.WriteLine(skaitlisNoMasiva);
                }

                else
                {
                    Console.WriteLine("Nav vērtības");
                }
            }
            Console.ReadLine();
        }
        public static void Piemers2()
        {
            List<int> skaitluSaraksts = new List<int>();

            //atšķirībā no masīviem, listā var pievienot daudz elementus un izmērs vairs nav svarīgs

            skaitluSaraksts.Add(5);
            skaitluSaraksts.Add(7);
            skaitluSaraksts.Add(20);

            List<int> skaitluSaraksts2 = new List<int>()
            {
                5, 7, 20
            };
            skaitluSaraksts2.Add(100);
            skaitluSaraksts2.AddRange(new[] { 45, 2090, 20 });
            skaitluSaraksts2.OrderBy(s => s);
            skaitluSaraksts2 = skaitluSaraksts2

                //funkcija ar kuru filtrēsim  katru elementu, katru elemntu nieliekam vērtībā s un tad mēs pasakām kāds ir nosacījums šim parametram
                //! nozīmē , ka nav vienāds un divas izsaukuma zīmes nozīmē ka ir vienāds
                .Where(s => s != 100)
                //dilstošā secībā būtu .OrderByDescending
                .OrderBy(s => s)
                //pārvērš atpakaļ sarakstu, šī funkcija pasaka, lai tiek izpilditas augšupminētās darbības
                .ToList();

            //ņem katru vērtību, kas ir sarakstā vai  masīvā un liek iekšā vērtībā, kas ir skaitlis
            foreach(int skaitlis in skaitluSaraksts2)
            {
                Console.WriteLine(skaitlis);
                */
            
           // Uzdevums18 uzd = new Uzdevums18()
           // uzd.ApgrieztsSkaitlis(Console.ReadLine());
    }
            }
           
  


