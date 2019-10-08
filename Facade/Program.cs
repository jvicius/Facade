using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Fachada;
using Facade.Interfaces;
using Facade.Modelos;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo Manual

            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            Console.WriteLine("A primera");
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.InsertarVelocidad(1);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
            Console.WriteLine();

            Console.WriteLine("De primera a segunda");
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.InsertarVelocidad(2);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
            Console.WriteLine();

            Console.WriteLine("De segunda a tercera");
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.InsertarVelocidad(3);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();
            Console.WriteLine();


            Console.WriteLine("De tercera a segunda");
            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.InsertarVelocidad(2);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();

            Console.ReadKey();
        }
    }
}
