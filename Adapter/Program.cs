using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2019 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine("### ROBO ###");
            R2D2.AtaqueRoboInimigo();
            R2D2.AndarFrente();
            R2D2.ReagirContraHumano("Pedro");

            Console.WriteLine("### TANQUE ###");
            rx2019.Armado();
            rx2019.Movimenta();
            rx2019.Pilota("Carlos");

            Console.WriteLine("### ROBO ADAPTER ###");
            robo_adapter.Armado();
            robo_adapter.Movimenta();
            robo_adapter.Pilota("José");

            Console.ReadKey();
        }
    }
}
