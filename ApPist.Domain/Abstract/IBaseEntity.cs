using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Abstract
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreateTime { get; set; }
        bool IsDeleted { get; set; }
    }
}
