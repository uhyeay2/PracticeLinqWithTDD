using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Interfaces
{
    public interface IRandomDateFactory
    {
        DateTime GetRandom();

        DateTime GetRandomWithinRange(DateTime start, DateTime end);

        DateTime GetRandomMoreThanYearsAgo(int minYearsAgo);

        DateTime GetRandomLessThanYearsAgo(int maxYearsago);
    }
}
