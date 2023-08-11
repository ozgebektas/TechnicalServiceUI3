using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceEntity.Results
{
    //temel voidler için başlangıç
   public interface IResult
    {
        bool Success { get; }//sadece okunacak
        string Message { get; }
    }
}
