using LinqChallenge.Domain.Extensions;
using LinqChallenge.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests.Easy
{
    public class SelectChallengeTests : BaseTest
    {
        // If you are just starting, you can find the instructions in the Linq Challenge project, Easy folder, WhereChallenge.cs class

        private readonly SelectChallenge _challenge = new();

        #region GetBirthdays

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void GetBirthdays_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> nullOrEmptyCollectionOfPeople)
        //{
        //    Assert.That(_challenge.GetBirthdays(nullOrEmptyCollectionOfPeople), Is.Empty);
        //}


        //[TestCaseSource(nameof(_peopleAndTheirBirthdays)),
        //Description("Second Test - Return collection of peoples birthdays")]
        //public void GetBirthdays_Given_ColllectionOfPerson_Should_ReturnCollection_OfPeoplesBirthdays(IEnumerable<Person> people, IEnumerable<DateTime> birthdays)
        //{
        //    Assert.That(_challenge.GetBirthdays(people), Is.EqualTo(birthdays));
        //}

        #endregion

        #region ConvertToUppercase

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfStrings)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void ConvertToUppercase_Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        //{
        //    Assert.That(_challenge.ConvertToUppercase(nullOrEmptyCollectionOfStrings), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfStrings)),
        //Description("Second Test - Return strings converted to All Uppercase")]
        //public void ConvertToUppercase_Given_CollectionOfStrings_Should_ReturnStrings_AllUppercase(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        //{
        //    Assert.That(_challenge.ConvertToUppercase(nullOrEmptyCollectionOfStrings).All(s => s == s.ToUpper()));
        //}

        #endregion

        #region SelectInches

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfLengths)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void SelectInches_Given_NullOrEmpty_CollectionOfLengths_Should_ReturnEmptyCollection(IEnumerable<Length> nullOrEmptyCollectionOfLengths)
        //{
        //    Assert.That(_challenge.SelectInches(nullOrEmptyCollectionOfLengths), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Second Test - Return the Inches property from each Length in the collection.")]
        //public void SelectInches_Given_CollectionOfLengths_Should_ReturnInches_FromEachLength(IEnumerable<int> collectionOfInches)
        //{  
        //    var lengths = collectionOfInches.Select(inches => (new Length(0, inches), inches)).ToArray();

        //    Assert.That(_challenge.SelectInches(lengths.Select(x => x.Item1)), Is.EqualTo(lengths.Select(x => x.inches)));
        //}


        #endregion

        #region DivideNumbers


        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfInts)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void DivideNumbers_Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection(IEnumerable<int> nullOrEmptyCollectionOfInts)
        //{
        //    Assert.That(_challenge.DivideNumbers(nullOrEmptyCollectionOfInts, 2), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Second Test - Throw an exception with the message 'Invalid Input! Cannot Divide By Zero!' when the number to divide by is Zero ")]
        //public void DivideNumbers_Given_NumberToDivideBy_IsZero_Should_ThrowException_WithMessage(IEnumerable<int> collectionOfNumbers)
        //{
        //    var expectedExceptionMessage = "Invalid Input! Cannot Divide By Zero!";            

        //    Assert.That(Assert.Throws<Exception>(() => _challenge.DivideNumbers(collectionOfNumbers, 0))!.Message, Is.EqualTo(expectedExceptionMessage));
        //}


        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Third Test - Return each number divided by the number provided")]
        //public void DivideNumbers_Given_CollectionOfInts_AndNotDividngByZero_Should_ReturnNumbers_DividedByNumberProvided(IEnumerable<int> collectionOfNumbers)
        //{
        //    var (input, output, numberToDivideBy) = GetNumbersAndTheirDivision(collectionOfNumbers);

        //    Assert.That(_challenge.DivideNumbers(input, numberToDivideBy), Is.EqualTo(output));
        //}

        #endregion

        #region ParseCollection

        /* This is your chance again!
          
            Below I have started a test for you. Here's what I've already done:
                
                1) The Test Method has already been named to define what we are testing.
                2) The TestCaseSource is already being passed in. 
                        - This is essentially four test cases, a null, and an empty Array, List, and Enumerable.
                
            What do you need to do?

            You need to set up the logic to assert the ParseCollection() method is returning an empty IEnumerable when given any of these test cases.

            If you're feeling lost feel free to reference one of my other tests.
            If you haven't already created your own test in the Easy.WhereChallengeTests then that may be a slightly easier starting point.         
         */

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfStrings)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void DivideNumbers_Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        //{           
        //    // I've set up the Arrange/Act/Assert below in case you would like to use that as a starting point.

        //    // Arrange

        //    // Act

        //    // Assert
        //}


        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Second Test - Return numbers parsed into strings when given a collection of strings")]
        //public void DivideNumbers_Given_CollectionOfStrings_WhereAllAreNumbers_Should_ReturnStrings_ParsedIntoInts(IEnumerable<int> collectionOfNumbers)
        //{
        //    var (expected, numbers) = GetNumbersAsIntsAndStrings(collectionOfNumbers);

        //    Assert.That(_challenge.ParseCollection(numbers), Is.EqualTo(expected));
        //}


        [TestCaseSource(nameof(_collectionOfNumbers)),
        Description("Third Test - Return strings as 0 if they are not a number")]
        public void DivideNumbers_Given_CollectionOfStrings_WhereNotAllAreNumbers_Should_ReturnZero_ForStringsThat_AreNotNumbers(IEnumerable<int> collectionOfNumbers)
        {
            var mixtureOfNumbersAndWords = collectionOfNumbers.FizzBuzz().ToArray();

            var indexOfWords = mixtureOfNumbersAndWords.Select((word, index) => (word, index))
                .Where(x => !int.TryParse(x.word, out _)).Select(n => n.index).ToList();

            Assert.That(_challenge.ParseCollection(mixtureOfNumbersAndWords).Where((x, index) =>
                    indexOfWords.Contains(index)).All(x => x == 0));
        }


        #endregion

        #region ConvertToThePowerOfIndex

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfInts)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void ConvertToThePowerOfIndex_Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection(IEnumerable<int> nullOrEmptyCollectionOfInts)
        //{
        //    Assert.That(_challenge.ConvertToThePowerOfIndex(nullOrEmptyCollectionOfInts), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Second Test - Return empty collection when input is null or empty")]
        //public void ConvertToThePowerOfIndex_Given_CollectionOfInts_Should_ReturnNumbers_ToThePowerOf_TheirIndex(IEnumerable<int> collectionOfNumbers)
        //{
        //    var (input, output) = GetNumbersAndTheirPowerToIndex(collectionOfNumbers);

        //    Assert.That(_challenge.ConvertToThePowerOfIndex(input), Is.EqualTo(output));
        //}

        #endregion  
    }
}
