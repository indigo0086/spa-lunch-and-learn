using System.Collections.Generic;

namespace LunchAndLearnService.Models
{
    public class Stats
    {
        public int PlacesCount { get; set; }
        public int GroupsCount { get; set; }
        public int EventsCount { get; set; }
    }

    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<int> MemberIds { get; set; }
        public ICollection<int> EventIds { get; set; }
    }

    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Suggestion> Suggestions { get; set; }
    }

    public class Suggestion
    {
        public int SuggestionId { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Place
    {
        public int PlaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}