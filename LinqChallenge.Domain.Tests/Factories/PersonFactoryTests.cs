using LinqChallenge.Domain.Enums;
using LinqChallenge.Domain.Factories;
using LinqChallenge.Domain.Interfaces;

namespace LinqChallenge.Domain.Tests.Factories
{
    [TestFixture]
    public class PersonFactoryTests
    {
        private readonly IPersonFactory _factory;
        private readonly IRandomStringFactory _firstNames;
        private readonly IRandomStringFactory _lastNames;
        private readonly IRandomDateFactory _dates;

        public PersonFactoryTests()
        {
            var today = DateTime.UtcNow;

            _firstNames = new RandomStringFactory(Constants.Strings.FirstNames);
            _lastNames = new RandomStringFactory(Constants.Strings.LastNames);
            _dates = new RandomDateFactory(new(today.Year - 100, 1, 1), today);
            _factory = new PersonFactory(_firstNames, _lastNames, _dates);
        }

        [Test]
        public void CreateUnique_ReturnsPlayer()
        {
            Assert.That(_factory.CreateUnique(), Is.Not.Null);
        }

        [Test]
        public void CreatePersonWhoDoesNotLikeColor_GivenBlue_ReturnsPeople_WhereNobodyLikesBlue()
        {
            var people = Enumerable.Range(0, 50).Select(_ => _factory.CreatePersonWhoDoesNotLikeTheColor(Color.Blue))!;

            Assert.That(people.All(x => x.FavoriteColor != Color.Blue), Is.True);
        }

    }
}
