using Facade.Interfaces;
using System;

namespace Facade.Modelos
{
    public class PalancaCambios : IPalancaCambios
    {
        private int _velocidadActual;

        #region IPalancaCambios Members

        public void InsertarVelocidad(int velocidad)
        {
            Console.WriteLine("Introduciendo marcha " + velocidad);
            _velocidadActual = velocidad;
        }       

        public int GetVelocidadActual()
        {
            return _velocidadActual;
        }

        #endregion
    }
}
