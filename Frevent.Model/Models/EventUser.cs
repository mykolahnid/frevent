using Frevent.Model.Enums;

namespace Frevent.Model.Models
{
    public class EventUser
    {
        public int EventUserID { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
        public EventUserStatus EventUserStatus { get; set; }
        public bool IsUserAdministrator { get; set; }
    }
}