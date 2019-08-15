using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            //// without the facade, starting the engine involves creating all the objects
            //var airflow = new AirFlowController();
            //var fuel = new FuelInjector();
            //var start = new Starter();
            //var cool = new CoolingController();
            //var cat = new CatalyticConverter();

            //// then performing all the steps in the correct order
            //airflow.TakeAir();
            //fuel.On();
            //fuel.Inject();
            //start.Start();
            //cool.Run();
            //cat.On();

            //// and shut down also requires steps in the correct order
            //fuel.Off();
            //cat.Off();
            //cool.Cool();
            //cool.Stop();
            //airflow.Off();

            // with the Facade, all creation is handled internally
            var facade = new Facade();

            // as is starting
            facade.Start();

            // and stopping
            facade.Stop();
        }
    }
}
