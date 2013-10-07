using System;
using System.Collections.Generic;
using LunchAndLearnService.Models;

namespace LunchAndLearnService.Data
{
    public class LunchAndLearnRepository
    {
        public List<User> Users { get; set; }
        public List<Group> Groups { get; set; }
        public List<Event> Events { get; set; }
        public List<Place> Places { get; set; }

        public LunchAndLearnRepository()
        {
            Users = new List<User>
            {
                new User { UserId = 1, Name = "MonsterMash",    Email = "mmmmm@gmail.com" }, 
                new User { UserId = 2, Name = "SirTestAlot",    Email = "testalot@hotmail.com" }, 
                new User { UserId = 3, Name = "AlphaOBeta",     Email = "alphao@gmail.com" }, 
                new User { UserId = 4, Name = "WhaltWhitman",   Email = "iamthedanger@hotmail.com" }
            };

            Places = new List<Place>
            {
                new Place { PlaceId = 1, Name = "Kentucky Nowhere",     Description = "Middle of nowhere in kentucky",  Address = "Cr-1078, Ravenna, KY 40472" },
                new Place { PlaceId = 2, Name = "Finger Lickin Bbq",    Description = "Great BBQ",  Address = "Florida 84, Davie, FL 33317" },
                new Place { PlaceId = 3, Name = "Camp Site",            Description = "Unknown Camp-site ",  Address = "TBA" },
                new Place { PlaceId = 4, Name = "YOLLADBO",             Description = "Hip Club",  Address = "1745 Alton Rd, Miami Beach, FL 33140" },
                new Place { PlaceId = 5, Name = "Da Club",              Description = "",  Address = "184 SN 12th Ct." },
                new Place { PlaceId = 6, Name = "Da Pub",               Description = "",  Address = "185 SN 12th Ct." },
                new Place { PlaceId = 7, Name = "Bonnanos Ristorante",  Description = "Incredible italian food"}
            };

            Events = new List<Event>
            {
                new Event {EventId = 1, Name = "Hiking Trip", Description = "Find some new places to hike"}
            };

            Groups = new List<Group>
            {
                new Group { GroupId = 1, Name = "The Great Outdoors",   Description = "Outdoor activities, Get off the couch", 
                    Members = new [] { Users[0], Users[2], Users[3] },
                    Places = new [] { Places[0], Places[2] }},
                new Group { GroupId = 2, Name = "Weekend Nightlife",    Description = "Weekend starts Friday", 
                    Members = new [] { Users[0], Users[1] },
                    Places = new [] { Places[2], Places[3], Places[4], Places[5] }},
                new Group { GroupId = 3, Name = "Foodies",   Description = "Suggest some food places.", 
                    Members = new [] { Users[1], Users[2], Users[3] },
                    Places = new [] { Places[1], Places[6] }}
            };
        }
    }
}