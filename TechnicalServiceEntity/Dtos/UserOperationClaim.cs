using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Dtos
{
    public class UserOperationClaim 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
