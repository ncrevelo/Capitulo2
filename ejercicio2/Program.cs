namespace ejercicio2
{
    public class clase
    {


        public static void Main()
        {
            int nume1;
            int nume2;
            int nume3;
            int nume4;

            int sum;
            double media;
            int produc;

            Console.WriteLine("Ingrese el primer numero");
            nume1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            nume2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            nume3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero");
            nume4 = int.Parse(Console.ReadLine());

            produc = nume1 * nume2 * nume3 * nume4;
            sum = nume1 + nume2 + nume3 + nume4;
            media = sum / 4;

            Console.WriteLine($"El resultado de la suma es {sum}, El producto es {produc}, y la media{media}");
        }
    }
}