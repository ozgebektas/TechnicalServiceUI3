using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(AppUser user);
        void Add(AppUser user);
        AppUser GetByMail(string email);

    }
}
