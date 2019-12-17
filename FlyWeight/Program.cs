using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica_FlyWeight fabrica = new Fabrica_FlyWeight();

            Tartaruga tartaruga;
            string cor = string.Empty;

            Console.WriteLine("---# FRABRICA DE TARTARUGAS #---");

            while (true)
            {
                Console.Write("\nQual tartaruga você quer enviar para a tela: ");
                cor = Console.ReadLine();
                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostrar(cor);

                Console.WriteLine();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
