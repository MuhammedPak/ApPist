using ApPist.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Concrete
{
    public class Image : BaseEntity
    {
        public string Path { get; set; }

        public List<SliderImage> SliderImages { get; set; }
    }
}
