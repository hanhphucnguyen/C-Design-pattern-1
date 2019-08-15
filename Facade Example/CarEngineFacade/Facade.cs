using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineFacade
{
    public class Facade
    {
        private AirFlowController _air;
        private FuelInjector _fuel;
        private Starter _start;
        private CoolingController _cool;
        private CatalyticConverter _cat;

        public Facade()
        {
            _air = new AirFlowController();
            _fuel = new FuelInjector();
            _start = new Starter();
            _cool = new CoolingController();
            _cat = new CatalyticConverter();
        }

        public void Start()
        {
            _air.TakeAir();
            _fuel.On();
            _fuel.Inject();
            _start.Start();
            _cool.Run();
            _cat.On();
        }

        public void Stop()
        {
            _fuel.Off();
            _cat.Off();
            _cool.Cool();
            _cool.Stop();
            _air.Off();
        }
    }
}
