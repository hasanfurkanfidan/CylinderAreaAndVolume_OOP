using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forth_Question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Cylinder cy = new Cylinder();
            cy.r = Convert.ToDouble(txtr.Text);
            cy.h = Convert.ToDouble(txth.Text);
            lblarea.Text = cy.calculatearea().ToString();
            lblvolume.Text = cy.calculatevolume().ToString();
        }
    }
}
class Cylinder
{
    public double r;
    public double h;
    double area;
    double volume;
    void areavolumeCalculate()
    {
        area = 2 * 3.14 * r * h + 2 * 3.14 * r * r;
        volume = 3.14 * r * r * h;
    }
    public double calculatearea()
    {
        areavolumeCalculate();
        return area;
    }
    public double calculatevolume()
    {
        areavolumeCalculate();
        return volume;
    }
}