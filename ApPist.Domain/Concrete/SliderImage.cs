using ApPist.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApPist.Domain.Concrete
{
    public class SliderImage:BaseEntity
    {
        public int SliderId { get; set; }
        public Slider Silder{ get; set; }

        public int ImageId{ get; set; }
        public Image Image{ get; set; }

        public string Slogan { get; set; }
        public bool IsActive { get; set; }
    }
}
