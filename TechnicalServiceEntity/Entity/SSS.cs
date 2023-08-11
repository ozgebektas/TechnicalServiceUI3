using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceCore.Entities;
using TechnicalServiceEntity.Entities;

namespace TechnicalServiceEntity.Entity
{
    public class SSS:IEntity
    {
        public int SSSID { get; set; }
        public string Question { get; set; }
        public string  Answer { get; set; }
        public string? Answer2 { get; set; }
    }
}
