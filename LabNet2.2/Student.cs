﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2._2
{
    class Student
    {
        public string Disclaimer { set; get; }
        public string License { set; get; }
        public int TimeStamp { set; get; }

        public string Baza { set; get; }
        public  Dictionary<string,decimal> Rates { set; get; }
    }
}