
namespace ejercicios1
{
    public class program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doblado;

            Console.WriteLine("Por favor ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine($" El resultado de la operación es: {resultado}");

        }
    }
}

