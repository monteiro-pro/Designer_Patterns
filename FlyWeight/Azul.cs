using System;

namespace FlyWeight
{
    public class Azul : Tartaruga
    {
        public Azul()
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
