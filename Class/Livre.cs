using exercice_de_gestion_des_livres.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercice_de_gestion_des_livres.Class
{
    internal class Livre
    {
        // propriétés
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
        public bool EstEmprunte { get; set; }


        // Constructeur
        public Livre(string titre, string auteur, int annee, bool emprunt = false)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePublication = annee;
            EstEmprunte = emprunt;
        }

        public void Emprunter() // méthode
        {
            EstEmprunte = true;
            Console.WriteLine($"Le livre {Titre} a été emprunté");
        }

        public void Rendre() // méthode
        {
            EstEmprunte = false;
            Console.WriteLine($"Le livre {Titre} a été rendu");
        }

        public void AfficherDetails() // méthode
        {
            Console.WriteLine($"{Titre} de {Auteur} en {AnneePublication}. Emprunt:{EstEmprunte}");
        }
    }
};