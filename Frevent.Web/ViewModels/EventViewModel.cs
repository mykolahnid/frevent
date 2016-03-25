using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frevent.Web.ViewModels
{
    public class EventViewModel
    {
        public int EventID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }

        public int PlaceID { get; set; }
    }
}