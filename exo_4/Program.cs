namespace exo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region premier exo
            /*
                Console.WriteLine("Veuiller indiquer un premier nombre : ");
                string? first_nbr_str = Console.ReadLine();

                Console.WriteLine("Veuiller indiquer un deuxieme nombre : ");
                string? second_nbr_str = Console.ReadLine();

                int nbr_one;

                int nbr_two;

            
                bool nbr_first_isConvert = int.TryParse(first_nbr_str, out nbr_one);
                bool nbr_second_isConvert = int.TryParse(second_nbr_str, out nbr_two);

                if (nbr_first_isConvert && nbr_second_isConvert ) { 
                    int div_entier = nbr_one / nbr_two;
                    int op_modulo = nbr_one % nbr_two;
                    // reaffectation du nbr_one car il est en int et que les int ne peuvent pas être des nombres à virgule 
                    double one = nbr_one;
                    double division = one / nbr_two;
            
                    Console.WriteLine($" Division entière : {div_entier} Modulo : {op_modulo}, Division : {division}");

                }
            */
            #endregion

            #region exo2

                Console.WriteLine("Veuiller indiquer votre numero de compte : ");
                string? compte = Console.ReadLine();
                int nbr_compte;
                bool compte_isConvert = int.TryParse(compte, out nbr_compte);

            if (compte_isConvert)
            {
                Console.WriteLine(nbr_compte.Substring(0,10));
            }



            //Console.WriteLine($"BE55{}");    
            #endregion





        }
    }
}