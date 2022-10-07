namespace Numeros_Romanos
{
    public class program
    {
        public static void Main()
        {
            double number,M, C, D, u;
            Console.WriteLine("Ingrese el numero");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 4000)
            {
                Console.WriteLine("No puede pasar de 4000");
            }
            M = Math.Truncate(number / 1000);
            C=Math.Truncate(number / 100)%10;
            D=Math.Truncate(number / 10)%10;
            u = Math.Truncate(number / 1)%10;

        }
    }
}