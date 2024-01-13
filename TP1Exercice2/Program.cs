using System;
using TP1Exercice2;

namespace TP1Exerice1
{
    public static class Porgram
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Donner nombre de film a ajouter : ");
            int n = int.Parse(Console.ReadLine());

            FILM[] tabFilm= new FILM[n];
       
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Donner titre: ");
                string nf = Console.ReadLine();
                Console.WriteLine("Donner Nom acteur: ");
                string na = Console.ReadLine();
                Console.WriteLine("Donner annee: ");
                int an = int.Parse(Console.ReadLine());
                FILM e = new FILM(nf, na,an);
                tabFilm[i] = e;
            }
            Console.WriteLine("Affichage tableau de film : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tabFilm[i].ToString());
            }
            
            


        }
    }
}