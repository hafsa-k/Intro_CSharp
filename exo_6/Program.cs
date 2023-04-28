namespace exo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire une numéro BBAN (12 chiffres) :");
            string bban_str = Console.ReadLine();
            if (bban_str.Length == 12 && long.TryParse(bban_str, out _))
            {
                string ten_first = bban_str.Substring(0, 10);
                string two_last = bban_str.Substring(10);
                string concat = two_last + two_last + 111400;

                long ten = long.Parse(ten_first);
                short two = short.Parse(two_last);
                long four = long.Parse(concat);

              
                short modulo = (short)(four % 97);

                int first_dig_be = 98 - modulo;

                Console.WriteLine($"Votre Iban est : BE{first_dig_be} {ten}{two}");

            }
            else { 
                Console.WriteLine("BBAN Invalide");
            }
        }
    }
}