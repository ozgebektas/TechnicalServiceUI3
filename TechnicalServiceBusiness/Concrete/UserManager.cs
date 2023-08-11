using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceBusiness.Abstract;
using TechnicalServiceDataAccess.Abstract;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(AppUser user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(AppUser user)
        {
            _userDal.Add(user);
        }

        public AppUser GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
