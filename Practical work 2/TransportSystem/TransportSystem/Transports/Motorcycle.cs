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
            return Sidecar? CarryingCapacity: 0;
        }

        /// <summary>
        /// Print full information about motorcycle
        /// </summary>
        public override void PrintInfo()
        {
            var sidecar = Sidecar ? "with sidecar" : "without sidecar";
            Reporter.Write($"Motorcycle {Make} {RegistrationPlate} {MaxSpeed}km/h {GetCarryingCapacity()}kg {sidecar}");
        }
    }
}
