using LinqChallenge.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests.Easy
{
    public class OrderByChallengeTests : BaseTest
    {

        // If you are just starting, you can find the instructions in the Linq Challenge project, Easy folder, WhereChallenge.cs class

        private readonly OrderByChallenge _challenge = new();

        #region OrderByLowestToHighest

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfInts)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void OrderByLowestToHighest_Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection(IEnumerable<int> nullOrEmptyCollectionOfInts)
        //{
        //    Assert.That(_challenge.OrderByLowestToHighest(nullOrEmptyCollectionOfInts), Is.Empty);
        //}


        /*  This is your chance again!
           
            Below I have provided you with the input and output for the test.        
            You should be able to use these to pass into the method as your input and expected output.
        
            If you're feeling lost feel free to reference one of my other tests.

            If you haven't already created your own test, you can try doing so in: 
        
                1) Easy.WhereChallengeTests (GetPeopleTallerThan Method)
                2) Easy.SelectChallengeTests (DivideNumbers Method)
        */

        //[TestCaseSource(nameof(_collectionOfNumbers)),
        //Description("Second Test - Return numbers ordered from lowest to highest")]
        //public void OrderByLowestToHighest_Given_CollectionOfInts_Should_ReturnCollection_OrderedLowestToHighest(IEnumerable<int> collectionOfNumbers)
        //{
        //    var (input, output) = GetMixedAndOrderedCollection(collectionOfNumbers);

        //    // Now Arrange/Act/Assert!

        //}

        #endregion

        #region OrderByAToZ

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfStrings)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void OrderByAToZ_Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection(IEnumerable<string> nullOrEmptyCollectionOfStrings)
        //{
        //    Assert.That(_challenge.OrderByAToZ(nullOrEmptyCollectionOfStrings), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfStrings)),
        //Description("Second Test - Return words ordered from A to Z")]
        //public void OrderByAToZ_Given_CollectionOfStrings_Should_ReturnCollection_OrderedAToZ(IEnumerable<string> collectionOfStrings)
        //{
        //    var (input, output) = GetMixedAndOrderedCollection(collectionOfStrings);

        //    Assert.That(_challenge.OrderByAToZ(input), Is.EqualTo(output));
        //}

        #endregion

        #region OrderByShortestToTallest

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void OrderByShortestToTallest_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> nullOrEmptyCollectionOfPeople)
        //{
        //    Assert.That(_challenge.OrderByShortestToTallest(nullOrEmptyCollectionOfPeople), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfPeople)),
        //Description("Second Test - Return people ordered from shortest to tallest")]
        //public void OrderByShortestToTallest_Given_CollectionOfPerson_Should_ReturnCollection_OrderedShortestToTallest(IEnumerable<Person> collectionOfPeople)
        //{
        //    var (input, output) = GetPeopleMixedAndOrderedShortestToTallest(collectionOfPeople);

        //    Assert.That(_challenge.OrderByShortestToTallest(input), Is.EqualTo(output));
        //}

        #endregion

        #region OrderByLongestToShortest

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfLengths)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void OrderByLongestToShortest_Given_NullOrEmpty_CollectionOfLengths_Should_ReturnEmptyCollection(IEnumerable<Length> nullOrEmptyCollectionOfLengths)
        //{
        //    Assert.That(_challenge.OrderByLongestToShortest(nullOrEmptyCollectionOfLengths), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfLengths)),
        //Description("Second Test - Return lengths ordered from longest to shortest")]
        //public void OrderByLongestToShortest_Given_CollectionOfLength_Should_ReturnCollection_OrderedBy_LongestToShortest(IEnumerable<Length> collectionOfLengths)
        //{
        //    var (input, output) = GetLengthsMixedAndOrderedLongestToShortest(collectionOfLengths);

        //    Assert.That(_challenge.OrderByLongestToShortest(input), Is.EqualTo(output));
        //}


        #endregion

        #region OrderByLastInitialDescending

        //[TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        //Description("First Test - Return empty collection when input is null or empty")]
        //public void OrderByLastInitialDescending_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> nullOrEmptyCollectionOfPeople)
        //{
        //    Assert.That(_challenge.OrderByLastInitialDescending(nullOrEmptyCollectionOfPeople), Is.Empty);
        //}


        //[TestCaseSource(nameof(_collectionOfPeople)),
        //Description("Second Test - Return people ordered by their last initial from Z to A")]
        //public void OrderByLastInitialDescending_Given_CollectionOfPerson_Should_ReturnCollection_OrderedBy_LastInitial_FromZToA(IEnumerable<Person> collectionOfPeople)
        //{
        //    var (input, output) = GetPeopleMixedAndOrderedByLastInitialZToA(collectionOfPeople);

        //    Assert.That(_challenge.OrderByLastInitialDescending(input), Is.EqualTo(output));
        //}

        #endregion

        #region OrderByOldestToYoungest

        [TestCaseSource(nameof(_nullOrEmptyCollectionOfPeople)),
        Description("First Test - Return empty collection when input is null or empty")]
        public void OrderByOldestToYoungest_Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection(IEnumerable<Person> nullOrEmptyCollectionOfPeople)
        {
            Assert.That(_challenge.OrderByOldestToYoungest(nullOrEmptyCollectionOfPeople), Is.Empty);
        }


        [TestCaseSource(nameof(_collectionOfPeople)),
        Description("Second Test - Return people ordered from oldest to youngest")]
        public void OrderByOldestToYoungest_Given_CollectionOfPerson_Should_ReturnCollection_OrderedOldestToYoungest(IEnumerable<Person> collectionOfPeople)
        {
            var (input, output) = GetPeopleMixedAndOldestToYoungest(collectionOfPeople);

            Assert.That(_challenge.OrderByOldestToYoungest(input), Is.EqualTo(output));
        }

        #endregion
    }
}
