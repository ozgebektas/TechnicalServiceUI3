using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceDataAccess.Repository.Concrete;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class CustomerManager : ICustomerServices
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Task<Customer> TInsertAsync(Customer entity)
        {
            return _customerDal.InsertAsync(entity);
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(Customer entity)
        {
            return _customerDal.UpdateAsync(entity);
        }
        public Task<List<Customer>> TGetAllAsync()
        {
            return _customerDal.GetAllAsync();
        }

        public Task<Customer> TGetByIdAsync(Guid Id)
        {
            return _customerDal.GetByIdAsync(Id);
        }
        public Task<int> TSaveAsync()
        {
            return _customerDal.SaveAsync();
        }
    }
}
