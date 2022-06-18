using LinqChallenge.Domain.Enums;

namespace LinqChallenge.Domain.Entities
{
    public class Person
    {
        private static int _countOfPeopleCreated = 0;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        // This Age isn't a perfect calculation - but it will do for this project :)
        public int Age => DateTime.UtcNow.Year - DateOfBirth.Year;

        public Length Height { get; set; }

        public Color FavoriteColor { get; set; }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Length height, Color favoriteColor)
        {
            Id = ++_countOfPeopleCreated;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Height = height;
            FavoriteColor = favoriteColor;
        }
    }
}