using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraPop
{
    public partial class Form1 : Form
    {
        GrowHeads temp = new GrowHeads();

        public Form1()
        {
            InitializeComponent();
        }

        public void recreate(int headCount)
        {
            if(headCount < 3)
            {
                InitializeComponent();
                headCount++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            temp.Grow(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
