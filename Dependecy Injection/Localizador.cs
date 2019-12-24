using System;

namespace Dependecy_Injection
{
    public class Localizador
    {
        private static IObjetoEndereco _localizador;

        //public Localizador(IObjetoEndereco obj)
        //{
        //    if (_localizador == null)
        //    {
        //        return _localizador = new Localizador(obj);
        //    }
        //}

        public static IObjetoEndereco getEndereco()
        {
            return _localizador;
        }
    }
}
