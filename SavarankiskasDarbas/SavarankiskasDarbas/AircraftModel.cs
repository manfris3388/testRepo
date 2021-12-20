﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavarankiskasDarbas
{
    public class AircraftModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public AircraftModel(int id, string number, string description)
        {
            Id = id;
            Number = number;
            Description = description;
        }
    }
}
