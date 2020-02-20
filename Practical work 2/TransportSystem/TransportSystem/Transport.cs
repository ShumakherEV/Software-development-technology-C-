using System.Xml.Serialization;
using TransportSystem.Transports;

namespace TransportSystem
{
    /// <summary>
    /// Abstract class describing transport
    /// </summary>
    [XmlInclude(typeof(PassengerCar)), XmlInclude(typeof(Motorcycle)), XmlInclude(typeof(Truck))]
    public abstract class Transport
    {
        /// <summary>
        /// Car make
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Registration Plate
        /// </summary>
        public string RegistrationPlate { get; set; }
        /// <summary>
        /// Maximum possible speed in km/h
        /// </summary>
        public int MaxSpeed { get; set; }

        /// <summary>
        /// Interface for output
        /// </summary>
        [XmlIgnore]
        public IReporter Reporter { get; set; }

        public Transport() { }

        /// <summary>
        /// Print full information about transport
        /// </summary>
        public abstract void PrintInfo();

        /// <summary>
        /// Get carrying capacity in kg
        /// </summary>
        public abstract int GetCarryingCapacity();
    }
}
