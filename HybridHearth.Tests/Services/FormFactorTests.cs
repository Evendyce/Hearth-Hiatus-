using HybridHearth.Services;
using HybridHearth.Web.Services;
using HybridHearth.Web.Client.Services;
using Microsoft.Maui.Devices;
using Xunit;

namespace HybridHearth.Tests.Services
{
    public class FormFactorTests
    {
        [Fact]
        public void MauiFormFactor_ReturnsExpectedValues()
        {
            var service = new FormFactor();
            Assert.Equal(DeviceInfo.Idiom.ToString(), service.GetFormFactor());
            var expectedPlatform = DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
            Assert.Equal(expectedPlatform, service.GetPlatform());
        }

        [Fact]
        public void WebServerFormFactor_ReturnsExpectedValues()
        {
            var service = new HybridHearth.Web.Services.FormFactor();
            Assert.Equal("Web", service.GetFormFactor());
            Assert.Equal(Environment.OSVersion.ToString(), service.GetPlatform());
        }

        [Fact]
        public void WebAssemblyFormFactor_ReturnsExpectedValues()
        {
            var service = new HybridHearth.Web.Client.Services.FormFactor();
            Assert.Equal("WebAssembly", service.GetFormFactor());
            Assert.Equal(Environment.OSVersion.ToString(), service.GetPlatform());
        }
    }
}
