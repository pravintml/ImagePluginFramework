﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Interfaces
{
    public interface IChangeImageRadiusService
    {
        public Byte[] ChangeImageRadius(Byte[] image,int radius);
    }
}
