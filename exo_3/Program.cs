namespace exo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuiller indiquer un nombre pair : ");
            string? nbr_str = Console.ReadLine();

            int nbr;
            bool nbr_isConvert = int.TryParse(nbr_str, out nbr);

            if (nbr_isConvert) 
            {
                int demi = nbr / 2;
                if (demi + demi == nbr) Console.WriteLine("Votre chiffre est pair");

                else Console.WriteLine("Votre chiffre est impair, on avait dit un chiffre pair");
              

            }
            else
            {
                Console.WriteLine("Ce n'est pas un chiffre");    
            }
        }
    }
}