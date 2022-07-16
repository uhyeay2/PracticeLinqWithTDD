using LinqChallenge.Domain.Entities;
using LinqChallenge.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Easy
{
    /// <summary>
    /// OrderBy is used to order a collection in Ascending Order.
    /// In terms of numbers this would mean from lowest to highest.
    /// In terms of letters, this would mean from A to Z.
    /// In these challenges we will not only practice .OrderBy(), but we will also
    /// practice .OrderByDescending() which will order in the reverse of what's outlined above.
    /// </summary>
    public class OrderByChallenge
    {

        /*  OrderByLowestToHighest - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection
            Given_CollectionOfInts_Should_ReturnCollection_OrderedLowestToHighest          
        */
        public IEnumerable<int> OrderByLowestToHighest(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }


        /*  OrderByAToZ - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection
            Given_CollectionOfStrings_Should_ReturnCollection_OrderedAToZ          
        */
        public IEnumerable<string> OrderByAToZ(IEnumerable<string> words)
        {
            throw new NotImplementedException();
        }


        /*  OrderByShortestToTallest - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_CollectionOfPerson_Should_ReturnCollection_OrderedShortestToTallest
        */
        public IEnumerable<Person> OrderByShortestToTallest(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }


        /*  OrderByLongestToShortest - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfLengths_Should_ReturnEmptyCollection
            Given_CollectionOfLength_Should_ReturnCollection_OrderedBy_LongestToShortest
        */
        public IEnumerable<Length> OrderByLongestToShortest(IEnumerable<Length> lengths)
        {
            throw new NotImplementedException();
        }


        /*  OrderByLastInitialDescending - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_CollectionOfPerson_Should_ReturnCollection_OrderedBy_LastInitial_FromZToA         
        */
        public IEnumerable<Person> OrderByLastInitialDescending(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }


        /*  OrderByOldestToYoungest - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
             
            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_CollectionOfPerson_Should_ReturnCollection_OrderedOldestToYoungest
        */
        public IEnumerable<Person> OrderByOldestToYoungest(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

    }
}
