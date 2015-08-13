using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Monitor
{
    public partial class HardwareMonitor : Form
    {
        public HardwareMonitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            color_change();
            overview_btn.BackColor = Color.White;
            overview_btn.ForeColor = Color.MidnightBlue;
        }
        public void color_change()
        {
            overview_btn.BackColor = Color.MidnightBlue;
            overview_btn.ForeColor = Color.White;

            os_btn.BackColor = Color.MidnightBlue;
            os_btn.ForeColor = Color.White;

            mainBoard_btn.BackColor = Color.MidnightBlue;
            mainBoard_btn.ForeColor = Color.White;

            cpu_btn.BackColor = Color.MidnightBlue;
            cpu_btn.ForeColor = Color.White;

            memory_btn.BackColor = Color.MidnightBlue;
            memory_btn.ForeColor = Color.White;

            Disk_btn.BackColor = Color.MidnightBlue;
            Disk_btn.ForeColor = Color.White;

            graphics_btn.BackColor = Color.MidnightBlue;
            graphics_btn.ForeColor = Color.White;

            hardDrive_btn.BackColor = Color.MidnightBlue;
            hardDrive_btn.ForeColor = Color.White;
        }

        private void os_btn_Click(object sender, EventArgs e)
        {
            color_change();
            os_btn.BackColor = Color.White;
            os_btn.ForeColor = Color.MidnightBlue;
        }

        private void mainBoard_btn_Click(object sender, EventArgs e)
        {
            color_change();
            mainBoard_btn.BackColor = Color.White;
            mainBoard_btn.ForeColor = Color.MidnightBlue;
        }

        private void cpu_btn_Click(object sender, EventArgs e)
        {
            color_change();
            cpu_btn.BackColor = Color.White;
            cpu_btn.ForeColor = Color.MidnightBlue;
        }

        private void memory_btn_Click(object sender, EventArgs e)
        {
            color_change();
            memory_btn.BackColor = Color.White;
            memory_btn.ForeColor = Color.MidnightBlue;
        }

        private void Disk_btn_Click(object sender, EventArgs e)
        {
            color_change();
            Disk_btn.BackColor = Color.White;
            Disk_btn.ForeColor = Color.MidnightBlue;
        }

        private void graphics_btn_Click(object sender, EventArgs e)
        {
            color_change();
            graphics_btn.BackColor = Color.White;
            graphics_btn.ForeColor = Color.MidnightBlue;
        }

        private void hardDrive_btn_Click(object sender, EventArgs e)
        {
            color_change();
            hardDrive_btn.BackColor = Color.White;
            hardDrive_btn.ForeColor = Color.MidnightBlue;
        }
    }
}
