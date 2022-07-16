using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection) => collection == null || !collection.Any();

        public static IEnumerable<string> FizzBuzz(this IEnumerable<int> numbers) => numbers.Select(x =>
            x % 3 == 0 ? x % 5 == 0 ? "FizzBuzz" : "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}");
    }
}
