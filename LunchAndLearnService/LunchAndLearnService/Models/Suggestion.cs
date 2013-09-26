using System.Collections.Generic;

namespace LunchAndLearnService.Models
{
    public class Suggestion
    {
        public int SuggestionID { get; set; }

        public int EventID { get; set; }
        public int PlaceID { get; set; }
        public IEnumerable<User> Users { get; set; }

        public virtual Event Event { get; set; }
        public virtual Place Place { get; set; }
    }
}