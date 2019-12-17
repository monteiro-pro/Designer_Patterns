using System.Collections.Generic;

namespace FlyWeight
{
    public class Fabrica_FlyWeight
    {
        private Dictionary<string, Tartaruga> lista_de_tartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (lista_de_tartarugas.ContainsKey(cor))
            {
                t = lista_de_tartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "vermelha":
                        t = new Vermelha();
                        break;
                    case "azul":
                        t = new Azul();
                        break;
                    case "verde":
                        t = new Verde();
                        break;
                    case "laranja":
                        t = new Laranja();
                        break;
                    default:
                        break;
                }

                lista_de_tartarugas.Add(cor, t);
            }

            return t;
        }
    }
}
