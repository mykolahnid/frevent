using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frevent.Web.ViewModels
{
    public class EventFormViewModel
    {
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string EventName { get; set; }
    }
}