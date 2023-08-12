using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceBusiness.Abstract;
using TechnicalServiceEntity.Dtos;
using TechnicalServiceEntity.Entity;
using TechnicalServiceEntity.Results;
using TechnicalServiceEntity.Security.Hashing;
using TechnicalServiceEntity.Security.JWT;

namespace TechnicalServiceBusiness.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AppUser> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new AppUser
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<AppUser>(user, "Kayıt oldu");
        }

        public IDataResult<AppUser> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<AppUser>("kullanıcı bulunamadı");
            }

            //if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordSalt))
            //{
            //    return new ErrorDataResult<AppUser>("Parola hatası");
            //}

            return new SuccessDataResult<AppUser>(userToCheck, "başarılı giriş");
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult("kullanıcı mevcut");
            }
            return new SuccessResult();
        }

       
        public IDataResult<AccessToken> CreateAccessToken(AppUser user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Token Oluşturuldu");
        }
    }
}
