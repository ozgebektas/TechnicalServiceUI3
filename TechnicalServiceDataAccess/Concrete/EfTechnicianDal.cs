using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceDataAccess.Abstract;
using TechnicalServiceDataAccess.Repository;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceDataAccess.Concrete
{
    public class EfTechnicianDal : GenericRepository<Technician
        , EfContext>, ITechnicianDal
    {

    }
}
