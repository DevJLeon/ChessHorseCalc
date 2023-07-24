using System;

namespace AjedrezCaballo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la posición de la ficha de ajedrez (caballo).");
            Console.Write("Columna (letra de 'a' a 'h'): ");
            char columna = char.Parse(Console.ReadLine().ToLower());
            Console.Write("Fila (número de '1' a '8'): ");
            int fila = int.Parse(Console.ReadLine());

            if (ValidarPosicion(columna, fila))
            {
                Console.WriteLine("\nMovimientos posibles del caballo:");
                MostrarMovimientosCaballo(columna, fila);
            }
            else
            {
                Console.WriteLine("Posición de ficha inválida.");
            }

            Console.ReadKey();
        }

        static bool ValidarPosicion(char columna, int fila)
        {
            return columna >= 'a' && columna <= 'h' && fila >= 1 && fila <= 8;
        }

        static void MostrarMovimientosCaballo(char columna, int fila)
        {
            int[,] movimientos = {
                { 2, 1 },
                { 1, 2 },
                { -1, 2 },
                { -2, 1 },
                { -2, -1 },
                { -1, -2 },
                { 1, -2 },
                { 2, -1 }
            };

            for (int i = 0; i < movimientos.GetLength(0); i++)
            {
                int nuevaColumna = columna - 'a' + movimientos[i, 0];
                int nuevaFila = fila + movimientos[i, 1];

                if (ValidarPosicion((char)(nuevaColumna + 'a'), nuevaFila))
                {
                    Console.WriteLine($"{(char)(nuevaColumna + 'a')}{nuevaFila}");
                }
            }
        }
    }
}