using ImagePluginFramework.Models;
using ImagePluginFramework.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Implementaions
{
    public class AppSettingService: IAppSettingService
    {
        private readonly IConfiguration _configuration;
       
        public List<Plugin> GetPluginsFromAppSettings()
        {            
                List<Plugin> plugins = new();
                plugins=_configuration.GetSection("Plugins").Get<List<Plugin>>();
                return plugins;            
        }
    }
}
