using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceDataAccess.Abstract
{
    public interface IUserDal:IGenericDal<AppUser>
    {
        List<OperationClaim> GetClaims(AppUser user);
        
    }
}
