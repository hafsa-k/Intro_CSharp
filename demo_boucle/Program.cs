using System.ComponentModel;

namespace demo_boucle
{
    internal class Program
    {
        #region nombe random 
        static Random RNG = new Random();
        #endregion
        static void Main(string[] args)
        {
            #region demo
            /*
            Console.WriteLine("veuillez introduire un nombre: ");
            string nb1_str = Console.ReadLine();
            short nb1;
            bool is_convert = short.TryParse(nb1_str, out  nb1);


            while (!is_convert)
            {
                Console.WriteLine($"{nb1_str} n'est pas un nombre. Veuillez introduire un nombre entre 1 et 10.");
                nb1_str = Console.ReadLine();
                is_convert = short.TryParse(nb1_str, out nb1 );
            }


            while (nb1 < 1 || nb1 > 10) 
            {
                Console.WriteLine("Ce n'est pas un chiffre entre 1 et 10 ... ");
                nb1_str = Console.ReadLine();
                is_convert = short.TryParse(nb1_str, out nb1);
               while (!is_convert)
                {
                    Console.WriteLine($"{nb1_str} n'est pas un nombre. Veuillez introduire un nombre entre 1 et 10.");
                    nb1_str = Console.ReadLine();
                    is_convert = short.TryParse(nb1_str, out nb1);
                }
            }
            Console.WriteLine("C'es bien un chiffre en 1 et 10!");
            */
            #endregion

            #region incrementation
            /*
            int x = 0;

            while (x < 10) { 
                Console.WriteLine($"x vaut : {x}");
                x++;
            } //while
            */
            #endregion

            #region A ligne, while
            /*
            Console.WriteLine("veuillez introduire un nombre: ");
            string nbr = Console.ReadLine();
            int incr = 0;
            int limite = int.Parse(nbr);
            string letter = "A";

            while (incr < limite)
            {
                Console.WriteLine(letter);
                letter += "A";
                incr++;
            } //while
            */
            #endregion

            #region do while 
            /*
            string password = "Voltron";
            string insert_password = "";
            Console.WriteLine("Bonjour Bienvenue");
            short compteur = 0;


            do
            {
                Console.WriteLine("Introduisez votre mot de passe : ");
                insert_password = Console.ReadLine();
                compteur++;

            } while (insert_password != password && compteur < 3);

            if (insert_password != password) {
                Console.WriteLine("Malheureusement, votre mot de passe est faux et vous avez dépassé votre nombre d'essaies possible");
            }
            else {
                Console.WriteLine("Bienvenue ! Ca faisait longtemps");
                    
            }

            */
            #endregion

            #region boucle for
            /*

            for (int multiple = 1; multiple < 11; multiple++) { 

                Console.WriteLine($"Table de {multiple}");

                for (int multiplicant = 1; multiplicant < 11; multiplicant++)
                {
                    int multiplication = multiple * multiplicant;
                    Console.Write( $"{multiple} x {multiplicant} = {multiplication} ; ");

                } // end for multiplicant

                Console.WriteLine("");

            } // end for multiple

            */
            #endregion

            #region appli deux nombre 
            /*

            int juste_prix = 10;
            short reponse;
            do {
                Console.WriteLine("Donne moi un chiffre : ");
                string proposition = Console.ReadLine();
                reponse = short.Parse(proposition);
                    if (reponse < juste_prix)
                    {
                        Console.WriteLine("C'est plus, repropose");

                    } // end if moins
                    if (reponse > juste_prix)
                    {
                        Console.WriteLine("C'est moins, repropose");
                    } // end if plus

            } while (juste_prix != reponse);

           
            Console.WriteLine($"Genial, tu as trouvé le bon chiffre, il s'agit bien de {reponse}");

            */
            #endregion

            #region appli deux nombre Exemple avec un RNG aléatoire
            /*

            // le numero random doit se trouver tout en haut comme les src

            for(int i = 0; i < 10; i++)
            {
                int nb_aleatoire = RNG.Next(5, 15); 
                Console.WriteLine(nb_aleatoire);
            }
            */
            #endregion

            #region appli deux nombre V2

            int juste_prix_v2 = RNG.Next(0, 20);
            short reponse_v2;
            int guess_try = 0;
            do
            {
                Console.WriteLine("Donne moi un chiffre : ");
                string proposition_v2 = Console.ReadLine();
                reponse_v2 = short.Parse(proposition_v2);
                if (reponse_v2 < juste_prix_v2)
                {
                    Console.WriteLine("C'est plus, repropose");

                } // end if moins
                if (reponse_v2 > juste_prix_v2)
                {
                    Console.WriteLine("C'est moins, repropose");
                } // end if plus
                guess_try++;

            } while (juste_prix_v2 != reponse_v2);


            Console.WriteLine($"Genial, tu as trouvé le bon chiffre, il s'agit bien de {reponse_v2}, tu as eu besoin de {guess_try} essaies");

            #endregion

        }// static Void


    }
}
