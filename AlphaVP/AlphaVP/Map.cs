using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVP
{
    class Map
    {
        public Map()
        {
            
        }

        public Bitmap DrawMap(List<int> infectedByLocation, Size btmpSize)
        {
            Bitmap map = new Bitmap(btmpSize.Width, btmpSize.Height);

            for (int i = 0; i < infectedByLocation.Count; i++)
            {
                // Graphics
            }

            return map;
        }
    }
}
