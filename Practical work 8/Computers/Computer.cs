using System.ComponentModel.DataAnnotations;

namespace Computers
{
    public struct Computer
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string ProcessorType { get; set; }
        public uint ProcessorSpeed { get; set; }
        public uint RAMSize { get; set; }
        public uint HardDriveCapacity { get; set; }
        public uint VideoCardMemory { get; set; }
        public uint Price { get; set; }
        public uint CopiesAvailable { get; set; }
    }
}
