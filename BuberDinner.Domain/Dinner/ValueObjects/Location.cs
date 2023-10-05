using BuberDinner.Domain.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Dinner.ValueObjects;

public sealed class Location : ValueObject
{
    public string Name { get; private set; }
    public string Address { get; private set; }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }

    private Location(string name, string address, double latitude = 0, double longitude = 0)
    {
        Name = name;
        Address = address;
        Latitude = latitude;
        Longitude = longitude;
    }

    public static Location CreateNew(string name, string address, double latitude, double longitude)
    {
        return new(name, address, latitude, longitude);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name; 
        yield return Address; 
        yield return Latitude; 
        yield return Longitude;
    }
}