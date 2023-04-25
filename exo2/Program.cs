namespace exo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ECRIRE CHIFFRE

            Console.WriteLine("Inscrivez un chiffre");
            string? number1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Inscrivez un second chiffre");
            string? number2 = Console.ReadLine();

    

            //PARSE V1

            int convert_number_1 = int.Parse(number1);
            int convert_number_2 = int.Parse(number2);

            int calcul1 = convert_number_1 + convert_number_2;

            Console.WriteLine($"la sommes de {convert_number_1} et {convert_number_2} est de  {calcul1}");

            // PARSE V2 simplifié

            Console.WriteLine("Inscrivez un chiffre");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inscrivez un second chiffre");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"la sommes de {number3} et {number4} est de  {number3 + number4}");


            // TRYPARSE V1

            
            Console.WriteLine("Inscrivez un chiffre");
            string? number5 = Console.ReadLine();

            int nb5;
            bool converted_number_5 = int.TryParse(number5, out nb5);

            Console.WriteLine("Inscrivez un second chiffre");
            string? number6 = Console.ReadLine();

            int nb6;
            bool converted_number_6 = int.TryParse(number6, out nb6);

            Console.WriteLine($"La conversion du premier nombre : {converted_number_5}");
            Console.WriteLine($"La conversion du second nombre : {converted_number_6}");
            Console.WriteLine($"la sommes est de {nb5 + nb6}");

            // TRYPARSE V2 simplifié

            Console.WriteLine("Inscrivez un chiffre");

            int nb7;
            int.TryParse(Console.ReadLine(), out nb7);

            Console.WriteLine("Inscrivez un second chiffre");

            int nb8;
            int.TryParse(Console.ReadLine(), out nb8);

            Console.WriteLine($"la sommes est de {nb7 + nb8}");

            // TRYPARSE V2 très simplifié

            Console.WriteLine("Inscrivez un chiffre");

            int.TryParse(Console.ReadLine(), out int nb9);

            Console.WriteLine("Inscrivez un second chiffre");

            int.TryParse(Console.ReadLine(), out int nb10);

            Console.WriteLine($"la sommes est de {nb9 + nb10}");




        }
    }
}