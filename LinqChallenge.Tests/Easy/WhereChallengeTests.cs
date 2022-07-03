using LinqChallenge.Domain.Factories;
using LinqChallenge.Domain.Constants;
using LinqChallenge.Easy;

namespace LinqChallenge.Tests.Easy
{
    [TestFixture]
    public class WhereChallengeTests
    {
        /*  Getting Started Instructions
            
            TODO: Read Instructions! - You can delete this line after reading 
                                        - You can see TODO's from ( View -> Task List )         


            This branch is focused on practicing Linq. For that reason, all tests are uncommented from the start.
            Each method will have a series of tests to ensure the proper result is returned. 


            If you would like to practice writing tests, or using Test Driven Development, you can try one of my other branches:

                - Test_PreMade : Some tests are already created for you, you will pass one test at a time, and occasionally write your own tests.

                - TDD_Practice  : The first test is partially started as an example. Recommended test names are provided.
                                     - This branch allows you to practice writing every test yourself.
                                     - If this sounds intimidating, remember you can reference branch for examples.


            Coming Soon: Introduction Video
        */

        private readonly WhereChallenge _challenge = new();

        #region GetPeopleOlderThanEighteen Tests


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void GetPeopleOlderThanEighteen_Given_EmptyCollection_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfChildrenTestCases)),
        Description("Second Test - Return empty collection when all people are under eighteen.")]
        public void GetPeopleOlderThanEighteen_Given_PeopleWhereNoneAreOlderThanEighteen_Should_ReturnEmptyCollection(IEnumerable<Person> peopleUnderEighteen)
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(peopleUnderEighteen), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people who are 18 or older when input contains people of all ages")]
        public void GetPeopleOlderThanEighteen_Given_PeopleWhereSomeAreOlderThanEighteen_Should_ReturnOnlyPeopleOlderThanEighteen(IEnumerable<Person> people)
        {
            Assert.That(_challenge.GetPeopleOlderThanEighteen(people).All(p => p.Age >= 18), Is.True);
        }


        #endregion

        #region GetPeopleWhoHaveTheFavoriteColorBlue Tests


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty.")]
        public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeopleWhoDontLikeBlue)),
        Description("Second Test - Return empty collection when no people have the favorite color blue")]
        public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_PeopleWhere_NoneHaveFavoriteColorBlue_Should_ReturnEmptyCollection(IEnumerable<Person> peopleWhoDontLikeBlue)
        {
            Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(peopleWhoDontLikeBlue), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people whose favorite color is blue.")]
        public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_PeopleWhere_SomeHaveFavoriteColorBlue_Should_ReturnOnlyPeople_WithFavoriteColorBlue(IEnumerable<Person> collectionOfPeople)
        {
            Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(collectionOfPeople).All(x => x.FavoriteColor == Color.Blue));
        }


        #endregion

        #region GetPeopleBornInApril Tests


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty.")]
        public void GetPeopleBornInApril_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleBornInApril(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeopleNotBornInApril)),
        Description("Second Test - Return empty collection when no people were born in April.")]
        public void GetPeopleBornInApril_Given_PeopleWhere_NoneAreBornInApril_Should_ReturnEmptyCollection(IEnumerable<Person> peopleNotBornInApril)
        {
            Assert.That(_challenge.GetPeopleBornInApril(peopleNotBornInApril), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people who were born in April.")]
        public void GetPeopleBornInApril_Given_PeopleWhere_SomeAreBornInApril_Should_ReturnOnlyPeople_BornInApril(IEnumerable<Person> collectionOfPeople)
        {
            Assert.That(_challenge.GetPeopleBornInApril(collectionOfPeople).All(p => p.DateOfBirth.Month == 4));
        }


        #endregion

        #region GetPeopleWhoseLastNameStartsWithA Tests


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty.")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeopleWhoseNameDoesNotContainA)),
        Description("Second Test - Return empty collection when no people have a LastName starting with 'A'")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_PeopleWhere_NoLastNameStartsWithA_Should_ReturnEmptyCollection(IEnumerable<Person> peopleWithoutAInTheirName)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(peopleWithoutAInTheirName), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people who have a LastName starting with the 'A'")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_PeopleWhere_SomeLastNamesStartsWithA_Should_ReturnOnlyPeople_WhoseLastNameStartsWithA(IEnumerable<Person> collectionOfPeople)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(collectionOfPeople).All(p => p.LastName.StartsWith('A')));
        }


        #endregion

        #region GetPeopleWhereFullNameContainsChar Tests

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty.")]
        public void GetPeopleWhereFullNameContainsChar_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhereFullNameContainsChar(emptyCollection, 'E'), Is.Empty);
        }


        [TestCase('-')]
        [TestCase('_')]
        [TestCase('=')]
        [TestCase('+')]
        [TestCase('/')]
        [TestCase('!')]
        [TestCase('@')]
        [TestCase('#')]
        [TestCase('$')]
        [TestCase('%')]
        [TestCase('^')]
        [TestCase('&')]
        [TestCase('*')]
        [TestCase('(')]
        [TestCase(')')]
        [TestCase('1')]
        [TestCase('2')]
        [TestCase('3')]
        [TestCase('4')]
        [TestCase('5')]
        [TestCase('6')]
        [TestCase('7')]
        [TestCase('8')]
        [TestCase('9')]
        [TestCase('0')]
        [Description("Second Test - Throw an Exception with a message 'Character provided must be a letter' if the character provided is not a letter.")]
        public void GetPeopleWhereFullNameContainsChar_Given_CharProvided_IsNotALetter_Should_ThrowException_WithMessage_CharacterProvidedMustBeALetter(char c)
        {
            var expectedExceptionMessage = "Character provided must be a letter";

            var people = _testData.CollectionOfPeople.First();

            Assert.That(Assert.Throws<Exception>(() => _challenge.GetPeopleWhereFullNameContainsChar(people, c)).Message, Is.EqualTo(expectedExceptionMessage));
        }


        [TestCaseSource(nameof(_collectionOfPeopleWhoseNameDoesNotContainA)),
        Description("Third Test - Return Empty Colection if no people have a name containing the character provided.")]
        public void GetPeopleWhereFullNameContainsChar_Given_PeopleWhere_NoFullName_ContainsCharProvided_Should_ReturnEmptyCollection(IEnumerable<Person> peopleWhoseNameDontContainA)
        {
            Assert.That(_challenge.GetPeopleWhereFullNameContainsChar(peopleWhoseNameDontContainA, 'A'), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Fourth Test - Return only people whose name contains character provided")]
        public void GetPeopleWhereFullNameContainsChar_Given_PeopleWhere_SomeFullNames_ContainCharProvided_Should_ReturnOnlyPeople_WhoseFullNameContainsCharProvided(IEnumerable<Person> people)
        {
            var peopleWhoseNameMightContainZ = people.ToList();

            var expectedCount = peopleWhoseNameMightContainZ.Count(x => (x.FirstName + x.LastName).Contains('z'));

            Assert.That(_challenge.GetPeopleWhereFullNameContainsChar(peopleWhoseNameMightContainZ, 'z').Count(), Is.EqualTo(expectedCount));
        }


        #endregion

        #region GetPeopleTallerThan Tests


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("First Test - Throw Exception with message 'Invalid Height - Height must be greater than 0.' if height is null.")]
        public void GetPeopleTallerThan_Given_HeightIsNull_Should_ThrowException_WithMessage_InvalidHeightReceived(IEnumerable<Person> collectionOfPeople)
        {
            var expectedMessage = "Invalid Height - Height must be greater than 0.";

            Assert.That(Assert.Throws<Exception>(() =>
                _challenge.GetPeopleTallerThan(collectionOfPeople, null!)).Message, Is.EqualTo(expectedMessage));
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Second Test - Throw Exception with message 'Invalid Height - Height must be greater than 0.' if height is zero")]
        public void GetPeopleTallerThan_Given_HeightIsZero_Should_ThrowException_WithMessage_InvalidHeightReceived(IEnumerable<Person> collectionOfPeople)
        {
            var expectedMessage = "Invalid Height - Height must be greater than 0.";

            Assert.That(Assert.Throws<Exception>(() =>
                _challenge.GetPeopleTallerThan(collectionOfPeople, new Length(0, 0))).Message, Is.EqualTo(expectedMessage));
        }


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("Third Test - Return empty collection when people provided is null or empty.")]
        public void GetPeopleTallerThan_Given_NullOrEmpty_CollectionOfPeople_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleTallerThan(emptyCollection, new Length(3, 2)), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeopleShorterThanFourFoot)),
        Description("Fourth Test - Return empty collection when no people are taller than height provided.")]
        public void GetPeopleTallerThan_Given_PeopleWhere_NoneAreTaller_ThanHeightProvided_Should_ReturnEmptyCollection(IEnumerable<Person> collectionOfPeopleShorterThanFourFoot)
        {
            Assert.That(_challenge.GetPeopleTallerThan(collectionOfPeopleShorterThanFourFoot, new Length(4, 0)), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Fifth Test - Return only people who are taller than the height provided.")]
        public void GetPeopleTallerThan_Given_PeopleWhere_AllAreTaller_ThanFourFoot_Should_______FINISH_THIS_NAME_____(IEnumerable<Person> collectionOfPeople)
        {
            Assert.That(_challenge.GetPeopleTallerThan(collectionOfPeople, new Length(4, 0)).All(x => x.Height > new Length(4, 0)));
        }

        #endregion

        #region TestCases

        private const int numberOfTestCases = 25;

        private const int numberOfPeoplePerTestCase = 50;

        private static readonly TestDataFactories _testData = new(numberOfTestCases, numberOfPeoplePerTestCase);

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfAdultPeopleTestCases = _testData.CollectionOfAdultPeople;

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfChildrenTestCases = _testData.CollectionOfChildren;

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeople = _testData.CollectionOfPeople;

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleWhoDontLikeBlue = _testData.CollectionOfPeopleWhoDoNotLikeBlue;

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleNotBornInApril = _testData.CollectionOfPeopleNotBornInApril;

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleWhoseNameDoesNotContainA = _testData.CollectionOfPeopleWhoseNameDoesNotContain('a');

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleShorterThanFourFoot = _testData.CollectionOfPeopleWithinHeightRange(new(1, 6), new(3, 6));

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleTallerThanFourFoot = _testData.CollectionOfPeopleWithinHeightRange(new(4, 1), new(7, 6));

        private static readonly object[] _nullOrEmptyCollectionOfPeople =
        {
            Enumerable.Empty<Person>(), Array.Empty<Person>(), new List<Person>(), null!
        };

        #endregion
    }
}   