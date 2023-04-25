namespace demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuiller indiquer votre age : ");
            string years_old = Console.ReadLine();

            // VERSION 1
            //int age_convert = Convert.ToInt32(years_old);
            //Console.WriteLine($"L'age converti est : {age_convert} de type {age_convert.GetType()}");

            // VERSION 2
            /*int age_parse = int.Parse(years_old);
            Console.WriteLine ($"L'age converti est : {age_parse} de type {age_parse.GetType()}");*/

            int age_tryparse;
            bool age_isok = int.TryParse(years_old, out age_tryparse);

            Console.WriteLine($"L'age a été converti : {age_isok}");
            Console.WriteLine($"L'age converti est : {age_tryparse} de type {age_tryparse.GetType()}");
        }
    }
}