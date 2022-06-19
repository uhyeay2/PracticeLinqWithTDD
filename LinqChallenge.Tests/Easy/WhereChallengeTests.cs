using LinqChallenge.Easy;

namespace LinqChallenge.Tests.Easy
{
    [TestFixture]
    public class WhereChallengeTests
    {
        private readonly WhereChallenge _challenge = new();

        #region GetPeopleOlderThanEighteen Tests

        [Test, Description("First Test - Return empty collection when input is null.")]
        public void GetPeopleOlderThanEighteen_Given_Null_Should_ReturnEmptyCollection()
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(null!), Is.Empty);
        }

        [TestCaseSource(nameof(_emptyPeopleCollections)), Description("Second Test - Return empty collection when input is empty")]
        public void GetPeopleOlderThanEighteen_Given_EmptyCollection_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(emptyCollection), Is.Empty);
        }

        [Test, Description("Third Test - Return empty collection when all people are under eighteen.")]
        public void GetPeopleOlderThanEighteen_Given_PeopleWhereNoneAreOlderThanEighteen_Should_ReturnEmptyCollection()
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(_peopleYoungerThanEighteen), Is.Empty);
        }

        [Test, Description("Fourth Test - Return only people who are 18 or older when input contains people of all ages")]
        public void GetPeopleOlderThanEighteen_Given_PeopleWhereSomeAreOlderThanEighteen_Should_ReturnOnlyPeopleOlderThanEighteen()
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(_peopleOfAllAges), Is.EqualTo(_peopleOlderThanEighteen));
        }

        #endregion

        #region TestCases

        private static readonly IEnumerable<Person> _peopleYoungerThanEighteen = new[]
        {
            new Person("John", "Smith", new DateTime(2020, 12, 3), new Length(5, 10), Color.Purple),
            new Person("Jackson", "Reed", new DateTime(2019, 10, 4), new Length(5, 2), Color.Red),
            new Person("Bonnie", "Clyde", new DateTime(2018, 9, 4), new Length(5, 2), Color.Blue),
            new Person("Sarah", "Allen", new DateTime(2017, 8, 4), new Length(5, 2), Color.Orange),
            new Person("Allen", "Poe", new DateTime(2016, 7, 4), new Length(5, 2), Color.Green),
        };

        private static readonly IEnumerable<Person> _peopleOlderThanEighteen = new[]
        {
            new Person("John", "Smith", new DateTime(1994, 12, 3), new Length(5, 10), Color.Purple),
            new Person("Jackson", "Reed", new DateTime(1993, 10, 4), new Length(5, 2), Color.Red),
            new Person("Bonnie", "Clyde", new DateTime(1992, 9, 4), new Length(5, 2), Color.Blue),
            new Person("Sarah", "Allen", new DateTime(1991, 8, 4), new Length(5, 2), Color.Orange),
            new Person("Allen", "Poe", new DateTime(1990, 7, 4), new Length(5, 2), Color.Green)
        };

        private static IEnumerable<Person> _peopleOfAllAges => _peopleYoungerThanEighteen.Concat(_peopleOlderThanEighteen);

        private static readonly object[] _emptyPeopleCollections =
        {
            Enumerable.Empty<Person>(), Array.Empty<Person>(), new List<Person>()
        };

        #endregion
    }
}   