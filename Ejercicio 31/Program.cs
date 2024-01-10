using System;
namespace Ejercicio_31
{
    public class Program
    {
        public static void Main( )
        {
            const string MsgIntNome = "Selecciona el nom d'usuari";
            const string MsgIntNumber = "Introdueix un nombre dins del rang [1,500]";

            Console.WriteLine( MsgIntNome );
            NameRang();
            Console.WriteLine(MsgIntNumber);
            NumbreRang();
            Console.WriteLine(GenerateRandomNumber);
        }

        public static void NameRang( )
        {
            string name;
            do
            {
                name = Console.ReadLine();
            } while (name.Length > 10);
        }
        public static void NumbreRang( )
        {
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1 || number > 500);
        }

        public static int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 100);
        }
    }
}
