using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Livro(string autor, string titulo, int numeroCopias)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.NumeroCopias = numeroCopias;
        }
        public override void Exibe()
        {
            Console.WriteLine("\nLivro ----");
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("#Cópias: " + NumeroCopias);
        }
    }
}
