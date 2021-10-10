using ImagePluginFramework.Models;
using ImagePluginFramework.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Services.Implementaions
{
    public class ImagePluginService : IImagePluginService
    {
        private readonly IAppSettingService _appSettingService;
        private readonly IChangeImageSizeService _changeImageSizeService;
        private readonly IChangeImageRadiusService _changeImageRadiusService;
        private readonly IApplyEffectService _applyEffectService;
        private readonly ILogger<ImagePluginService> _logger;


        public ImagePluginService(IAppSettingService appSettingService, IChangeImageSizeService changeImageSizeService, IChangeImageRadiusService changeImageRadiusService, IApplyEffectService applyEffectService, ILogger<ImagePluginService> logger)
        {
            _appSettingService = appSettingService;
            _changeImageSizeService = changeImageSizeService;
            _changeImageRadiusService = changeImageRadiusService;
            _applyEffectService = applyEffectService;
            _logger = logger;
        }

        public List<ImageResponse> ApplyEffect(List<ImageSpecification> imageSpecifications)
        {
            try
            {
                _logger.LogInformation("ApplyEffect Called - Implementation");

                List<Plugin> plugins = _appSettingService.GetPluginsFromAppSettings();
                List<ImageResponse> imageResponses = new();

                foreach (ImageSpecification imageSpecification in imageSpecifications)
                {
                    if (imageSpecification.Size > 0)
                    {
                        imageSpecification.Image = _changeImageSizeService.ChangeImageSize(imageSpecification.Image, imageSpecification.Size);
                    }

                    if (imageSpecification.Radius > 0)
                    {
                        imageSpecification.Image = _changeImageRadiusService.ChangeImageRadius(imageSpecification.Image, imageSpecification.Radius);

                    }

                    foreach (Effect effect in imageSpecification.Effects)
                    {
                        if (plugins.Any(p=> p.Description==effect.Plugin.Description))//Checking Whether Plugin Confingured in AppSettings
                        {
                            imageSpecification.Image = _applyEffectService.ApplyEffect(imageSpecification.Image, effect);
                        }
                    }

                    imageResponses.Add(new ImageResponse { Image = imageSpecification.Image });
                }

                return imageResponses;
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                _logger.LogError(ex.StackTrace);
                return null;
            }
        }
        
               
    }
}
