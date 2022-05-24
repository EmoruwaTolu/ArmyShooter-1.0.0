using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Army_shooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This opens a new form
            Army_Shooter_Rennes form2 = new Army_Shooter_Rennes();
            form2.ShowDialog(); 
        }
    }
}
