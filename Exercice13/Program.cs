using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration
            int entier;
            //ajout inutile pour le test gitHub
            //boucle de demande de saisie

            do
            {
                Console.WriteLine("Veuillez saisir un entier entre 1 et 9: ");
                entier = int.Parse(Console.ReadLine());
            } while (entier <1 || entier >9);
            //boucle sur la table

            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine(entier + " x " + k + " = " + (entier * k));

            }
                                 
            Console.ReadLine();

        }
    }
}
