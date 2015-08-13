namespace Hardware_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soundCard_label = new System.Windows.Forms.Label();
            this.networkAdapter_label = new System.Windows.Forms.Label();
            this.hardDrive_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.graphicsCard_label = new System.Windows.Forms.Label();
            this.overview_level = new System.Windows.Forms.Label();
            this.disk_label = new System.Windows.Forms.Label();
            this.os_label = new System.Windows.Forms.Label();
            this.memory_label = new System.Windows.Forms.Label();
            this.mainBoard_label = new System.Windows.Forms.Label();
            this.cpu_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cpu.PNG");
            this.imageList1.Images.SetKeyName(1, "graphic card.PNG");
            this.imageList1.Images.SetKeyName(2, "hard drive.PNG");
            this.imageList1.Images.SetKeyName(3, "main board.PNG");
            this.imageList1.Images.SetKeyName(4, "memory.PNG");
            this.imageList1.Images.SetKeyName(5, "network adapter.PNG");
            this.imageList1.Images.SetKeyName(6, "overview.PNG");
            this.imageList1.Images.SetKeyName(7, "sound card.PNG");
            this.imageList1.Images.SetKeyName(8, "images.jpg");
            this.imageList1.Images.SetKeyName(9, "images (2).png");
            this.imageList1.Images.SetKeyName(10, "disk.jpg");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Controls.Add(this.main_panel);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Overview";
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Location = new System.Drawing.Point(172, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(478, 442);
            this.main_panel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.soundCard_label);
            this.panel1.Controls.Add(this.networkAdapter_label);
            this.panel1.Controls.Add(this.hardDrive_label);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.graphicsCard_label);
            this.panel1.Controls.Add(this.overview_level);
            this.panel1.Controls.Add(this.disk_label);
            this.panel1.Controls.Add(this.os_label);
            this.panel1.Controls.Add(this.memory_label);
            this.panel1.Controls.Add(this.mainBoard_label);
            this.panel1.Controls.Add(this.cpu_label);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 442);
            this.panel1.TabIndex = 3;
            // 
            // soundCard_label
            // 
            this.soundCard_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundCard_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundCard_label.ForeColor = System.Drawing.Color.Black;
            this.soundCard_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soundCard_label.ImageKey = "sound card.PNG";
            this.soundCard_label.ImageList = this.imageList1;
            this.soundCard_label.Location = new System.Drawing.Point(0, 352);
            this.soundCard_label.Name = "soundCard_label";
            this.soundCard_label.Size = new System.Drawing.Size(173, 36);
            this.soundCard_label.TabIndex = 12;
            this.soundCard_label.Text = "          Sound Card";
            this.soundCard_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // networkAdapter_label
            // 
            this.networkAdapter_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.networkAdapter_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkAdapter_label.ForeColor = System.Drawing.Color.Black;
            this.networkAdapter_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.networkAdapter_label.ImageKey = "network adapter.PNG";
            this.networkAdapter_label.ImageList = this.imageList1;
            this.networkAdapter_label.Location = new System.Drawing.Point(0, 312);
            this.networkAdapter_label.Name = "networkAdapter_label";
            this.networkAdapter_label.Size = new System.Drawing.Size(173, 36);
            this.networkAdapter_label.TabIndex = 11;
            this.networkAdapter_label.Text = "          Network Adapter";
            this.networkAdapter_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hardDrive_label
            // 
            this.hardDrive_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardDrive_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardDrive_label.ForeColor = System.Drawing.Color.Black;
            this.hardDrive_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hardDrive_label.ImageKey = "hard drive.PNG";
            this.hardDrive_label.ImageList = this.imageList1;
            this.hardDrive_label.Location = new System.Drawing.Point(0, 274);
            this.hardDrive_label.Name = "hardDrive_label";
            this.hardDrive_label.Size = new System.Drawing.Size(173, 36);
            this.hardDrive_label.TabIndex = 10;
            this.hardDrive_label.Text = "          Hard Drive";
            this.hardDrive_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 483);
            this.panel2.TabIndex = 2;
            // 
            // graphicsCard_label
            // 
            this.graphicsCard_label.BackColor = System.Drawing.Color.White;
            this.graphicsCard_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicsCard_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsCard_label.ForeColor = System.Drawing.Color.Black;
            this.graphicsCard_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphicsCard_label.ImageKey = "graphic card.PNG";
            this.graphicsCard_label.ImageList = this.imageList1;
            this.graphicsCard_label.Location = new System.Drawing.Point(0, 234);
            this.graphicsCard_label.Name = "graphicsCard_label";
            this.graphicsCard_label.Size = new System.Drawing.Size(173, 36);
            this.graphicsCard_label.TabIndex = 9;
            this.graphicsCard_label.Text = "          Graphics Card";
            this.graphicsCard_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overview_level
            // 
            this.overview_level.BackColor = System.Drawing.Color.White;
            this.overview_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overview_level.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_level.ForeColor = System.Drawing.Color.Black;
            this.overview_level.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overview_level.ImageKey = "images.jpg";
            this.overview_level.ImageList = this.imageList1;
            this.overview_level.Location = new System.Drawing.Point(0, 0);
            this.overview_level.Name = "overview_level";
            this.overview_level.Size = new System.Drawing.Size(173, 36);
            this.overview_level.TabIndex = 3;
            this.overview_level.Text = "          Overview";
            this.overview_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disk_label
            // 
            this.disk_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disk_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_label.ForeColor = System.Drawing.Color.Black;
            this.disk_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disk_label.ImageKey = "disk.jpg";
            this.disk_label.ImageList = this.imageList1;
            this.disk_label.Location = new System.Drawing.Point(0, 194);
            this.disk_label.Name = "disk_label";
            this.disk_label.Size = new System.Drawing.Size(173, 36);
            this.disk_label.TabIndex = 8;
            this.disk_label.Text = "          Disk";
            this.disk_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // os_label
            // 
            this.os_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.os_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.os_label.ForeColor = System.Drawing.Color.Black;
            this.os_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.os_label.ImageKey = "overview.PNG";
            this.os_label.ImageList = this.imageList1;
            this.os_label.Location = new System.Drawing.Point(0, 39);
            this.os_label.Name = "os_label";
            this.os_label.Size = new System.Drawing.Size(173, 36);
            this.os_label.TabIndex = 4;
            this.os_label.Text = "          Operating System";
            this.os_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memory_label
            // 
            this.memory_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_label.ForeColor = System.Drawing.Color.Black;
            this.memory_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memory_label.ImageKey = "memory.PNG";
            this.memory_label.ImageList = this.imageList1;
            this.memory_label.Location = new System.Drawing.Point(0, 155);
            this.memory_label.Name = "memory_label";
            this.memory_label.Size = new System.Drawing.Size(173, 36);
            this.memory_label.TabIndex = 7;
            this.memory_label.Text = "          Memory";
            this.memory_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainBoard_label
            // 
            this.mainBoard_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBoard_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBoard_label.ForeColor = System.Drawing.Color.Black;
            this.mainBoard_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainBoard_label.ImageKey = "main board.PNG";
            this.mainBoard_label.ImageList = this.imageList1;
            this.mainBoard_label.Location = new System.Drawing.Point(0, 78);
            this.mainBoard_label.Name = "mainBoard_label";
            this.mainBoard_label.Size = new System.Drawing.Size(173, 36);
            this.mainBoard_label.TabIndex = 5;
            this.mainBoard_label.Text = "          Main Board";
            this.mainBoard_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpu_label
            // 
            this.cpu_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cpu_label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_label.ForeColor = System.Drawing.Color.Black;
            this.cpu_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpu_label.ImageKey = "cpu.PNG";
            this.cpu_label.ImageList = this.imageList1;
            this.cpu_label.Location = new System.Drawing.Point(0, 117);
            this.cpu_label.Name = "cpu_label";
            this.cpu_label.Size = new System.Drawing.Size(173, 36);
            this.cpu_label.TabIndex = 6;
            this.cpu_label.Text = "          CPU";
            this.cpu_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(653, 483);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Hardware Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label soundCard_label;
        private System.Windows.Forms.Label networkAdapter_label;
        private System.Windows.Forms.Label hardDrive_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label graphicsCard_label;
        private System.Windows.Forms.Label overview_level;
        private System.Windows.Forms.Label disk_label;
        private System.Windows.Forms.Label os_label;
        private System.Windows.Forms.Label memory_label;
        private System.Windows.Forms.Label mainBoard_label;
        private System.Windows.Forms.Label cpu_label;


    }
}

