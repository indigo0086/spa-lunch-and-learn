using System.Collections.Generic;

namespace LunchAndLearnService.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<Event> Events { get; set; }
    }
}