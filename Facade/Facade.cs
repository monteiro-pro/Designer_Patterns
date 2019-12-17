using System;

namespace Facade
{
    public class Facade
    {
        private SubSistemaUm Um;
        private SubSistemaDois Dois;
        private SubSistemaTres Tres;

        public Facade()
        {
            this.Um = new SubSistemaUm();
            this.Dois = new SubSistemaDois();
            this.Tres = new SubSistemaTres();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMétodoA() ----");
            this.Um.MetodoUm();
            this.Dois.MetodoDois();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMétodoB() ----");
            this.Dois.MetodoDois();
            this.Tres.MetodoTres();
        }
    }
}
