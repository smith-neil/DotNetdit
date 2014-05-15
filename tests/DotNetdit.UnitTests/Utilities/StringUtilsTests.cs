using System;
using DotNetdit.Utilities;
using NUnit.Framework;

namespace DotNetdit.UnitTests.Utilities
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void FormatWith_NullSource_ThrowsException() {
            string nullString = null;

            Assert.Catch<ArgumentNullException>(() => nullString.FormatWith(""));
        }

        [Test]
        public void FormatWith_NullArgs_ThrowsException() {
            string notNullString = "test {0}";

            Assert.Catch<ArgumentNullException>(() => notNullString.FormatWith(null));
        }

        [Test]
        public void FormatWith_ValidInput_ReturnsFormattedString() {
            string notNullString = "test {0} {1} {2}";

            var result = notNullString.FormatWith(1, 2, 3);

            Assert.That(result, Is.EqualTo("test 1 2 3"));
        }
    }
}
