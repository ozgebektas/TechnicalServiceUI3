using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;
using TechnicalServiceEntity.Results;
using TechnicalServiceEntity.Security.JWT;

namespace TechnicalServiceBusiness.Abstract
{
    public interface IAuthService
    {
        IDataResult<AppUser> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<AppUser> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(AppUser user);
    }
}

