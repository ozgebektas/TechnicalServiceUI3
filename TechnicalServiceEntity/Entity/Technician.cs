using System.ComponentModel.DataAnnotations;
using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class Technician:IEntity
    {
        [Key]
        public int TechnicianID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
