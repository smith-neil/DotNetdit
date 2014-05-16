using System;
using DotNetdit.Factories;
using Newtonsoft.Json;
using NUnit.Framework;

namespace DotNetdit.UnitTests.Factories
{
    [TestFixture]
    public class JTokenFactoryTests
    {
        [Test]
        public void MakeJToken_NullVal_ThrowsException() {
            var target = MakeJTokenFactory();

            Assert.Catch<ArgumentNullException>(() => target.MakeJToken(null));
        }

        [TestCase("{")]
        [TestCase("{name: test}")]
        public void MakeJToken_InvalidJson_ThrowsException(string json) {
            var target = MakeJTokenFactory();

            Assert.Catch<JsonReaderException>(() => target.MakeJToken(json));
        }

        [TestCase(@"{""name"": ""test""}")]
        public void MakeJTokn_ValidJson_ThrowsException(string json) {
            var target = MakeJTokenFactory();

            var result = target.MakeJToken(json);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Value<string>("name"), Is.EqualTo("test"));
        }

        // todo - test that valid subreddit json is parsed correctly
        // todo - test that valid post json is parsed correctly
        // todo - test that valid comment json is parsed correctly
        // todo - test that valid user stuff json is parsed correctly


        private JTokenFactory MakeJTokenFactory() {
            return new JTokenFactory();
        }
    }
}
