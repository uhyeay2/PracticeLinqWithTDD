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


            Since this branch has a small focus on introducing you to Test Driven Development I recommend that you complete 
            one tests at a time. Once you finish a test you should uncomment just the next (one) test. Continue this process 
            until you pass all requirements for the method. Each method has been placed in its own region to allow you to 
            collapse tests and focus on one thing at a time.

            Occasionally I will not create the implementation for a method. Instead I will pass in the TestCaseSource, and
            some instructions for you to create your own assertion. This will be your practice to start writing tests on
            your own. As you progress in difficulty, you will have to write your own tests more often.


            If this branch isn't your speed, you might want to consider one of the other branches:

                - Strictly_Linq : All tests are pre-created, and uncommented. You can just focus passing all tests at once.

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


        // Tip - Hold the Ctrl Key while pressing K key, then U key - to uncomment highligthed blocks of code.
        // Try highlighting Lines 52 - 56 then using this keyboard shortcut to uncomment your next test.


        //[TestCaseSource(nameof(_collectionOfChildrenTestCases)),
        //Description("Second Test - Return empty collection when all people are under eighteen.")]
        //public void GetPeopleOlderThanEighteen_Given_PeopleWhereNoneAreOlderThanEighteen_Should_ReturnEmptyCollection(IEnumerable<Person> people)
        //{
        //    Assert.That(_challenge.GetPeopleOlderThanEighteen(people), Is.Empty);
        //}


        // Another Tip - You can use Ctrl + K + C to comment a block of code.


        //[TestCaseSource(nameof(_collectionOfPeople)),
        //Description("Third Test - Return only people who are 18 or older when input contains people of all ages")]
        //public void GetPeopleOlderThanEighteen_Given_PeopleWhereSomeAreOlderThanEighteen_Should_ReturnOnlyPeopleOlderThanEighteen(IEnumerable<Person> people)
        //{
        //    Assert.That(_challenge.GetPeopleOlderThanEighteen(people).All(p => p.Age >= 18), Is.True);
        //}


        // After completing your tests go back and refactor your logic! Can you solve this in one line without breaking any tests?
        // Feel free to try any method next. - Enjoy and happy coding!

        #endregion

        #region GetPeopleWhoHaveTheFavoriteColorBlue Tests


        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        //Description("First Test - Return empty collection when input is null or empty.")]
        //public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        //{
        //    Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(emptyCollection), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfPeopleWhoDontLikeBlue)),
        //Description("Second Test - Return empty collection when no people have the favorite color blue")]
        //public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_PeopleWhere_NoneHaveFavoriteColorBlue_Should_ReturnEmptyCollection(IEnumerable<Person> peopleWhoDontLikeBlue)
        //{
        //    Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(peopleWhoDontLikeBlue), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfPeople)),
        //Description("Third Test - Return only people whose favorite color is blue.")]
        //public void GetPeopleWhoHaveTheFavoriteColorBlue_Given_PeopleWhere_SomeHaveFavoriteColorBlue_Should_ReturnOnlyPeople_WithFavoriteColorBlue(IEnumerable<Person> peopleWhoDontLikeBlue)
        //{
        //    Assert.That(_challenge.GetPeopleWhoHaveTheFavoriteColorBlue(peopleWhoDontLikeBlue).All(x => x.FavoriteColor == Color.Blue));
        //}


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
        public void GetPeopleBornInApril_Given_PeopleWhere_NoneAreBornInApril_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleBornInApril(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people who were born in April.")]
        public void GetPeopleBornInApril_Given_PeopleWhere_SomeAreBornInApril_Should_ReturnOnlyPeople_BornInApril(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleBornInApril(emptyCollection).All(p => p.DateOfBirth.Month == 4));
        }


        #endregion

        #region GetPeopleWhoseLastNameStartsWithA


        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty.")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeopleWhoseLastNameDoesNotStartWithA)),
        Description("Second Test - Return empty collection when no people have a LastName starting with 'A'")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_PeopleWhere_NoLastNameStartsWithA_Should_ReturnEmptyCollection(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(emptyCollection), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Third Test - Return only people who have a LastName starting with the 'A'")]
        public void GetPeopleWhoseLastNameStartsWithA_Given_PeopleWhere_SomeLastNamesStartsWithA_Should_ReturnOnlyPeople_WhoseLastNameStartsWithA(IEnumerable<Person> emptyCollection)
        {
            Assert.That(_challenge.GetPeopleWhoseLastNameStartsWithA(emptyCollection).All(p => p.LastName.StartsWith('A')));
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

        private static readonly IEnumerable<IEnumerable<Person>> _collectionOfPeopleWhoseLastNameDoesNotStartWithA = _testData.CollectionOfPeopleWhoseLastNameDoesNotContain('A');

        private static readonly object[] _nullOrEmptyCollectionOfPeople =
        {
            Enumerable.Empty<Person>(), Array.Empty<Person>(), new List<Person>(), null!
        };

        #endregion
    }
}