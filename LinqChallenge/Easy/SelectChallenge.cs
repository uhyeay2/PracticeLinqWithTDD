using LinqChallenge.Domain.Entities;
using LinqChallenge.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Easy
{
    /*
        Select Is used to transform a collection of objects. This is helpful in many ways.
        
        In these challenges we can practice using Select to return a property of an object,
        or to transform a collection to alter each of the elements in some way.         
    */
    public class SelectChallenge
    {

        /*  GetBirthdays - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
 
            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_CollectionOfPeople_Should_Return_TheirBirthdays
        */
        public IEnumerable<DateTime> GetBirthdays(IEnumerable<Person> people)
        {
            return people.IsNullOrEmpty() ? Enumerable.Empty<DateTime>() : people.Select(p => p.DateOfBirth);
        }


        /*  ConvertToUppercase - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
 
            Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection
            Given_CollectionOfStrings_Should_ReturnStrings_AllUppercase
        */
        public IEnumerable<string> ConvertToUppercase(IEnumerable<string> input)
        {
            return input.IsNullOrEmpty() ? Enumerable.Empty<string>() : input.Select(s => s.ToUpper());
        }


        /*  SelectInches - Recommended Requirements
          
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.
 
            Given_NullOrEmpty_CollectionOfLengths_Should_ReturnEmptyCollection
            Given_CollectionOfLengths_Should_ReturnInches_FromEachLength
        */
        public IEnumerable<int> SelectInches(IEnumerable<Length> collectionOfLengths)
        {
            return collectionOfLengths.IsNullOrEmpty() ? Enumerable.Empty<int>() : collectionOfLengths.Select(l => l.Inches);
        }


        /*  DivideNumbers - Recommended Requirements

            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection
            Given_NumberToDivideBy_IsZero_Should_ThrowException_WithMessage
            Given_CollectionOfInts_AndNotDividngByZero_Should_ReturnNumbers_DividedByNumberProvided
        */
        public IEnumerable<int> DivideNumbers(IEnumerable<int> numbers, int numberToDivideBy)
        {
            return numbers.IsNullOrEmpty() ? Enumerable.Empty<int>()
                : numberToDivideBy != 0 ? numbers.Select(n => n / numberToDivideBy)
                : throw new Exception("Invalid Input! Cannot Divide By Zero!");
        }


        /*  ParseCollection - Recommended Requirements

            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfStrings_Should_ReturnEmptyCollection
            Given_CollectionOfStrings_WhereAllAreNumbers_Should_ReturnStrings_ParsedIntoInts
            Given_CollectionOfStrings_ContainsStrings_ThatAreNotNumbers_Should_ReturnZero_ForStringsThatCannotParse
        */
        public IEnumerable<int> ParseCollection(IEnumerable<string> possibleNumbers)
        {
            return possibleNumbers.IsNullOrEmpty() ? Enumerable.Empty<int>()
                : possibleNumbers.Select(x => int.TryParse(x, out var n) ? n : 0);
        }


        /*  ConvertToThePowerOfIndex - Recommended Requirements

            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfInts_Should_ReturnEmptyCollection
            Given_CollectionOfInts_Should_ReturnNumbers_ToThePowerOf_TheirIndex

            Let us consider the collection below:

            { 42, 3, 2, 5, 2 }

            Each number should be transformed to the power of its index.

            The first index is zero, any number to the power of zero will return 1.
            The second index is 1, any number to the power of one will be itself.
            The third index is 2, so transform this number to the power of 2

            The above collection would be transformed to:

            { 1, 3, 4, 125, 16}

            Again, this is (1 ^0), (3 ^1), (2 ^2), (5 ^3), (2 ^4) - Each of these is the Element to the power of its index

            Hint - You can use Math.Pow
            Another Hint - You can not only do .Select(x => ... ) - but you can also do .Select( (x, i) => ... )

        */
        public IEnumerable<int> ConvertToThePowerOfIndex(IEnumerable<int> numbers)
        {
            return numbers.IsNullOrEmpty() ? Enumerable.Empty<int>() : numbers.Select((x, i) => (int)Math.Pow(x, i));
        }
    }
}
