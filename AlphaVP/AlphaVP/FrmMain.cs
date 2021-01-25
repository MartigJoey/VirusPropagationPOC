using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaVP
{
    public partial class FrmMain : Form
    {
        Simulation sim;
        Map map;
        int nbLocations;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            nbLocations = 5;
            sim = new Simulation(50, nbLocations);
            map = new Map();
            map.DrawMap(nbLocations, pcbVisual.Size);
            pcbVisual.Image = map.GetMap;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            sim.Action();

            lblNbPerson.Text = sim.CalculateNbPersons().ToString();
            lblNbInfected.Text = sim.CalculateNbInfected().ToString();

            tbxData.Text = "Infected by location :" + Environment.NewLine;
            foreach (int nbInfected in sim.GetInfected())
            {
                tbxData.Text += nbInfected + Environment.NewLine;
            }

            this.Refresh();
            pcbVisual.Image = map.GetMap;
        }

        private void VisualPaint(object sender, PaintEventArgs e)
        {
            map.DrawPersons(sim.GetInfected(), sim.GetHealthy(), nbLocations, pcbVisual.Size, e); // donner liste de lieux
        }

        private void PlayBreak_Click(object sender, EventArgs e)
        {
            time.Enabled = !time.Enabled;
        }
    }
}
