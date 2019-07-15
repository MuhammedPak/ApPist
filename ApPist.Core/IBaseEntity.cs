using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Core
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreateTime { get; set; }
        bool IsDeleted { get; set; }
    }
}
