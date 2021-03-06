﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frevent.Model.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }

        public int? PlaceID { get; set; }
        public virtual Place Place { get; set; }
    }
}