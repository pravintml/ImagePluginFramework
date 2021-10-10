using ImagePluginFramework.Models;
using ImagePluginFramework.Services.Implementaions;
using ImagePluginFramework.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static System.Net.Mime.MediaTypeNames;

namespace TestPlugin
{
    public class UnitTest1
    {
        public static ImageResponse ImageResponses { get; set; }

        public static void GetEffectAppliedImages()
        {
            
            var changeSize = new Mock<ChangeImageSizeService>();
            ChangeImageSizeService changeImageSizeService = changeSize.Object;

            var changeImageRadius = new Mock<ChangeImageRadiusService>();
            ChangeImageRadiusService changeImageRadiusService = changeImageRadius.Object;

            var applyEffects = new Mock<ApplyEffectService>();
            ApplyEffectService applyEffectService = applyEffects.Object;
           
            byte[] image = new byte[76800];
            byte[] responseImage;


            responseImage=changeImageSizeService.ChangeImageSize(image, 100);
            responseImage = changeImageRadiusService.ChangeImageRadius(responseImage, 50);
            responseImage = applyEffectService.ApplyEffect(responseImage, new Effect() { Plugin = new Plugin() { Description = "Blur" }, Value = 50 });

            ImageResponses = new ImageResponse(){Image=responseImage};

        }

        [Fact]
        public void Test_Image_Plugin()
        {

            GetEffectAppliedImages();
            byte[] image= new byte[76800];

            var resultImage = ImageResponses.Image;
            Xunit.Assert.Equal(image, resultImage);
        }
    }
}
