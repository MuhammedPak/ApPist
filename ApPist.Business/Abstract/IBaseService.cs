using ApPist.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Business.Abstract
{
    public interface IBaseService
    {
        ServiceResult Result { get; set; }
    }
}
