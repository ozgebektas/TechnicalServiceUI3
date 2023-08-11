using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class DeviceManager : IDeviceServices
    {
        private readonly IDeviceDal _deviceDal;

        public DeviceManager(IDeviceDal deviceDal)
        {
            _deviceDal = deviceDal;
        }

        public Task<Device> TInsertAsync(Device entity)
        {
            return _deviceDal.InsertAsync(entity);
        }
        public void TDelete(Device entity)
        {
            _deviceDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(Device entity)
        {
            return _deviceDal.UpdateAsync(entity);
        }
        public Task<List<Device>> TGetAllAsync()
        {
            return _deviceDal.GetAllAsync();
        }

        public Task<Device> TGetByIdAsync(Guid Id)
        {
            return _deviceDal.GetByIdAsync(Id);
        }
        public Task<int> TSaveAsync()
        {
            return _deviceDal.SaveAsync();
        }
    }
}
