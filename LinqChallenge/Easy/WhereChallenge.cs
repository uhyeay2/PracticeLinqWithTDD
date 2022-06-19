using LinqChallenge.Domain.Entities;
using System.Linq;

namespace LinqChallenge.Easy
{
    /// <summary>
    /// All tests for this class can be found in the following location:
    /// LinqChallenge.Tests.Easy.WhereChallengeTests
    /// </summary>
    public class WhereChallenge
    {
        /* GetPeopleOlderThanEighteen - Tests Details

            Below are the names of your tests. You should try to complete these one at a time.
            After solving a test, uncomment the next one below it until you have met all requirements.

            Given_Null_Should_ReturnEmptyCollection
            Given_EmptyCollection_Should_ReturnEmptyCollection
            Given_PeopleWhereNoneAreOlderThanEighteen_Should_ReturnEmptyCollection
            Given_PeopleWhereSomeAreOlderThanEighteen_Should_ReturnOnlyPeopleOlderThanEighteen
        */
        public IEnumerable<Person> GetPeopleOlderThanEighteen(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }
    }
}