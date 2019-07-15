using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Common
{
    public class ServiceResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
