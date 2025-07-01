using exercice_de_gestion_des_livres.Class;

namespace exercice_de_gestion_des_livres
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Livre premierLivre = new Livre("Harry Potter à l'école des sorciers", "J.K. Rowling", 1997); 
            Livre deuxiemeLivre = new Livre("La Communauté de l'anneau", "J.R.R. Tolkien", 1954, true);
            Livre troisiemeLivre = new Livre("L'Étranger", "Albert Camus", 1942, false); // ajout de livre

            premierLivre.AfficherDetails(); // appel des méthodes
            Console.WriteLine();
            premierLivre.Emprunter();
            Console.WriteLine(); // passement de ligne
            premierLivre.AfficherDetails();
            Console.WriteLine();
            premierLivre.Rendre();
            Console.WriteLine();
            premierLivre.AfficherDetails();
            Console.WriteLine();
            deuxiemeLivre.AfficherDetails();
            Console.WriteLine();
            troisiemeLivre.AfficherDetails();
            Console.WriteLine();
            premierLivre.AfficherDetails();
        }
    }
};
