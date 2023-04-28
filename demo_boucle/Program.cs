using System.ComponentModel;

namespace demo_boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region demo
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
            #endregion
            */
            /*
            #region incrementation
            int x = 0;

            while (x < 10) { 
                Console.WriteLine($"x vaut : {x}");
                x++;
            } //while
            #endregion
            */

            /*
            #region A ligne, while
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
            #endregion
            */


            #region do while 
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

            #endregion
        }// static Void


    }
}
