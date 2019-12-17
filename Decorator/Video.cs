using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

        public Video(string diretor, string titulo, int minutosDuracao, int numerosCopias)
        {
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.MinutosDuracao = minutosDuracao;
            this.NumeroCopias = numerosCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVídeo ----");
            Console.WriteLine("Diretor: " + Diretor);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Minutos de Duração: " + MinutosDuracao);
            Console.WriteLine("# Cópias: " + NumeroCopias);
        }
    }
}
