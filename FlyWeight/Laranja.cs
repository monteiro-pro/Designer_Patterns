using System;

namespace FlyWeight
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            this.Condicao = "Tartaruga dentro do casco, ";
            this.Acao = "Rodando no chão - ";
        }
        public override void Mostrar(string qualCor)
        {
            this.Cor = qualCor;
            Console.WriteLine(Condicao + Acao + Cor.ToUpper());
        }
    }
}
