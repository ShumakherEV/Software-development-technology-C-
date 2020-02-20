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
            return Trailer? CarryingCapacity*2 : CarryingCapacity;
        }

        /// <summary>
        /// Print full information about truck
        /// </summary>
        public override void PrintInfo()
        {
            var trailer = Trailer ? "with trailer" : "without trailer";
            Reporter.Write($"Truck {Make} {RegistrationPlate} {MaxSpeed}km/h {GetCarryingCapacity()}kg {trailer}");
        }
    }
}
