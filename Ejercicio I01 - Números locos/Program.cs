namespace Ejercicio_I01___Números_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            List<int> numeros = new List<int>();

            Random r = new Random();

            for(int i = 0; i < 20; i++)
            {
                numero= r.Next(-100, 100);
                if (numero != 0)
                {
                    numeros.Add(numero);
                }
            }
            Console.WriteLine("Asi quedo la lista: \n");
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("numeros positivos ordenados en forma decreciente: \n");

            numeros.Sort(CompararDecreciente);
            foreach (int num in numeros)
            {
                if(num > 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("numeros negativos ordenados en forma creciente: \n");

            numeros.Sort(CompararCreciente);

            foreach (int num in numeros)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }
            }

            
        }
        public static int CompararCreciente(int a, int b)
        {
            return a - b;
        }
        public static int CompararDecreciente(int a, int b)
        {
            return b - a;
        }
    }
}