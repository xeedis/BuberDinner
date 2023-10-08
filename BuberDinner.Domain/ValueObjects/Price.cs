using BuberDinner.Domain.Common.Models;
namespace BuberDinner.Domain.ValueObjects;

public sealed class Price : ValueObject
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}