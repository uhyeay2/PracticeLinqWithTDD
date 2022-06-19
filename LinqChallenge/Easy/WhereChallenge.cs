using LinqChallenge.Domain.Entities;
using System.Linq;

namespace LinqChallenge.Easy
{
    public class WhereChallenge
    {
        /*  GetPeopleOlderThanEighteen - Recommended Requirements          
        
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_PeopleWhere_NoneAreOlderThanEighteen_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeAreOlderThanEighteen_Should_ReturnOnlyPeople_OlderThanEighteen                        
        */
        public IEnumerable<Person> GetPeopleOlderThanEighteen(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /*  GetPeopleWhoHaveTheFavoriteColorBlue - Recommended Requirements 
                 
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_PeopleWhere_NoneHaveFavoriteColorBlue_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeHaveFavoriteColorBlue_Should_ReturnOnlyPeople_WithFavoriteColorBlue
        */
        public IEnumerable<Person> GetPeopleWhoHaveTheFavoriteColorBlue(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /*  GetPeopleBornInApril - Recommended Requirements 
                 
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_PeopleWhere_NoneAreBornInApril_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeAreBornInApril_Should_ReturnOnlyPeople_BornInApril
        */
        public IEnumerable<Person> GetPeopleBornInApril(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /*  GetPeopleWhoseLastNameStartsWithA - Recommended Requirements 
                 
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_PeopleWhere_NoLastNameStartsWithA_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeLastNamesStartsWithA_Should_ReturnOnlyPeople_WhoseLastNameStartsWithA
        */
        public IEnumerable<Person> GetPeopleWhoseLastNameStartsWithA(IEnumerable<Person> people)
        {
            throw new NotImplementedException();
        }

        /*  GetPeopleWhereFullNameContainsLetterO - Recommended Requirements 
                 
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_NullOrEmpty_CollectionOfPerson_Should_ReturnEmptyCollection
            Given_CharProvided_IsNotALetter_Should_ThrowException_WithMessage_CharacterProvidedMustBeALetter
            Given_PeopleWhere_NoFullName_ContainsCharProvided_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeFullNames_ContainCharProvided_Should_ReturnOnlyPeople_WhoseFullNameContainsCharProvided
        */
        public IEnumerable<Person> GetPeopleWhereFullNameContainsChar(IEnumerable<Person> people, char c)
        {
            throw new NotImplementedException();
        }

        /*  GetPeopleTallerThan - Recommended Requirements 
                 
            These are suggested names for your tests. They should be descriptive enough for you to create an assertion.

            Given_HeightIsNull_Should_ThrowException_WithMessage_InvalidHeightReceived
            Given_HeightIsZero_Should_ThrowException_WithMessage_InvalidHeightReceived
            Given_NullOrEmpty_CollectionOfPeople_Should_ReturnEmptyCollection
            Given_PeopleWhere_NoneAreTaller_ThanHeightProvided_Should_ReturnEmptyCollection
            Given_PeopleWhere_SomeAreTaller_ThanHeightProvided_Should_ReturnOnlyPeople_TallerThanHeightProvided
        */
        public IEnumerable<Person> GetPeopleTallerThan(IEnumerable<Person> people, Length height)
        {
            throw new NotImplementedException();
        }

        /*  Are you done?
           
            If so, Congratulations! You've reached the end of my Easy challenges for Linq's .Where() method.

            Do you have any ideas for more methods/tests? Feel free to make up your own tests/methods.
            I'm also welcome to receiving PR contributions that follow the same flow as the rest of this project (across all branches).
            
            Thank you for taking the time to use my repository,
            Daniel Aguirre
        */
    }
}