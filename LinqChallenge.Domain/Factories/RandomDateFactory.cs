using LinqChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Factories
{
    public class RandomDateFactory : IRandomDateFactory
    {
        private readonly Random _rng = new();

        private readonly DateTime _minDate;

        private readonly DateTime _maxDate;

        private readonly DateTime _todayUtc = DateTime.UtcNow;

        public int RandomYear => _rng.Next(_minDate.Year, _maxDate.Year + 1);

        public int RandomMonth => _rng.Next(1, 13);

        public int RandomDay => _rng.Next(1, 27);

        public RandomDateFactory(DateTime minDate, DateTime maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }

        public DateTime GetRandom()
        {
            DateTime date;
            do
            {
                date = new(RandomYear, RandomMonth, RandomDay);
                
            } while (date < _minDate || date > _maxDate);

            return date;
        } 

        public DateTime GetRandomWithinRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public DateTime GetRandomMoreThanYearsAgo(int minYearsAgo)
        {
            var date = GetRandom();

            if(_todayUtc.Year - date.Year < minYearsAgo)
            {
                var newYear = _rng.Next(_minDate.Year, _todayUtc.Year - minYearsAgo);
                return new(newYear, date.Month, date.Day);
            }

            return date;
        }

        public DateTime GetRandomLessThanYearsAgo(int maxYearsago)
        {
            var date = GetRandom();

            if (_todayUtc.Year - date.Year > maxYearsago)
            {
                var newYear = _rng.Next(_todayUtc.Year - maxYearsago, _maxDate.Year);
                return new(newYear, date.Month, date.Day);
            }

            return date;
        }
    }
}