using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP1Exercice2
{
    internal class FILM
    {
        string titre;
        string nomActeur;
        int anneeProd;

        public FILM(string titre, string nomActeur, int anneeProd)
        {
            this.Titre = titre;
            this.NomActeur = nomActeur;
            this.AnneeProd = anneeProd;
        }

        public string Titre { get => titre; set => titre = value; }
        public string NomActeur { get => nomActeur; set => nomActeur = value; }
        public int AnneeProd { get => anneeProd; set => anneeProd = value; }

        public override string ToString()
        {
            return "Film: " + this.titre + " " + this.anneeProd + " "+ this.nomActeur;
        }


    }
}
