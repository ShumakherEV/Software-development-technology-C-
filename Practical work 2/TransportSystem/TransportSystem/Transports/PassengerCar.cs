using System.Diagnostics;

namespace TransportSystem.Transports
{
    public class PassengerCar: Transport
    {
        /// <summary>
        /// Carrying capacity in kg
        /// </summary>
        public int CarryingCapacity { get; set; }

        public PassengerCar() { }

        /// <summary>
        /// Get carrying capacity in kg
        /// </summary>
        public override int GetCarryingCapacity()
        {
            Trace.WriteLine("Trace Information-PassengerCar.GetCarryingCapacity Starting");
            return CarryingCapacity;
        }

        /// <summary>
        /// Print full information about passenger car
        /// </summary>
        public override void PrintInfo()
        {
            Trace.WriteLine("Trace Information-PassengerCar.PrintInfo Starting");
            Reporter.Write($"Passenger Car {Make} {RegistrationPlate} {MaxSpeed}km/h {GetCarryingCapacity()}kg");
        }
    }
}
