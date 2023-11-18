using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*byte tiempo;
            Console.WriteLine("Decime cuanta/s hora/s estuvistes estacionado: ");
            tiempo = Convert.ToByte(Console.ReadLine());
            switch (tiempo)
            {
                case 1:
                    Console.WriteLine("El costo del estacionamiemto es de $5");
                    break;

                case 2:
                    Console.WriteLine("El costo del estacionamiemto es de $15");
                    break;
                    
                default: Console.WriteLine("El costo del estacionamiemto es de $40");
                    break;

            */
            float minutos;
            Console.WriteLine("Cuantos minutos estuvistes estacionado?");
            minutos = Convert.ToSingle(Console.ReadLine());
            if (minutos >= 0 && minutos <= 60)
                Console.WriteLine("Debes abonar $5");
            else
            {
                if (minutos > 60 && minutos <= 120)
                    Console.WriteLine("Debes abonar $15");

                else
                {
                    Console.WriteLine("Debes abonar $40");
                }
            }
        }
    }
}


