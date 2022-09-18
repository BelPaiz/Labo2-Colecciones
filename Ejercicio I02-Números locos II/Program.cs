using System.Collections;

namespace Ejercicio_I02_Números_locos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] nums = new int[20];
            int[] buffer = new int[20];

            Random r = new Random();
            List<int> listaNumeros = new List<int>();
            Stack <int> pilaNumeros = new Stack<int>();
            Queue<int> colaNumeros = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                numero = r.Next(-100, 100);
                if (numero != 0)
                {
                    listaNumeros.Add(numero);
                    pilaNumeros.Push(numero);
                    colaNumeros.Enqueue(numero);
                }
            }
            #region MOSTRAR SIN ORDENAR
            Console.WriteLine("Asi quedo la lista: \n");
            foreach (int num in listaNumeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Asi quedo la pila: \n");
            foreach (int num in pilaNumeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Asi quedo la cola: \n");
            foreach (int num in colaNumeros)
            {
                Console.WriteLine(num);
            }
            #endregion

            #region POSITIVOS ORDEN DESCENDIENTE

            Console.WriteLine("numeros positivos ordenados en forma decreciente LISTA: \n");

            listaNumeros.Sort(CompararDecreciente);
            foreach (int num in listaNumeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
            }
            nums = pilaNumeros.ToArray();

            Array.Sort(nums);
            pilaNumeros.Clear();
            Console.WriteLine("numeros positivos ordenados en forma decreciente PILA: \n");
            for (int i = 0; i < 20; i++)
            {
                pilaNumeros.Push(nums[i]);
            }
            foreach (int num in pilaNumeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
                    
            }
            buffer = colaNumeros.ToArray();
            Array.Sort(buffer);
            colaNumeros.Clear();
            Console.WriteLine("numeros positivos ordenados en forma decreciente COLA: \n");
            for (int i = 19; i >= 0; i--)
            {
                colaNumeros.Enqueue(nums[i]);
            }
            foreach (int num in colaNumeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion
            #region NEGATIVOS ORDEN ASCENDENTE

            Console.WriteLine("numeros negativos ordenados en forma ascendente LISTA: \n");

            listaNumeros.Sort(CompararCreciente);
            foreach (int num in listaNumeros)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }
            }

            nums = pilaNumeros.ToArray();

            Array.Reverse(nums);
            pilaNumeros.Clear();

            Console.WriteLine("numeros negativos ordenados en forma ascendente PILA: \n");
            for (int i = 19; i >= 0; i--)
            {
                pilaNumeros.Push(nums[i]);
            }
            foreach (int num in pilaNumeros)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }

            }
            buffer = colaNumeros.ToArray();
            Array.Sort(buffer);
            colaNumeros.Clear();
            Console.WriteLine("numeros negativos ordenados en forma ascendente COLA: \n");
            for (int i = 0; i < 20; i++)
            {
                colaNumeros.Enqueue(nums[i]);
            }
            foreach (int num in colaNumeros)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

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