using System.Diagnostics;

namespace TransportSystem.Transports
{
    public class Truck : Transport
    {
        /// <summary>
        /// Carrying capacity in kg
        /// </summary>
        public int CarryingCapacity { get; set; }
        /// <summary>
        /// Trailer availability
        /// </summary>
        public bool Trailer { get; set; }

        public Truck() { }

        /// <summary>
        /// Get carrying capacity in kg
        /// </summary>
        public override int GetCarryingCapacity()
        {
            Trace.WriteLine("Trace Information-Truck.GetCarryingCapacity Starting");
            Trace.Indent();
            Debug.WriteLineIf(Trailer, "Truck with trailer, carrying capacity doubled");
            Trace.Unindent();
            return Trailer? CarryingCapacity*2 : CarryingCapacity;
        }

        /// <summary>
        /// Print full information about truck
        /// </summary>
        public override void PrintInfo()
        {
            Trace.WriteLine("Trace Information-Truck.PrintInfo Starting");
            var trailer = Trailer ? "with trailer" : "without trailer";
            Reporter.Write($"Truck {Make} {RegistrationPlate} {MaxSpeed}km/h {GetCarryingCapacity()}kg {trailer}");
        }
    }
}
