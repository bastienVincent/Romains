using Helpers.Interfaces;
using Ninject;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace NombresRomains
{
    class Program
    {
        private static IConvertisseurRomain _convertisseur;

        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();

            kernel.Load(Assembly.GetExecutingAssembly());
            _convertisseur = kernel.Get<IConvertisseurRomain>();

            Console.WriteLine("Veuillez entrer un nombre entre 1 et 4999 pour voir sa repésentation en nombre romain. exit pour quitter l'application");

            var input = Console.ReadLine();
            while(input.ToLower()!="exit")
            {
                int nombre = 0;
                if (int.TryParse(input, out nombre))
                {
                    //if (nombre == -1)
                     //   testerTouslesNombres();
                   // else 
                    if (nombre > 0 && nombre < 5000)
                    {
                        Console.WriteLine(_convertisseur.ConvertirEnNombreRomain(nombre));
                    }
                    else
                        Console.WriteLine("Valeur non comprise entre 1 et 4999. Entrez une nouvelle valeur");
                }
                else
                    Console.WriteLine("Valeur spécifiée n'est pas un nombre. Entrez une nouvelle valeur");
                input = Console.ReadLine();
            }
        }

        //private static void testerTouslesNombres()
        //{
        //    var timer = Stopwatch.StartNew();
        //    for (int j = 0; j < 10000; j++)
        //    {
        //        for (int i = 1; i < 5000; i++)
        //        {
        //            convertirEnNombreRomain(i);
        //        }
        //    }
        //    timer.Stop();
        //    Console.WriteLine("Temps : " + timer.ElapsedMilliseconds);
        //}

       
    }
}
