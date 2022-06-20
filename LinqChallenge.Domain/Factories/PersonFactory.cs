using LinqChallenge.Domain.Entities;
using LinqChallenge.Domain.Enums;
using LinqChallenge.Domain.Interfaces;

namespace LinqChallenge.Domain.Factories
{
    public class PersonFactory : IPersonFactory
    {
        private readonly IRandomStringFactory _firstNames;

        private readonly IRandomStringFactory _lastNames;

        private readonly IRandomDateFactory _birthdays;

        private readonly Random _rng = new();


        public PersonFactory(IRandomStringFactory firstNames, IRandomStringFactory lastNames, IRandomDateFactory birthdays)
        {
            _firstNames = firstNames;

            _lastNames = lastNames;

            _birthdays = birthdays;
        }

        public Person CreateUnique()
        {
            return new Person(_firstNames.GetRandomUnique(), _lastNames.GetRandomUnique(), _birthdays.GetRandom(), GetRandomLength(), GetRandomColor);
        }

        public Person CreateAdult(bool createAdult = true)
        {
            var birthday = createAdult ? _birthdays.GetRandomMoreThanYearsAgo(18) : _birthdays.GetRandomLessThanYearsAgo(18);

            return new Person(_firstNames.GetRandomUnique(), _lastNames.GetRandomUnique(), birthday, GetRandomLength(), GetRandomColor);
        }

        public Person CreatePersonWhoDoesNotLikeTheColor(Color favoriteColor)
        {
            var color = GetRandomColor;

            while (color == favoriteColor)
            {
                color = GetRandomColor;
            }

            return new Person(_firstNames.GetRandomUnique(), _lastNames.GetRandomUnique(), _birthdays.GetRandom(), GetRandomLength(), color);
        }

        public Person CreatePersonWhoseNameDoesNotInclude(string stringToNotContainInNames)
        {
            var person = CreateUnique();

            person.FirstName = person.FirstName.Replace(stringToNotContainInNames, "");
            person.LastName = person.LastName.Replace(stringToNotContainInNames, "");

            return person;

        }

        public Person CreatePersonWithinHeightRange(Length minHeight, Length maxHeight)
        {
            throw new NotImplementedException();
        }

        private Color GetRandomColor => (Color)_rng.Next(0, Enum.GetValues(typeof(Color)).Length);

        private Length GetRandomLength() => new(_rng.Next(1), _rng.Next(0, 13));
    }
}
