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

            Groups = new List<Group>
            {
                new Group { GroupId = 1, Name = "The Great Outdoors",   Description = "Outdoor activities, Get off the couch", MemberIds = new [] { 1, 3, 4 }},
                new Group { GroupId = 2, Name = "Weekend Nightlife",    Description = "Weekend starts Friday", MemberIds = new [] { 1, 2 } },
                new Group { GroupId = 3, Name = "Dog's BBQ Tuesdays",   Description = "Some Guy Named Dog eats bbq on tuesdays", MemberIds = new [] { 2, 3, 4 } }
            };

            Places = new List<Place>
            {
                new Place { PlaceId = 1, Name = "Kentucky Nowhere",         Description = "Middle of nowhere in kentucky",  Address = "Cr-1078, Ravenna, KY 40472" },
                new Place { PlaceId = 2, Name = "Linger Bickin' Farbeceu",  Description = "Great BBQ",  Address = "Florida 84, Davie, FL 33317" },
                new Place { PlaceId = 3, Name = "Camp Site",                Description = "Unknown Camp-site ",  Address = "TBA" },
                new Place { PlaceId = 4, Name = "YOLLADBO",                 Description = "Hip Club",  Address = "1745 Alton Rd, Miami Beach, FL 33140" },
                new Place { PlaceId = 5, Name = "Da Club",                  Description = "",  Address = "184 SN 12th Ct." },
                new Place { PlaceId = 6, Name = "Da Pub",                   Description = "",  Address = "185 SN 12th Ct." }
            };
        }
    }
}