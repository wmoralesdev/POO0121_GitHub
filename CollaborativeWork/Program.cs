using System;

namespace CollaborativeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esta linea esta incorrecta, corrijo a GualterPistola
            Console.WriteLine("GualterPistola");
        }

        // TODO: Estudiante A -> Crear funcion para leer datos desde teclado
        static string ReadFromConsole()
        {
            return Console.ReadLine();
        }

        // TODO: Estudiante B -> Crear una funcion que reciba un string
        // y verificar si tiene cantidad par de letras (caracteres)


        // TODO: Yo -> Crear una funcion para determinar si un numero es par
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
