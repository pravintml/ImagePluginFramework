using ImagePluginFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Interfaces
{
    public interface IImagePluginService
    {
        public List<ImageResponse> ApplyEffect(List<ImageSpecification> imageSpecifications);
    }
}
