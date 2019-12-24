using System;

namespace Dependecy_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Injeção de Dependência no Construtor
            EnderecoA endA = new EnderecoA();
            endA.Rua = "Rua Endereço A";
            endA.Numero = 1;

            EnderecoB endB = new EnderecoB();
            endB.Cidade = "Cidade Endereço B";
            endB.UF = "UF Endereço B";

            Empresa empresaA = new Empresa(endA);
            Empresa empresaB = new Empresa(endB);
            //########################################

            //## Injeação de Dependência no GetSet
            Empresa2 empresa2A = new Empresa2();
            Empresa2 empresa2B = new Empresa2();

            empresa2A.Endereco = endA;
            empresa2A.Endereco = endB;
            //####################################

            //## Injeção de Denpendência com Interface
            Empresa3 empresa3A = new Empresa3();
            Empresa3 empresa3B = new Empresa3();

            empresa3A.setEndereco(endA);
            empresa3B.setEndereco(endB);
            //########################################

            //## Injeção de Dependência com Localizador
            Empresa4 empresa4A = new Empresa4();
            Empresa4 empresa4B = new Empresa4();

            empresa4A.Endereco = endA;
            empresa4B.Endereco = endB;

            Console.ReadKey();
        }
    }
}
 