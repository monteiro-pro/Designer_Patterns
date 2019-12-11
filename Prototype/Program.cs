using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente func_permanente = new FuncionarioPermanente
            {
                Nome = "João",
                Idade = 50,
                Tipo = "Permanente"
            };

            FuncionarioPermanente clone_func_permanente = (FuncionarioPermanente)func_permanente.Clone();
            clone_func_permanente.Nome = "Carlos";
            clone_func_permanente.Idade = 27;

            Console.WriteLine("** Detalhes do Funcionário Permanente ** \n");
            Console.WriteLine("Nome: " + func_permanente.Nome + "\n" + "Idade: " + func_permanente.Idade + "\n" + "Tipo: " + func_permanente.Tipo + "\n");

            Console.WriteLine("** Detalhes do Funcionário Permanente Clone ** \n");
            Console.WriteLine("Nome: " + clone_func_permanente.Nome + "\n" + "Idade: " + clone_func_permanente.Idade + "\n" + "Tipo: " + clone_func_permanente.Tipo + "\n");

            Console.ReadKey();
        }
    }
}
