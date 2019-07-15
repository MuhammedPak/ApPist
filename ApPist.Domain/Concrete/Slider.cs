using ApPist.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Concrete
{
    public class Slider : BaseEntity
    {
        public string Page { get; set; }
        public List<SliderImage>  SliderImages { get; set; }
    }
}
