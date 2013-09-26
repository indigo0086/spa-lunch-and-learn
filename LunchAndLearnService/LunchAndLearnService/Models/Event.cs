using System;
using System.Collections.Generic;

namespace LunchAndLearnService.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User Creator { get; set; }
        public IEnumerable<Suggestion> Suggestions { get; set; }
        public DateTime Date { get; set; }
        public RecurringType RecurringType { get; set; }
    }
}