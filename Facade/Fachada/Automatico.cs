using Facade.Interfaces;

namespace Facade.Fachada
{
    public class Automatico
    {
        private readonly IEmbrague _embrague;
        private readonly IAcelerador _acelerador;
        private readonly IPalancaCambios _palancaCambios;

        public Automatico(IEmbrague embrague, IAcelerador acelerador, IPalancaCambios palancaCambios)
        {
            _embrague = embrague;
            _acelerador = acelerador;
            _palancaCambios = palancaCambios;
        }

        public void AumentarMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
         
            if (_palancaCambios.GetVelocidadActual() < 5)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() + 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }

        public void ReducirMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
          
            if (_palancaCambios.GetVelocidadActual() > 1)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() - 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }
    }
}
