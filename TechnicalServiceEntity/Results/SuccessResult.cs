using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceEntity.Results
{
    //base=result
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }

       // parametresiz olan bu
        public SuccessResult() : base(true)
        {

        }
    }
}
