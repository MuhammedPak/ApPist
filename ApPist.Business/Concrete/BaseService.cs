using ApPist.Business.Abstract;
using ApPist.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Business.Concrete
{
    public class BaseService : IBaseService
    {
        public ServiceResult Result { get; set; }

        ServiceResult SetResultSuccess(string message)
        {
           return  this.Result = new ServiceResult { IsSuccess = true, Message = message };
        }

        void SetResultSuccess(string message, object data)
        {
            this.Result = new ServiceResult { IsSuccess = true, Message = message, Data = data };
        }

        void SetResultFail(string message, object data)
        {
            this.Result = new ServiceResult { IsSuccess = false, Message = message, Data = data };
        }

        void SetResultFail(string message)
        {
            this.Result = new ServiceResult { IsSuccess = false, Message = message };
        }
    }
}
