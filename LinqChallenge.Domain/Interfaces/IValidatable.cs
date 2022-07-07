using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenge.Domain.Interfaces
{
    public interface IValidatable
    {
        public string? ValidationMessage { get; set; }

        bool IsValid();
    }
}
