using LinqChallenge.Domain.Factories;
using LinqChallenge.Domain.Constants;
using LinqChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests
{
    public class TestDataFactories
    {
        public IPersonFactory PersonFactory { get; set; }

        public IRandomStringFactory RandomFirstNameFactory { get; set; }

        public IRandomStringFactory RandomLastNameFactory { get; set; }

        public IRandomDateFactory RandomDateFactory { get; set; }

        private readonly int _numberOfTestCases, _numberOfObjectsPerTestCase;

        private readonly Random _rng = new Random();

        public TestDataFactories(int numberOfTestCases = 25, int numberOfObjectsPerTestCase = 50)
        {
            var today = DateTime.UtcNow;

            _numberOfTestCases = numberOfTestCases;
            _numberOfObjectsPerTestCase = numberOfObjectsPerTestCase;

            RandomFirstNameFactory = new RandomStringFactory(Strings.FirstNames);
            RandomLastNameFactory = new RandomStringFactory(Strings.LastNames);

            RandomDateFactory = new RandomDateFactory(new(today.Year - 100, 1, 1), today);

            PersonFactory = new PersonFactory(RandomFirstNameFactory, RandomLastNameFactory, RandomDateFactory);
        }

        public object[] EmptyCollection<T>() => new[] { Enumerable.Empty<T>(), Array.Empty<T>(), new List<T>(), null! };
        
        private IEnumerable<IEnumerable<int>> BaseTestCaseCollection => 
            Enumerable.Range(0, _numberOfTestCases).Select(_ => Enumerable.Range(0, _numberOfObjectsPerTestCase));

        public IEnumerable<IEnumerable<string>> CollectionOfStrings =>
            BaseTestCaseCollection.Select(_ => _.Select(_ => _rng.Next(101) % 2 == 0 ? 
                RandomFirstNameFactory.GetRandom() : RandomLastNameFactory.GetRandom()));

        public IEnumerable<IEnumerable<int>> CollectionOfRandomNumbersFromOneToThreeHundred =>
            BaseTestCaseCollection.Select(_ => _.Select(_ => _rng.Next( 1, 301)));

        public IEnumerable<IEnumerable<Length>> CollectionOfLengths =>
            BaseTestCaseCollection.Select(_ => _.Select(_ => new Length(_rng.Next(1, 180))));

        public IEnumerable<IEnumerable<Person>> CollectionOfAdultPeople => 
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreateAdult()));

        public IEnumerable<IEnumerable<Person>> CollectionOfChildren => 
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreateAdult(false)));

        public IEnumerable<IEnumerable<Person>> CollectionOfPeople => 
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreateUnique()));

        public IEnumerable<IEnumerable<Person>> CollectionOfPeopleWithinHeightRange(Length minHeight, Length maxHeight) =>
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreatePersonWithinHeightRange(minHeight, maxHeight)));

        public IEnumerable<IEnumerable<Person>> CollectionOfPeopleWhoDoNotLikeBlue => 
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreatePersonWhoDoesNotLikeTheColor(Color.Blue)));

        public IEnumerable<IEnumerable<Person>> CollectionOfPeopleWhoseNameDoesNotContain(char c) =>
            BaseTestCaseCollection.Select(_ => _.Select(_ => PersonFactory.CreatePersonWhoseNameDoesNotInclude(c.ToString())));

        public IEnumerable<IEnumerable<Person>> CollectionOfPeopleNotBornInApril => BaseTestCaseCollection.Select(_ => _
        .Select(_ => {
            var person = PersonFactory.CreateUnique();
            person.DateOfBirth = person.DateOfBirth.Month == 4 ? new(1990, 11, 20) : person.DateOfBirth;
            return person;
        }));
    }
}
