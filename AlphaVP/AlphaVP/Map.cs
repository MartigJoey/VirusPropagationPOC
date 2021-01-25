using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVP
{
    class Map
    {
        Bitmap map;
        Pen loc;
        SolidBrush healthy;
        SolidBrush infected;
        Random rdm;
        int personSize;
        int width = 100, height = 100;

        public Bitmap GetMap { get => map; }
        public Map()
        {
            loc = new Pen(Color.Black);
            healthy = new SolidBrush(Color.Blue);
            infected = new SolidBrush(Color.Red);
            rdm = new Random();
            personSize = 3;
        }

        /// <summary>
        /// Déssine la carte sur laquel les personnes seront déssinées.
        /// </summary>
        /// <param name="nbLocation">Nombre de lieux</param>
        /// <param name="btmpSize">Taille de la zone de déssin</param>
        public void DrawMap(int nbLocation, Size btmpSize)
        {
            map = new Bitmap(btmpSize.Width, btmpSize.Height);
            int x, y = 0;

            using (Graphics g = Graphics.FromImage(map))
            {
                for (int i = 0; i < nbLocation; i++)
                {
                    x = i * width;
                    g.DrawRectangle(loc, x, y, width, height);
                }
            }
        }

        /// <summary>
        /// Déssine les personnes dans les lieux en différenciant les infectés des non-infecté par un code couleur.
        /// </summary>
        /// <param name="infectedByLocation">Liste contenant le nombre d'infecté par lieux. (Un lieu est un index)</param>
        /// <param name="healthyByLocation">Liste contenant le nombre de personne saine par lieux. (Un lieu est un index)</param>
        /// <param name="nbLocation">Nombre de lieux</param>
        /// <param name="btmpSize">Taille de la zone de déssin</param>
        public void DrawPersons(List<int> infectedByLocation, List<int> healthyByLocation, int nbLocation, Size btmpSize, PaintEventArgs e)
        {
            int x, y = 0;

            for (int i = 0; i < nbLocation; i++)
            {
                x = i * width;
                for (int j = 0; j < infectedByLocation[i]; j++)
                {
                    e.Graphics.FillRectangle(infected, rdm.Next(x, x + width), rdm.Next(y, y + height), personSize, personSize);
                }

                for (int j = 0; j < healthyByLocation[i]; j++)
                {
                    e.Graphics.FillRectangle(healthy, rdm.Next(x, x + width), rdm.Next(y, y + height), personSize, personSize);
                }
            }
        }
    }
}
