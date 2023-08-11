using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceDataAccess.Repository.Concrete;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class ServiceRequestManager : IServiceRequestServices
    {
        private readonly IServiceRequestDal _serviceRequestDal;

        public ServiceRequestManager(IServiceRequestDal serviceRequestDal)
        {
            _serviceRequestDal = serviceRequestDal;
        }

        public Task<ServiceRequest> TInsertAsync(ServiceRequest entity)
        {
            return _serviceRequestDal.InsertAsync(entity);
        }
        public void TDelete(ServiceRequest entity)
        {
            _serviceRequestDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(ServiceRequest entity)
        {
            return _serviceRequestDal.UpdateAsync(entity);
        }
        public Task<List<ServiceRequest>> TGetAllAsync()
        {
            return _serviceRequestDal.GetAllAsync();
        }

        public Task<ServiceRequest> TGetByIdAsync(Guid Id)
        {
            return _serviceRequestDal.GetByIdAsync(Id);
        }
        public Task<int> TSaveAsync()
        {
            return _serviceRequestDal.SaveAsync();
        }
    }
}
