using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frevent.Model.Models
{
    public class FriendRequest
    {
        public int FriendRequestID { get; set; }
        public User Requester { get; set; }
        public User Requestee { get; set; }
    }
}
