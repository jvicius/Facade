using Facade.Interfaces;
using System;

namespace Facade.Modelos
{
    public class Embrague : IEmbrague
    {
        #region IEmbrague Members

        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }

        #endregion
    }
}
