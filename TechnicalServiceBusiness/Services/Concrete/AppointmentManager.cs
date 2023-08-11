using TechnicalServiceBusiness.Services.Abstract;
using TechnicalServiceDataAccess.Repository.Abstract;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Services.Concrete
{
    public class AppointmentManager :IAppointmentServices 
    {
        private readonly IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public Task<Appointment> TInsertAsync(Appointment entity)
        {
            return _appointmentDal.InsertAsync(entity);
        }
        public void TDelete(Appointment entity)
        {
            _appointmentDal.Delete(entity);
        }
        public Task<Guid> TUpdateAsync(Appointment entity)
        {
            return _appointmentDal.UpdateAsync(entity);
        }
        public Task<List<Appointment>> TGetAllAsync()
        {
            return _appointmentDal.GetAllAsync();
        }

        public Task<Appointment> TGetByIdAsync(Guid Id)
        {
            return _appointmentDal.GetByIdAsync(Id);
        }
        public Task<int> TSaveAsync()
        {
            return _appointmentDal.SaveAsync();
        }
    }
}
