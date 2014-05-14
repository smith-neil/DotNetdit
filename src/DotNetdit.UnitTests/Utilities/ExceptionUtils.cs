using System;
using NUnit.Framework;
using DotNetdit.Utilities;

namespace DotNetdit.UnitTests.Utilities
{
    [TestFixture]
    public class ExceptionUtils
    {
        [TestCase(null, null)]
        [TestCase("paramname", null)]
        [TestCase(null, "message")]
        public void ThrowIfNull_NullSource_ThrowsException(string paramName, string message) {
            string nullThing = null;

            Assert.Catch<ArgumentNullException>(() => nullThing.ThrowIfNull(paramName, message));
        }

        [TestCase(null, null)]
        [TestCase("paramname", null)]
        [TestCase(null, "message")]
        public void ThrowIfNull_NotNullSource_DoesNothing(string paramname, string message) {
            string notNullThing = "test";

            Assert.DoesNotThrow(() => notNullThing.ThrowIfNull(paramname, message));
        }
    }
}
