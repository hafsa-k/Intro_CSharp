namespace demo_list_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 10;
            int[] scores = new int[TAILLE];

            Console.WriteLine($"Combien de scores faut-il calculer? (entre 2 ou {TAILLE})");
            ushort nbr_scores = ushort.Parse( Console.ReadLine() );
            for (int i = 0; i < nbr_scores; i++) { 
                Console.WriteLine( $"Veuillez introduire le score du joueur {i + 1} : ");
                scores[i] = int.Parse( Console.ReadLine() );
            }// end for

            int sommes = 0;

            for (int i = 0;i < nbr_scores;i++)
            {
                sommes += scores[i];
            } //end for

            Console.WriteLine($"Votre moyenne de scores est : {sommes/nbr_scores}");

        }
    }
}