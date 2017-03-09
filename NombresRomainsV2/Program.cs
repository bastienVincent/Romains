using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresRomainsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer un nombre entre 1 et 4999 pour voir sa repésentation en nombre romain. exit pour quitter l'application");

            var input = Console.ReadLine();
            while (input.ToLower() != "exit")
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
            switch (nombre)
            {
                case 0:
                    return "";
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return "";
            }

        }

        static string RetournerCentaineRomain(int nombre)
        {
            switch (nombre)
            {
                case 0:
                    return "";
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return "CD";
                case 5:
                    return "D";
                case 6:
                    return "DC";
                case 7:
                    return "DCC";
                case 8:
                    return "DCCC";
                case 9:
                    return "CM";
                default:
                    return "";
            }
        }

        static string RetournerDizaineRomain(int nombre)
        {
            switch (nombre)
            {
                case 0:
                    return "";
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return "XL";
                case 5:
                    return "L";
                case 6:
                    return "LX";
                case 7:
                    return "LXX";
                case 8:
                    return "LXXX";
                case 9:
                    return "XC";
                default:
                    return "";
            }
        }

        static string RetournerMillierRomain(int nombre)
        {
            switch (nombre)
            {
                case 0:
                    return "";
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                case 4:
                    return "MMMM";
                default:
                    return "";
            }
        }
    }
}

