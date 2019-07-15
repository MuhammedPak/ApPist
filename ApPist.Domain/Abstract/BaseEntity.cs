using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
