using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Interfaces
{
    public interface IChangeImageSizeService
    {
        public Byte[] ChangeImageSize(Byte[] image,int size);
    }
}
