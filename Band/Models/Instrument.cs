﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Band.Models
{
    public class Instrument
    {
        public string InstrumentName { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DateIn { get; set; }
        public string Comment { get; set; }
        public string CommentIn { get; set; }
        public bool IsCheckedOut { get; set; }
        public int ID { get; set; }

    }
}