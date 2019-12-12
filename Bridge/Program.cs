using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTV TV = new SmartTV();

            Console.WriteLine("SELECIONE O CANAL");
            Console.WriteLine("1. Filme \n2. Documentário \n3. Culinária");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    TV.canal_atual = new Filme();
                    break;
                case '2':
                        TV.canal_atual = new Documentario();
                        break;
                case '3':
                    TV.canal_atual = new Culinaria();
                        break;
            }

            Console.WriteLine();

            TV.ExibeCanalSintonizado();
            TV.PlayTV();

            Console.ReadKey();
        }
    }
}
