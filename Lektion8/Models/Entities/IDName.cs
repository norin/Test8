﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion8.Models.Entities
{
    public class IDName
    {

        public IDName(Guid id) {ID = id}
        public Guid ID { get { return _ID; } }
//        private Guid ID { get; set; }
//        public string Name { get; set; }
    }
}