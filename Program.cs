using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("nobel.csv", Encoding.UTF8);
            sr.ReadLine();
            List<Nobel> lista = new List<Nobel>();
            while (!sr.EndOfStream)
            {
                lista.Add(new Nobel(sr.ReadLine()));
            }
            sr.Close();

            //3. feladat:
            foreach (var item in lista)
            {
                if (item.KeresztNev == "Arthur B." && item.VezetekNev == "McDonald")
                {
                    Console.WriteLine($"3. feladat: {item.Tipus}");
                }

            }
            //4. feladat:
            foreach (var item in lista)
            {
                if (item.EvSzam == 2017 && item.Tipus == "irodalmi")
                {
                    Console.WriteLine($"4. feladat: {item.KeresztNev} {item.VezetekNev}");
                }
            }

            //5. feladat:
            Console.WriteLine($"5. feladat:");
            foreach (var item in lista)
            {
                if (item.EvSzam >= 1990 && item.VezetekNev == "")
                {
                    Console.WriteLine($"\t{item.EvSzam} - {item.KeresztNev}");
                }
            }

            //6. feladat: 
            Console.WriteLine($"6.feladat:");
            foreach (var item in lista)
            {
                if (item.VezetekNev.Contains("Curie"))
                {
                    Console.WriteLine($"\t{item.EvSzam}: {item.KeresztNev} {item.VezetekNev}({item.Tipus})");
                }
            }

            //7. feldat:
            int fizikai = 0;
            int kemiai = 0;
            int orvosi = 0;
            int irodalmi = 0;
            int beke = 0;
            int kozgazdasagtani = 0;

            Console.WriteLine($"7. feladat");

            foreach (var item in lista)
            {
                if (item.Tipus == "fizikai")
                {
                    fizikai++;
                }
                if (item.Tipus == "kémiai")
                {
                    kemiai++;
                }
                if (item.Tipus == "orvosi")
                {
                    orvosi++;
                }
                if (item.Tipus == "irodalmi")
                {
                    irodalmi++;
                }
                if (item.Tipus == "béke")
                {
                    beke++;
                }
                if (item.Tipus == "közgazdaságtani")
                {
                    kozgazdasagtani++;
                }
            }
            Console.WriteLine($"\tfizikai\t\t\t{fizikai}");
            Console.WriteLine($"\tkémiai\t\t\t{kemiai}");
            Console.WriteLine($"\torvosi\t\t\t{orvosi}");
            Console.WriteLine($"\tirodalmi\t\t{irodalmi}");
            Console.WriteLine($"\tbéke\t\t\t{beke}");
            Console.WriteLine($"\tközgazdaságtani\t\t{kozgazdasagtani}");

            StreamWriter sw = new StreamWriter("orvosi.txt");
            foreach (var item in lista)
            {
                if (item.Tipus == "orvosi")
                {
                    sw.WriteLine($"{item.EvSzam}:{item.VezetekNev} {item.KeresztNev}");
                }
            }
            Console.WriteLine("8.feladat: orvosi.txt");
        }
    }
}
