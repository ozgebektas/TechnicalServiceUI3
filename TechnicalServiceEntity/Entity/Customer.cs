using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class Customer :IEntity
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<Device> Devices { get; set; }        
        public List<ServiceRequest> ServiceRequests { get; set; } 
    }
}
