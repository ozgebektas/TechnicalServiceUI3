using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class ServiceRequest:IEntity
    {
        public int ServiceRequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestDescription { get; set; }
        public string Status { get; set; }

        public List<Device> Devices { get; set; }     
        public List<Customer> Customers { get; set; } 

        public List<SparePart> SpareParts { get; set; }
    }
}

