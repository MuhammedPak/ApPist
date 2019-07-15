using ApPist.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApPist.WebUI.Models.Gallery
{
    public class ImageModel
    {
       public List<Image> Images{ get; set; }
       public SliderContent SliderContent{ get; set; }
       
    }
}
