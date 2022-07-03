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

        public Person CreatePersonWithinHeightRange(Length minHeight, Length maxHeight) =>
            CreateSpecific(height: new(_rng.Next(minHeight.Centimeters, maxHeight.Centimeters)));

       
        public Person CreateAdult(bool createAdult = true) => CreateSpecific(createAdult: createAdult);

        public Person CreateUnique() => new(_firstNames.GetRandomUnique(), _lastNames.GetRandomUnique(), _birthdays.GetRandom(), GetRandomLength(), GetRandomColor());

        public Person CreateSpecific(string? firstName = null, string? lastName = null, DateTime? birthday = null,
            Length? height = null, Color? favoriteColor = null, bool? createAdult = null) =>
            new Person( 
                firstName?? _firstNames.GetRandomUnique(), 
                lastName ?? _lastNames.GetRandomUnique(),
                birthday ?? (createAdult.HasValue ? createAdult.Value ? _birthdays.GetRandomMoreThanYearsAgo(18)
                    : _birthdays.GetRandomLessThanYearsAgo(18) : _birthdays.GetRandom()),
                height ?? GetRandomLength(), 
                favoriteColor ?? GetRandomColor()
            );
        
        public Person CreatePersonWhoDoesNotLikeTheColor(Color colorToDislike) 
        {
            var person = CreateUnique();

            while(person.FavoriteColor == colorToDislike)
            {
                person.FavoriteColor = GetRandomColor();
            }

            return person;
        }
              
        public Person CreatePersonWhoseNameDoesNotInclude(string stringToNotContainInNames)
        {
            var person = CreateUnique();

            person.FirstName = person.FirstName.ToLower().Replace(stringToNotContainInNames.ToLower(), "");
            person.LastName = person.LastName.ToLower().Replace(stringToNotContainInNames.ToLower(), "");

            return person;
        }

        private Color GetRandomColor() => (Color)_rng.Next(0, Enum.GetValues(typeof(Color)).Length);

        private Length GetRandomLength() => new(_rng.Next(1), _rng.Next(0, 13));
    }
}
