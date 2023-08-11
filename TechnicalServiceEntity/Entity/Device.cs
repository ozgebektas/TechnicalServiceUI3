using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class Device:IEntity
    {
        public int DeviceID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
