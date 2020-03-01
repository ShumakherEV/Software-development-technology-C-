using System.Diagnostics;

namespace TransportSystem.Transports
{
    public class Motorcycle : Transport
    {
        /// <summary>
        /// Carrying capacity in kg
        /// </summary>
        public int CarryingCapacity { get; set; }
        /// <summary>
        /// Sidecar availability
        /// </summary>
        public bool Sidecar { get; set; }

        public Motorcycle() { }

        /// <summary>
        /// Get carrying capacity in kg
        /// </summary>
        public override int GetCarryingCapacity()
        {
            Trace.WriteLine("Trace Information-Truck.GetCarryingCapacity Starting");
            Trace.Indent();
            Debug.WriteLineIf(!Sidecar, "Motorcycle without sidecar, carrying capacity is 0");
            Trace.Unindent();
            return Sidecar? CarryingCapacity: 0;
        }

        /// <summary>
        /// Print full information about motorcycle
        /// </summary>
        public override void PrintInfo()
        {
            Trace.WriteLine("Trace Information-Motorcycle.PrintInfo Starting");
            var sidecar = Sidecar ? "with sidecar" : "without sidecar";
            Reporter.Write($"Motorcycle {Make} {RegistrationPlate} {MaxSpeed}km/h {GetCarryingCapacity()}kg {sidecar}");
        }
    }
}
