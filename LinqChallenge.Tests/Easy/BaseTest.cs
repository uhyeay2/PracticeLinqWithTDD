using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests.Easy
{
    public abstract class BaseTest
    {
        protected static readonly TestDataFactories _testData = new(numberOfTestCases: 25, numberOfObjectsPerTestCase: 50);

        #region Null/Empty Collections

        protected static readonly object[] _nullOrEmptyCollectionOfPeople = _testData.EmptyCollection<Person>();

        protected static readonly object[] _nullOrEmptyCollectionOfStrings = _testData.EmptyCollection<string>();

        protected static readonly object[] _nullOrEmptyCollectionOfLengths = _testData.EmptyCollection<Length>();

        protected static readonly object[] _nullOrEmptyCollectionOfInts = _testData.EmptyCollection<int>();

        #endregion

        #region Collections of Objects

        protected static readonly IEnumerable<IEnumerable<string>> _collectionOfStrings = _testData.CollectionOfStrings;

        protected static readonly IEnumerable<IEnumerable<Length>> _collectionOfLengths = _testData.CollectionOfLengths;

        protected static readonly IEnumerable<IEnumerable<int>> _collectionOfNumbers = _testData.CollectionOfRandomNumbersFromOneToThreeHundred;

        #region People

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeople = _testData.CollectionOfPeople;

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfAdultPeopleTestCases = _testData.CollectionOfAdultPeople;

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfChildrenTestCases = _testData.CollectionOfChildren;

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleWhoDontLikeBlue = _testData.CollectionOfPeopleWhoDoNotLikeBlue;

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleNotBornInApril = _testData.CollectionOfPeopleNotBornInApril;

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleWhoseNameDoesNotContainA = _testData.CollectionOfPeopleWhoseNameDoesNotContain('a');

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleShorterThanFourFoot = _testData.CollectionOfPeopleWithinHeightRange(new(1, 6), new(3, 6));

        protected static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleTallerThanFourFoot = _testData.CollectionOfPeopleWithinHeightRange(new(4, 1), new(7, 6));

        #endregion

        #endregion

        #region Tuples For Test Cases

        private (IEnumerable<T> Input, IEnumerable<T> Output) GetMixedAndOrderedCollection<T>(IEnumerable<T> numbers)
        {
            var mixed = numbers.ToArray();

            var ordered = mixed.OrderBy(x => x);

            return (mixed, ordered);
        }

        protected (IEnumerable<int> Integers, IEnumerable<string> Strings) GetNumbersAsIntsAndStrings(IEnumerable<int> numbers)
        {
            var integers = numbers.ToArray();

            var strings = integers.Select(x => x.ToString());

            return (integers, strings);
        }

        protected (IEnumerable<int> Numbers, IEnumerable<int> Powers) GetNumbersAndTheirPowerToIndex(IEnumerable<int> numbers)
        {
            var nums = numbers.ToArray();

            var powers = nums.Select((x, i) => (int)Math.Pow(x, i));

            return (nums, powers);
        }


        protected (IEnumerable<int> input, IEnumerable<int> output, int numberToDivideBy) GetNumbersAndTheirDivision(IEnumerable<int> numbers)
        {
            var numberToDivideBy = new Random().Next(1, 10);

            var input = numbers.ToArray();

            var output = input.Select(x => x / numberToDivideBy);

            return (input, output, numberToDivideBy);
        }

        protected (IEnumerable<Person> Input, IEnumerable<Person> Output) GetPeopleMixedAndOrderedShortestToTallest(IEnumerable<Person> people)
        {
            var mixed = people.ToArray();

            var ordered = mixed.OrderBy(x => x.Height);

            return (mixed, ordered);
        }

        protected (IEnumerable<Length> Input, IEnumerable<Length> Output) GetLengthsMixedAndOrderedLongestToShortest(IEnumerable<Length> lengths)
        {
            var mixed = lengths.ToArray();

            var ordered = mixed.OrderByDescending(x => x);

            return (mixed, ordered);
        }

        protected (IEnumerable<Person> Input, IEnumerable<Person> Output) GetPeopleMixedAndOrderedByLastInitialZToA(IEnumerable<Person> people)
        {
            var mixed = people.ToArray();

            var ordered = mixed.OrderByDescending(x => x.LastName);

            return (mixed, ordered);
        }

        protected (IEnumerable<Person> Input, IEnumerable<Person> Output) GetPeopleMixedAndOldestToYoungest(IEnumerable<Person> people)
        {
            var mixed = people.ToArray();

            var ordered = mixed.OrderByDescending(x => x.DateOfBirth);

            return (mixed, ordered);
        }

        #endregion

        #region Misc Test Cases

        protected static readonly object[] _peopleAndTheirBirthdays =
        {
            new object[]
            {
                new List<Person>()
                {
                    _testData.PersonFactory.CreateSpecific(birthday: new DateTime(1990, 7, 4)),
                    _testData.PersonFactory.CreateSpecific(birthday: new DateTime(1992, 4, 6)),
                    _testData.PersonFactory.CreateSpecific(birthday: new DateTime(1994, 10, 16)),
                    _testData.PersonFactory.CreateSpecific(birthday: new DateTime(2000, 1, 20))
                },
                new List<DateTime>()
                {
                    new DateTime(1990, 7, 4),
                    new DateTime(1992, 4, 6),
                    new DateTime(1994, 10, 16),
                    new DateTime(2000, 1, 20)
                }
            }
        };

        #endregion
    }
}
