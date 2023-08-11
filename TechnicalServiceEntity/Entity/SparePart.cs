using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class SparePart:IEntity
    {
        public int SparePartID { get; set; }
        public string PartName { get; set; }
        public string PartCode { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public List<ServiceRequest> ServiceRequests { get; set; }
    }
}

