using LinqChallenge.Domain.Constants;
using LinqChallenge.Domain.Interfaces;

namespace LinqChallenge.Domain.Factories
{
    public class RandomStringFactory : IRandomStringFactory
    {
        private static readonly Random _random = new();

        private readonly IEnumerable<string> _stringSource;

        private List<string> _usedStrings = new();

        private bool _allStringsHaveBeenUsed = false;


        /// <summary>
        /// Pass in a collection of strings. The factory will return strings that have not been used.
        /// </summary>
        /// <param name="stringSource"></param>
        public RandomStringFactory(IEnumerable<string> stringSource)
        {
            _stringSource = stringSource;
        }

        // Exposed Members
        public string GetRandom() => AddToUsedListAndReturn(RandomStringFromSource);

        public string GetRandomUnique() => AddToUsedListAndReturn(GetUnique());

        public string GetRandomContaining(string str)
        {
            throw new NotImplementedException();
        }

        public string GetRandomNotContaining(string str)
        {
            throw new NotImplementedException();
        }


        //Clear Used Strings
        public void ClearUsedStrings()
        { 
            _usedStrings.Clear(); 
            _allStringsHaveBeenUsed = false;
        }


        /// <summary>
        /// Get a unique string - One that has not been returned according to our UsedList
        /// </summary>
        /// <returns></returns>
        private string GetUnique()
        {
            var newString = RandomStringFromSource;

            while (_usedStrings.Contains(newString))
            {
                newString += RandomLetter;
            }

            return newString;
        }


        private string AddToUsedListAndReturn(string str)
        {
            _usedStrings.Add(str);

            if(!_allStringsHaveBeenUsed && _usedStrings.Count > _stringSource.Count())
            {
                _allStringsHaveBeenUsed = true;
            }

            return str;
        }


        //string GenerateUniqueString => _allStringsHaveBeenUsed ? AppendLetterIfUsed(RandomStringFromSource) : RandomStringFromSource;       
        static IEnumerable<char> AppendLetter(string str) => str.Append(RandomLetter);
        
        static char RandomLetter => Strings.Alphabet.ElementAt(_random.Next(Strings.Alphabet.Length));

        string RandomStringFromSource => _stringSource.ElementAt(_random.Next(_stringSource.Count()));
    }
}
