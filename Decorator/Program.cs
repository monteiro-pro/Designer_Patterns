using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Pedro", "Tormenta de Espadas", 4);
            livro.Exibe();

            Video video = new Video("Monteiro", "Portfólio - Game Designer", 20, 1);
            video.Exibe();

            // Emprestando Item
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Felipe");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

            emprestado.DevolverItem("Felipe");
            emprestado.EmprestarItem("Jorge");

            emprestado.Exibe();

            Console.ReadKey();
        }
    }
}
