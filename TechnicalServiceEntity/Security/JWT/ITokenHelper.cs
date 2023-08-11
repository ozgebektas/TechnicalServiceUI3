using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceEntity.Security.JWT;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceEntity.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(AppUser user, List<OperationClaim> operationClaims);
    }
}
