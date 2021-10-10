using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Models
{
    public class ImageSpecification
    {
        public byte[]  Image { get; set; }
        public int Size { get; set; }
        public int Radius{ get; set; }
        public List<Effect> Effects { get; set; }

    }
}
