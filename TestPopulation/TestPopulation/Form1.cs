using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPopulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnGenerate_Click(object sender, EventArgs e)
        {
            lblNbObject.Text = await GeneratePopulation();
        }

        private async void BtnGenerate2_Click(object sender, EventArgs e)
        {
            label1.Text = await GeneratePopulation();
        }

        private async Task<string> GeneratePopulation()
        {
            return await Task.Run(() => {
                List<Person> areInfected = new List<Person>();
                for (int i = 0; i < /*8.57f */ 100000000; i++)
                {
                    areInfected.Add(new Person());
                }
                return areInfected.Count.ToString();
            });
        }
    }
}
