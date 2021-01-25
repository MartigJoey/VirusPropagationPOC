using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Measure
    {
        float protection;
        public float Protection { get => protection; set => protection = value; }
        public Measure(float protection)
        {
            this.Protection = protection;
        }
    }
}