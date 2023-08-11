using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class TechnicianManager : ITechnicianServices
    {
        private readonly ITechnicianDal _technicianDal;

        public TechnicianManager(ITechnicianDal technicianDal)
        {
            _technicianDal = technicianDal;
        }

        public Task<Technician> TInsertAsync(Technician entity)
        {
            return _technicianDal.InsertAsync(entity);
        }
        public void TDelete(Technician entity)
        {
            _technicianDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(Technician entity)
        {
            return _technicianDal.UpdateAsync(entity);
        }
        public Task<List<Technician>> TGetAllAsync()
        {
            return _technicianDal.GetAllAsync();
        }

        public Task<Technician> TGetByIdAsync(Guid Id)
        {
            return _technicianDal.GetByIdAsync(Id);
        }
        public Task<int> TSaveAsync()
        {
            return _technicianDal.SaveAsync();
        }
    }
}
