﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMasterTutorial.Model
{
    class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}