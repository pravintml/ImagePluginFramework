using ImagePluginFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Interfaces
{
    public interface IApplyEffectService
    {
        public Byte[] ApplyEffect(Byte[] image, Effect effect);
    }
}
