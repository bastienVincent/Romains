using Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Implementations
{
    public class ConvertisseurRomain : IConvertisseurRomain
    {
        string[] listeEntier = new string[10] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] listeDizaine = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] listeCentaine = new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] listeMillier = new string[5] { "", "M", "MM", "MMM", "MMMM" };



        public  string ConvertirEnNombreRomain(int nombre)
        {
            if (nombre > 0 && nombre < 5000)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(RetournerMillierRomain(nombre / 1000 % 10)).Append(RetournerCentaineRomain(nombre / 100 % 10)).Append(RetournerDizaineRomain(nombre / 10 % 10)).Append(RetournerEntierRomain(nombre % 10));
                return sb.ToString();
            }
            else
                return "";
        }

        private string RetournerEntierRomain(int nombre)
        {
            return listeEntier[nombre];
        }

        private string RetournerCentaineRomain(int nombre)
        {
            return listeCentaine[nombre];
        }

        private string RetournerDizaineRomain(int nombre)
        {
            return listeDizaine[nombre];
        }

        private string RetournerMillierRomain(int nombre)
        {
            return listeMillier[nombre];
        }
    }
}
