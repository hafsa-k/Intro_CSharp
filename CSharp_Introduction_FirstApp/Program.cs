using System.Security.Cryptography.X509Certificates;

namespace CSharp_Introduction_FirstApp
{
    internal class Program
    {
        static string program_name = "Démonstration pour les Games!";
        static void Main(string[] args)
        {
            //string message = "Hello, world!";
            //Console.WriteLine(message);
            //Console.WriteLine(program_name);

            //------EXO 1--------

            // ecrire un texte
            Console.WriteLine("Inscrivez votre prénom");
            // permet d'inserer du texte mais necessite un WriteLine au dessus
            // en mettant un ? après le string, indique que normalement la valeur sera un string mais on ne le sais pas vraiment
            string? name = Console.ReadLine();
            // nettoyer la console
            Console.Clear();

            Console.WriteLine("Inscrivez votre Nom");
            string? last_name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Inscrivez votre âge");
            string? age = Console.ReadLine();

            Console.Clear();


            //mettre un dollars devant le texte permet d'y inserer une variable sans devoir mettre de concaténation
            Console.WriteLine($"Bonjour à vous, {name} {last_name}");
            Console.WriteLine($"Vous ne faites pas vos {age} ans");

        }
    }
}