using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Interfaces
{
    public interface IRandomStringFactory
    {
        // Get Random First Name
        string GetRandom();

        string GetRandomUnique();

        string GetRandomContaining(string str);
        
        string GetRandomNotContaining(string str);
    }
}
