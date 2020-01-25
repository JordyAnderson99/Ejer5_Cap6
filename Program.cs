using System;

namespace Ejer5_Cap6
{
    class Program
    {
        // Este Programa calcula el promedio de los sueldos de lso empleados de una empresa
        static void Main(string[] args)
        {
            float suma = 0.0f, promedio = 0.0f; //Variables para calcular el promedio
            int cantidad = 0; //variable para la cantidad
            int numero = 0; //variable para los numeros
            int j = 0; // variable para el ciclo de cantidad
            int i = 0; //variable para el ciclo de numeros
            string valor = "";
            int r = 0;

            //pedimos la cantidad de numeros
            Console.WriteLine("Cuantos Areas va ha Digitar");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            //creamos el arreglo
            int[][] resultado = new int[cantidad][];

            //capturamos la informacion
            for (j = 0; j < cantidad; j++)
            {
                Console.WriteLine("Digite el numero de Empleados del Area {0}", j);
                valor = Console.ReadLine();
                numero = Convert.ToInt32(valor);

                resultado[j] = new int[numero];
            }

            //obtenemos el sueldo de los empleados
            for (j = 0; j < cantidad; j++)
            {
                Console.WriteLine("\nArea {0}", j);
                for (i = 0; i < resultado[j].GetLength(0); i++)
                {
                    Console.WriteLine("Digita el Sueldo del Empleado {0}", i);
                    valor = Console.ReadLine();
                    resultado[j][i] = Convert.ToInt32(valor);


                }
            }

            //llamamos a la funcion
            Promedio(resultado, suma, promedio, j, i, cantidad, numero, valor);


        }

        //Procedemos a hacer la funcion
        static void Promedio(int[][] resultado, float suma = 0.0f, float promedio = 0.0f, int j = 0, int i = 0,
            int cantidad = 0, int numero = 0, string valor = "")
        {
            for (j = 0; j < cantidad; j++)
            {
                for (i = 0; i < resultado[j].GetLength(0); i++)
                {
                    suma += resultado[j][i];
                    promedio = suma / (cantidad * numero);

                }
            }
            Console.WriteLine("El Promedio Es: {0}", promedio);

        }
    }
}
