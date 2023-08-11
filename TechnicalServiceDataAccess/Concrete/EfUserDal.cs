using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceDataAccess.Abstract;
using TechnicalServiceDataAccess.Repository;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceDataAccess.Concrete
{
    public class EfUserDal : GenericRepository<AppUser,EfContext>, IUserDal
    {

        public List<OperationClaim> GetClaims(AppUser user)
        {
            using (var context = new EfContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
