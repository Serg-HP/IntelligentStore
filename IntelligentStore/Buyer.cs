﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStore
{
    class Buyer:Worker
    {
        public int Cash { get; set; }
        public Buyer(int id, string firstName, string secondName, DateTime birthTime, Professions profession, int cash): base(id, firstName, secondName, birthTime, profession)
        {
            Cash = cash;
        }
    }
}
