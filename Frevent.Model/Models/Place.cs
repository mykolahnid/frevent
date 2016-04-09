using System.Collections.Generic;

namespace Frevent.Model.Models
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property 
        public virtual ICollection<Event> Events { get; private set; }
    }
}