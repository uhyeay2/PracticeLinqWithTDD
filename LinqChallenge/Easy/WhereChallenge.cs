using LinqChallenge.Domain.Entities;
using System.Linq;

namespace LinqChallenge.Easy
{
    public class WhereChallenge
    {
        /* GetPeopleOlderThanEighteen - Recommended Requirements          
        
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

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