using System;
using DotNetdit.Web;
using NUnit.Framework;

namespace DotNetdit.UnitTests.Web
{
    [TestFixture]
    public class WebAgentTests
    {
        [Test]
        public void Constructor_NullBaseAddress_ThrowsException() {
            Assert.Catch<ArgumentNullException>(() => new WebAgent(null));
        }

        [Test]
        public void PerformGetAsync_NullUri_ThrowsException() {
            var target = MakeWebAgent();

            Assert.That(async () => await target.PerformGetAsync(null), Throws.TypeOf<ArgumentNullException>());
        }

        // todo - test that PerformGetAsync throws exception when response is unsuccessful
        // todo - test that PerformGetAsync returns a string correctly


        private WebAgent MakeWebAgent() {
            return new WebAgent("http://reddit.com/");
        }
    }
}
