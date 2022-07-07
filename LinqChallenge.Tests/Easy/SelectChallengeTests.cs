using LinqChallenge.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests.Easy
{
    public class SelectChallengeTests
    {

        // If you are just starting, you can find the instructions in the Linq Challenge project, Easy folder, WhereChallenge.cs class

        private readonly SelectChallenge _challenge = new();

        #region GetBirthdays

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void GetBirthdays_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> nullOrEmptyCollectionOfPeople)
        {
            Assert.That(_challenge.GetBirthdays(nullOrEmptyCollectionOfPeople), Is.Empty);
        }


        [TestCaseSource(nameof(_peopleAndTheirBirthdays)),
        Description("Second Test - Return collection of peoples birthdays")]
        public void GetBirthdays_Given_ColllectionOfPerson_Should_ReturnCollection_OfPeoplesBirthdays(IEnumerable<Person> people, IEnumerable<DateTime> birthdays)
        {
            Assert.That(_challenge.GetBirthdays(people), Is.EqualTo(birthdays));
        }

        #endregion

        #region ConvertToUppercase

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfStrings)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void ConvertToUppercase_Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        {
            Assert.That(_challenge.ConvertToUppercase(nullOrEmptyCollectionOfStrings), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfStrings)),
        Description("Second Test - Return strings converted to All Uppercase")]
        public void ConvertToUppercase_Given_CollectionOfStrings_Should_ReturnStrings_AllUppercase(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        {
            Assert.That(_challenge.ConvertToUppercase(nullOrEmptyCollectionOfStrings).All(s => s == s.ToUpper()));
        }

        #endregion

        #region SelectInches

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfLengths)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void SelectInches_Given_NullOrEmpty_CollectionOfLengths_Should_ReturnEmptyCollection(IEnumerable<Length> nullOrEmptyCollectionOfLengths)
        {
            Assert.That(_challenge.SelectInches(nullOrEmptyCollectionOfLengths), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Second Test - Return the Inches property from each Length in the collection.")]
        public void SelectInches_Given_CollectionOfLengths_Should_ReturnInches_FromEachLength(IEnumerable<int> collectionOfInches)
        {
            var lengths = collectionOfInches.Select(inches => (new Length(0, inches), inches)).ToArray();

            Assert.That(_challenge.SelectInches(lengths.Select(x => x.Item1)), Is.EqualTo(lengths.Select(x => x.inches)));
        }


        #endregion

        #region DivideNumbers

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfInts)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void DivideNumbers_Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection(IEnumerable<int> nullOrEmptyCollectionOfInts)
        {
            Assert.That(_challenge.DivideNumbers(nullOrEmptyCollectionOfInts, 2), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Second Test - Throw an exception with the message 'Invalid Input! Cannot Divide By Zero!' when the number to divide by is Zero ")]
        public void DivideNumbers_Given_NumberToDivideBy_IsZero_Should_ThrowException_WithMessage(IEnumerable<int> collectionOfNumbers)
        {
            var expectedExceptionMessage = "Invalid Input! Cannot Divide By Zero!";

            Assert.That(Assert.Throws<Exception>(() => _challenge.DivideNumbers(collectionOfNumbers, 0))!.Message, Is.EqualTo(expectedExceptionMessage));
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Third Test - Return each number divided by the number provided")]
        public void DivideNumbers_Given_CollectionOfInts_AndNotDividngByZero_Should_ReturnNumbers_DividedByNumberProvided(IEnumerable<int> collectionOfNumbers)
        {
            var (input, output, numberToDivideBy) = GetNumbersAndTheirDivision(collectionOfNumbers);

            Assert.That(_challenge.DivideNumbers(input, numberToDivideBy), Is.EqualTo(output));
        }

        #endregion

        #region ParseCollection

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfStrings)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void ParseCollection_Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        {
            Assert.That(_challenge.ParseCollection(nullOrEmptyCollectionOfStrings), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Second Test - Return numbers parsed into strings when given a collection of strings")]
        public void ParseCollection_Given_CollectionOfStrings_WhereAllAreNumbers_Should_ReturnStrings_ParsedIntoInts(IEnumerable<int> collectionOfNumbers)
        {
            var (expected, numbers) = GetNumbersAsIntsAndStrings(collectionOfNumbers);

            Assert.That(_challenge.ParseCollection(numbers), Is.EqualTo(expected));
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Third Test - Return strings as 0 if they are not a number")]
        public void ParseCollection_Given_CollectionOfStrings_WhereNotAllAreNumbers_Should_ReturnZero_ForStringsThat_AreNotNumbers(IEnumerable<int> collectionOfNumbers)
        {
            var mixtureOfNumbersAndWords = FizzBuzz(collectionOfNumbers).ToArray();

            var indexOfWords = mixtureOfNumbersAndWords.Select((word, index) => (word, index))
                .Where(x => !int.TryParse(x.word, out _)).Select(n => n.index).ToList();

            Assert.That(_challenge.ParseCollection(mixtureOfNumbersAndWords).Where((x, index) =>
                    indexOfWords.Contains(index)).All(x => x == 0));
        }


        #endregion

        #region ConvertToThePowerOfIndex

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfInts)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void ConvertToThePowerOfIndex_Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection(IEnumerable<int> nullOrEmptyCollectionOfInts)
        {
            Assert.That(_challenge.ConvertToThePowerOfIndex(nullOrEmptyCollectionOfInts), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Second Test - Return empty collection when input is null or empty")]
        public void ConvertToThePowerOfIndex_Given_CollectionOfInts_Should_ReturnNumbers_ToThePowerOf_TheirIndex(IEnumerable<int> collectionOfNumbers)
        {
            var (input, output) = GetNumbersAndTheirPowerToIndex(collectionOfNumbers);

            Assert.That(_challenge.ConvertToThePowerOfIndex(input), Is.EqualTo(output));
        }

        #endregion

        #region Test Cases

        private static readonly TestDataFactories _testData = new();

        public static readonly object[] _nullOrEmptyCollectionOfPeople = _testData.EmptyCollection<Person>();

        public static readonly object[] _nullOrEmptyCollectionOfStrings = _testData.EmptyCollection<string>();

        public static readonly object[] _nullOrEmptyCollectionOfLengths = _testData.EmptyCollection<Length>();

        public static readonly object[] _nullOrEmptyCollectionOfInts = _testData.EmptyCollection<int>();

        private static readonly IEnumerable<IEnumerable<string>> _collectionOfStrings = _testData.CollectionOfStrings;

        private static readonly IEnumerable<IEnumerable<int>> _collectionOfNumbers = _testData.CollectionOfRandomNumbersFromOneToThreeHundred;

        public static readonly object[] _peopleAndTheirBirthdays =
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

        private (IEnumerable<int> Integers, IEnumerable<string> Strings) GetNumbersAsIntsAndStrings(IEnumerable<int> numbers)
        {
            var integers = numbers.ToArray();

            var strings = integers.Select(x => x.ToString());

            return (integers, strings);
        }

        private (IEnumerable<int> Numbers, IEnumerable<int> Powers) GetNumbersAndTheirPowerToIndex(IEnumerable<int> numbers)
        {
            var nums = numbers.ToArray();

            var powers = nums.Select( (x, i) => (int)Math.Pow(x, i));

            return (nums, powers);
        }

        private (IEnumerable<int> input, IEnumerable<int> output, int numberToDivideBy) GetNumbersAndTheirDivision(IEnumerable<int> numbers)
        {
            var numberToDivideBy = new Random().Next(1, 10);

            var input = numbers.ToArray();

            var output = input.Select(x => x / numberToDivideBy);

            return (input, output, numberToDivideBy);
        }

        #endregion

        private IEnumerable<string> FizzBuzz(IEnumerable<int> numbers) => numbers.Select(x =>
            x % 3 == 0 ? x % 5 == 0 ? "FizzBuzz" : "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}");
    }
}
