using System;
using System.Text;

namespace NombresRomains
{
    class Program
    {
        static string[] listeEntier = new string[10] { "", "I", "II","III","IV","V","VI","VII","VIII","IX" };
        static string[] listeDizaine = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        static string[] listeCentaine =  new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        static string[] listeMillier = new string[5] { "", "M", "MM", "MMM", "MMMM" };

        static void Main(string[] args)
        {
            
            Console.WriteLine("Veuillez entrer un nombre entre 1 et 4999 pour voir sa repésentation en nombre romain. exit pour quitter l'application");


            var input = Console.ReadLine();

            while(input.ToLower()!="exit")
            {
                int nombre = 0;
                if (int.TryParse(input, out nombre))
                {
                    if (nombre > 0 && nombre < 5000)
                    {
                        Console.WriteLine(convertirEnNombreRomain(nombre));
                    }
                    else
                        Console.WriteLine("Valeur non comprise entre 1 et 4999. Entrez une nouvelle valeur");
                }
                else
                    Console.WriteLine("Valeur spécifiée n'est pas un nombre. Entrez une nouvelle valeur");
                input = Console.ReadLine();
            }
        }

        private static string convertirEnNombreRomain(int nombre)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(RetournerMillierRomain(nombre / 1000 % 10)).Append(RetournerCentaineRomain(nombre / 100 % 10)).Append(RetournerDizaineRomain(nombre / 10 % 10)).Append(RetournerEntierRomain(nombre % 10));
            return sb.ToString();
        }

        static string RetournerEntierRomain(int nombre)
        {
            return listeEntier[nombre];
        }

        static string RetournerCentaineRomain(int nombre)
        {
            return listeCentaine[nombre];
        }

        static string RetournerDizaineRomain(int nombre)
        {
            return listeDizaine[nombre];
        }

        static string RetournerMillierRomain(int nombre)
        {
            return listeMillier[nombre];
        }




    }
}
