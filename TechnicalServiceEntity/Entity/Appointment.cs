
using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class Appointment:IEntity
    {
        public int AppointmentID { get;set; }
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }

        public List<Customer> Customers { get; set; }
        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }
    }
}
