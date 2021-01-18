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
        Simulation sim = new Simulation(50);
        Map map = new Map();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void time_Tick(object sender, EventArgs e)
        {
            sim.Action();

            lblNbPerson.Text = sim.CalculateNbPersons().ToString();
            lblNbInfected.Text = sim.CalculateNbInfected().ToString();

            Console.WriteLine("Infected by location :");
            foreach (var item in sim.GetNbInfectedByLocation())
            {
                Console.WriteLine(item);
            }

            pcbVisual.Image = map.DrawMap(sim.GetNbInfectedByLocation(), pcbVisual.Size);
        }
    }
}
