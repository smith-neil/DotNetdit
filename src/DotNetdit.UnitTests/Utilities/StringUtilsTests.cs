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
            string nullThing = null;

            Assert.Catch<ArgumentNullException>(() => nullThing.FormatWith("hi", "hello"));
        }

        [Test]
        public void FormatWith_NullArgs_ThrowsException() {
            string notNullThing = "test{0}";

            Assert.Catch<ArgumentNullException>(() => notNullThing.FormatWith(null));
        }

        [Test]
        public void FormatWith_EmptyArgs_ThrowsException() {
            string notNullThing = "test{0}";

            Assert.Catch<FormatException>(() => notNullThing.FormatWith());
        }

        [Test]
        public void FormatWith_ValidInput_ReturnsFormattedString() {
            string notNullThing = "test{0}{1}{2}";

            var result = notNullThing.FormatWith(" 1", " 2", " 3");

            Assert.That(result, Is.EqualTo("test 1 2 3"));
        }
    }
}
