using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("SubZero | Liu Kang | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Escolha sue Personagem");
            string escolha = Console.ReadLine();
            Console.WriteLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine("Você Vai Jogar Com: ");
            personagem.Escolhido();

            Console.ReadKey();

        }
    }
}
