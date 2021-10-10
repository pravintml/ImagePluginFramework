using ImagePluginFramework.Models;
using ImagePluginFramework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Implementaions
{
    public class ApplyEffectService : IApplyEffectService
    {
        public byte[] ApplyEffect(byte[] image, Effect effect)
        {
                //Apply Effect Logic based in passed effect
                return image;
        }
    }
}
