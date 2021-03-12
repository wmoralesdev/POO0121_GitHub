using System;

namespace CollaborativeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gualterpistola");
        }

        // TODO: Estudiante A -> Crear funcion para leer datos desde teclado
        static string ReadFromConsole()
        {
            return Console.ReadLine();
        }

        // TODO: Estudiante B -> Crear una funcion que reciba un string
        // y verificar si tiene cantidad par de letras (caracteres)
        static bool LenghtIsEven(string word)
        {
            return word.Length % 2 == 0;
        }

        // TODO: Yo -> Crear una funcion para determinar si un numero es par
    }
}
