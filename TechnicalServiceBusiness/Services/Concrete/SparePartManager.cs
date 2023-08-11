using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class SparePartManager : ISparePartServices
    {
        private readonly ISparePartDal _sparePartDal;

        public SparePartManager(ISparePartDal sparePartDal)
        {
            _sparePartDal = sparePartDal;
        }

        public Task<SparePart> TInsertAsync(SparePart entity)
        {
            return _sparePartDal.InsertAsync(entity);
        }
        public void TDelete(SparePart entity)
        {
            _sparePartDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(SparePart entity)
        {
            return _sparePartDal.UpdateAsync(entity);
        }
        public Task<List<SparePart>> TGetAllAsync()
        {
            return _sparePartDal.GetAllAsync();
        }

        public Task<SparePart> TGetByIdAsync(Guid Id)
        {
            return _sparePartDal.GetByIdAsync(Id);
        }

        public Task<int> TSaveAsync()
        {
            return _sparePartDal.SaveAsync();
        }
    }
}
