using LinqChallenge.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Tests.Easy
{
    public class OrderByChallengeTests
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

        #region Test Cases

        private static readonly TestDataFactories _testData = new();

        public static readonly object[] _nullOrEmptyCollectionOfInts = _testData.EmptyCollection<int>();
        
        public static readonly object[] _nullOrEmptyCollectionOfStrings = _testData.EmptyCollection<string>();

        private static readonly IEnumerable<IEnumerable<string>> _collectionOfStrings = _testData.CollectionOfStrings;

        private static readonly IEnumerable<IEnumerable<int>> _collectionOfNumbers = _testData.CollectionOfRandomNumbersFromOneToThreeHundred;

        private (IEnumerable<T> Input, IEnumerable<T> Output) GetMixedAndOrderedCollection<T>(IEnumerable<T> numbers)
        {
            var mixed = numbers.ToArray();

            var ordered = mixed.OrderBy(x => x).ToArray();

            return (mixed, ordered);
        }

        #endregion

    }
}
