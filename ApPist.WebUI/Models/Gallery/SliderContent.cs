using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApPist.WebUI.Models.Gallery
{
    public class SliderContent
    {
        public string Slogan { get; set; }
        public int ImageId { get; set; }
        public bool IsActive { get; set; }
        public int SliderId { get; set; }
    }
}
