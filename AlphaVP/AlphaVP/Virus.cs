using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Virus
    {
        // Type of propagation
        // Chances of propagation
        float propagation;
        // effect on person

        public float Propagation { get => propagation; }
        public Virus()
        {
            propagation = CalculatePropagation();
        }

        private float CalculatePropagation()
        {
            return 0.1f;
        }
    }
}
