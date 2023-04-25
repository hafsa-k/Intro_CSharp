namespace Demo_operateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region opérateur deplacement de bits 
               /* int i = 1; //0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 1

                i = i << 4;

                Console.WriteLine(i);*/
            #endregion

            #region opérateur ternaire 
                Console.WriteLine("Veuillez indiquer votre âge : ");
                int age;
                bool is_convert = int.TryParse(Console.ReadLine(), out age);
                if (is_convert)
                {
                    /* placement d'un if. toujours dans l'ordre suivant, vrai et puis faux */
                    string status = (age < 18) ? "mineur" : "Majeur";
                    Console.WriteLine($"Vous êtes {status}. ");
                }
                else {
                    Console.WriteLine("Apprend à lire ?!");
                }

            #endregion
        }
    }
}