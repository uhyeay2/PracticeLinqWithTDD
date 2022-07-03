using LinqChallenge.Domain.Constants;
using LinqChallenge.Domain.Factories;
using LinqChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Tests.Factories
{
    [TestFixture]
    public class RandomStringFactoryTests
    {
        private readonly IRandomStringFactory _factory = new RandomStringFactory(Strings.FirstNames);

        [Test]
        public void GetRandomString_Should_ReturnRandomString_FromSource()
        {
            Assert.That(Strings.FirstNames, Does.Contain(_factory.GetRandom()));
        }

        [Test]
        public void GetRandomFirstName_Should_AppendNames_IfNoUniqueNamesLeft()
        {
            var strings = Enumerable.Range(0, Strings.FirstNames.Length * 2).Select(x => _factory.GetRandomUnique());

            Assert.That(strings.Distinct().Count, Is.EqualTo(strings.Count()));
        }

    }
}
