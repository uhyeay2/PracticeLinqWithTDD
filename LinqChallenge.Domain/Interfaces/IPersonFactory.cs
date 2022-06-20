using LinqChallenge.Domain.Entities;
using LinqChallenge.Domain.Enums;

namespace LinqChallenge.Domain.Interfaces
{
    public interface IPersonFactory
    {
        /// <summary>
        /// This method will return a Person who is unique - this factory has never created a person with the same name before.
        /// Other properties are also randomized.
        /// </summary>
        /// <returns></returns>
        Person CreateUnique();

        Person CreatePersonWhoDoesNotLikeTheColor(Color favoriteColor);

        Person CreatePersonWithinHeightRange(Length minHeight, Length maxHeight);

        Person CreateAdult(bool createAdult = true);

        Person CreatePersonWhoseNameDoesNotInclude(string stringToNotContainInNames);
    }
}
