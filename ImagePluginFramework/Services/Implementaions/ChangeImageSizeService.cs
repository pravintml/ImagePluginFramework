using ImagePluginFramework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Implementaions
{

    public class ChangeImageSizeService : IChangeImageSizeService
    {
      
        public byte[] ChangeImageSize(byte[] image, int size)
        {          
                //Change image Size Logic
                return image;           
        }
    }
}
