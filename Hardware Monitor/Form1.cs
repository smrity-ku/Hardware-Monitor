using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hardware_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            paint();
            mainBoard_label.BackColor = Color.Gainsboro;
        }

        private void overview_level_Click(object sender, EventArgs e)
        {
            paint();
            overview_level.BackColor = Color.Gainsboro;
        }

        private void os_label_Click(object sender, EventArgs e)
        {
            paint();
            os_label.BackColor = Color.Gainsboro;
        }

        private void cpu_label_Click(object sender, EventArgs e)
        {
            paint();
            cpu_label.BackColor = Color.Gainsboro;
        }

        private void memory_label_Click(object sender, EventArgs e)
        {
            paint();
            memory_label.BackColor = Color.Gainsboro;
        }

        private void disk_label_Click(object sender, EventArgs e)
        {
            paint();
            disk_label.BackColor = Color.Gainsboro;
        }

        private void graphicsCard_label_Click(object sender, EventArgs e)
        {
            paint();
            graphicsCard_label.BackColor = Color.Gainsboro;
        }

        private void hardDrive_label_Click(object sender, EventArgs e)
        {
            paint();
            hardDrive_label.BackColor = Color.Gainsboro;
        }

        private void networkAdapter_label_Click(object sender, EventArgs e)
        {
            paint();
            networkAdapter_label.BackColor = Color.Gainsboro;
        }

        private void soundCard_label_Click(object sender, EventArgs e)
        {
            paint();
            soundCard_label.BackColor = Color.Gainsboro;
        }

        public void paint()
        {
            mainBoard_label.BackColor = Color.White;
            overview_level.BackColor = Color.White;
            os_label.BackColor = Color.White;
            cpu_label.BackColor = Color.White;
            memory_label.BackColor = Color.White;
            disk_label.BackColor = Color.White;
            graphicsCard_label.BackColor = Color.White;
            hardDrive_label.BackColor = Color.White;
            networkAdapter_label.BackColor = Color.White;
            soundCard_label.BackColor = Color.White;
        }
    }
}
