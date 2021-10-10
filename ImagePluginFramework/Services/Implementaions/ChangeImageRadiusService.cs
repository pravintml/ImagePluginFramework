using ImagePluginFramework.Services.Interfaces;
using System;

namespace ImagePluginFramework.Services.Implementaions
{
    public class ChangeImageRadiusService : IChangeImageRadiusService
    {
       
        public byte[] ChangeImageRadius(Byte[] image, int radius)
        {
                //Change image Radius Logic
                return image;           
        }
    }
}
