﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL.SCSynth
{
    public class Parameter
    {
        public string Name { get; set; }
        readonly float initValue;
        public float Value { get; set; }

        public int index { get; set; }

        public Parameter(string name = "Unnamed Parameter", float initValue = 0)
        {
            Name = name;
            this.initValue = initValue;
            this.Value = initValue;
        }

        public void Reset()
        {
            this.Value = initValue;
        }


    }
}