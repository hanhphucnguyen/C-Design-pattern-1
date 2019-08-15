namespace VehicleBuilder
{
    public class Director
    {
        public Vehicle BuildVehicle(IVehicleBuilder builder)
        {
            builder.BuildVehicle();
            builder.BuildDoors();
            builder.BuildEngine();
            builder.BuildSeats();
            builder.BuildWheels();
            return builder.GetVehicle();
        }
    }
}