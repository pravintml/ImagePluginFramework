using ImagePluginFramework.Models;
using ImagePluginFramework.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePluginFramework.Controllers.Api
{
    [ApiController]
    [Route("api/ImagePlugin")]
    public class ImagePluginController : Controller
    {
        private readonly IImagePluginService _imagePluginService;
        private readonly ILogger<ImagePluginController> _logger;

        public ImagePluginController(IImagePluginService imagePluginService, ILogger<ImagePluginController> logger)
        {
            _imagePluginService = imagePluginService;
            _logger = logger;
        }

        [HttpPost]
        [Route("ApplyEffect")]
        public IActionResult ApplyEffect(List<ImageSpecification> imageSpecifications)
        {
            try
            {
                _logger.LogInformation("ApplyEffect Called - API");
                List<ImageResponse> imageResponses = _imagePluginService.ApplyEffect(imageSpecifications);
                return Ok(imageResponses);
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
