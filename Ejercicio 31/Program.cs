using System;
namespace Ejercicio_31
{
    public class Program
    {
        public static void Main()
        {
            const string MsgIntNome = "Selecciona el nom d'usuari";
            const string MsgIntNumber = "Introdueix un nombre dins del rang [1,500]";
            string name = "Eric";
            int number = 0;
            Random rand = new Random();

            Console.WriteLine(MsgIntNome);
            Console.WriteLine(NameRang(ref name));
            Console.WriteLine(MsgIntNumber);
            Console.WriteLine(NumbreRang(ref number));
            Console.WriteLine(GenerateRandomNumber());
        }

        public static string NameRang(ref string name)
        {
            do
            {
                name = Console.ReadLine();
            } while (name.Length > 10);
            return name;
        }
        public static int NumbreRang(ref int number)
        {
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1 || number > 500);
            return number;
        }

        public static int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 100);
        }
    }
}