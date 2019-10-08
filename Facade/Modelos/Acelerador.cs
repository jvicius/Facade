using Facade.Interfaces;
using System;

namespace Facade.Modelos
{
    public class Acelerador : IAcelerador
    {
        #region IAcelerador Members

        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }

        #endregion
    }
}
