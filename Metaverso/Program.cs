using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            int numero;
            int x;
            Console.WriteLine(sistema.Saludo("Es multiplo de 3 por lo que es META"));
            Console.WriteLine(sistema.Saludo("Es multiplo de 5 por lo que es VERSO"));
            Console.WriteLine(sistema.Saludo("Es multiplo de 3 y 5 por lo que es METAVERSO"));
        }
    }
}
