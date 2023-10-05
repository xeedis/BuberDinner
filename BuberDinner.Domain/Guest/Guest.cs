using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Guest.ValueObjects;
using BuberDinner.Domain.User.ValueObjects;
using BuberDinner.Domain.ValueObjects;
using BuberDinner.Domain.Dinner;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Bill.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;
using System.Diagnostics;
using BuberDinner.Domain.Guest.Entities;

namespace BuberDinner.Domain.Guest;

public sealed class Guest: AggregateRoot<GuestId>
{
    private readonly List<DinnerId> _upcomingDinnerIds = new();
    private readonly List<DinnerId> _pastDinnerIds = new();
    private readonly List<DinnerId> _pendingDinnerIds = new();
    private readonly List<BillId> _billIds = new();
    private readonly List<MenuReviewId> _menuReviewIds = new();
    private readonly List<Ratings> _ratings = new();
    public string FirstName { get; }
    public string LastName { get; }
    public string ProfileImage { get; }
    public AverageRating AverageRating { get; }
    public UserId UserId { get; }
    public IReadOnlyList<DinnerId> UpcomingDinnerIds => _upcomingDinnerIds.AsReadOnly();
    public IReadOnlyList<DinnerId> PastDinnerIds => _pastDinnerIds.AsReadOnly();
    public IReadOnlyList<DinnerId> PendingDinnerIds => _pendingDinnerIds.AsReadOnly();
    public IReadOnlyList<BillId> BillIds => _billIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
    public IReadOnlyList<Ratings> Ratings => _ratings.AsReadOnly();
    public DateTime CreatedDateTime { get; }
    public DateTime UpdateDateTime { get; }

    private Guest(
        GuestId guestId,
        string firstName,
        string lastName,
        string profileImage,
        AverageRating averageRating,
        UserId userId,
        DateTime createdDateTime,
        DateTime updatedDateTime):base(guestId)
    {
        FirstName = firstName;
        LastName = lastName;
        ProfileImage = profileImage;
        AverageRating = averageRating;
        UserId = userId;
        CreatedDateTime = createdDateTime;
        UpdateDateTime = updatedDateTime;
    }

    public static Guest Create(
        string firstName,
        string lastName,
        string profileImage,
        AverageRating averageRating,
        UserId userId)
    {
        return new(GuestId.CreateUnique(), firstName, lastName, profileImage, averageRating, userId, DateTime.UtcNow, DateTime.UtcNow);
    }

}