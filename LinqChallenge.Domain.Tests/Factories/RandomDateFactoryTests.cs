using LinqChallenge.Domain.Factories;
using LinqChallenge.Domain.Interfaces;

namespace LinqChallenge.Domain.Tests.Factories
{
    [TestFixture]
    public class RandomDateFactoryTests
    {
        private readonly IRandomDateFactory _factory;
        private readonly DateTime _todayInUTC = DateTime.UtcNow;

        public RandomDateFactoryTests()
        {
            var minDate = new DateTime(_todayInUTC.Year - 100, 1, 1);

            _factory = new RandomDateFactory(minDate, _todayInUTC);
        }

        [Test]
        public void GetRandomDate_Should_ReturnDate()
        {
            Assert.That(_factory.GetRandom(), Is.Not.EqualTo(null));
        }

        [Test]
        public void GetRandomMoreThanYearsAgo_Given_20_Should_ReturnDate_MoreThan20YearsAgo()
        {
            var dates = Enumerable.Range(0, 200).Select(x => _factory.GetRandomMoreThanYearsAgo(20).Year);

            Assert.That(dates.All(x => x <= 2002), Is.True);
        }

        [Test]
        public void GetRandomLessThanYearsAgo_Given_20_Should_ReturnDate_LessThan20YearsAgo()
        {
            var dates = Enumerable.Range(0, 200).Select(x => _factory.GetRandomLessThanYearsAgo(20).Year);

            Assert.That(dates.All(x => x - _todayInUTC.Year < 20), Is.True);
        }
    }
}
