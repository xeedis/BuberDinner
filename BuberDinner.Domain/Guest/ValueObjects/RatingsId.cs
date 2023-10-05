using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Guest.ValueObjects;

public sealed class RatingsId : ValueObject
{
    public Guid Value { get; set; }

    private RatingsId(Guid value)
    {
        Value = value;
    }

    public static RatingsId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}