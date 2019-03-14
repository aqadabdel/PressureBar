namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_srport = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.cb_interval = new System.Windows.Forms.ComboBox();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_mbar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_srport
            // 
            this.lbl_srport.AutoSize = true;
            this.lbl_srport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srport.Location = new System.Drawing.Point(29, 30);
            this.lbl_srport.Name = "lbl_srport";
            this.lbl_srport.Size = new System.Drawing.Size(73, 16);
            this.lbl_srport.TabIndex = 0;
            this.lbl_srport.Text = "Serial Port:";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(110, 29);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(71, 21);
            this.cb_port.TabIndex = 1;
            this.cb_port.SelectedIndexChanged += new System.EventHandler(this.cb_port_SelectedIndexChanged);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("OpenSymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(70, 25);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(262, 79);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "00:00:00";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(15, 255);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(190, 39);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(217, 255);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(189, 39);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // cb_interval
            // 
            this.cb_interval.FormattingEnabled = true;
            this.cb_interval.Location = new System.Drawing.Point(110, 64);
            this.cb_interval.Name = "cb_interval";
            this.cb_interval.Size = new System.Drawing.Size(71, 21);
            this.cb_interval.TabIndex = 6;
            this.cb_interval.SelectedIndexChanged += new System.EventHandler(this.cb_interval_SelectedIndexChanged);
            // 
            // lbl_interval
            // 
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interval.Location = new System.Drawing.Point(29, 65);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(72, 16);
            this.lbl_interval.TabIndex = 5;
            this.lbl_interval.Text = "Interval (s):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_srport);
            this.groupBox1.Controls.Add(this.cb_port);
            this.groupBox1.Controls.Add(this.cb_interval);
            this.groupBox1.Controls.Add(this.lbl_interval);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_exp);
            this.groupBox2.Controls.Add(this.lbl_mbar);
            this.groupBox2.Location = new System.Drawing.Point(212, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pressure mBar";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Location = new System.Drawing.Point(146, 19);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(0, 13);
            this.lbl_exp.TabIndex = 4;
            // 
            // lbl_mbar
            // 
            this.lbl_mbar.AutoSize = true;
            this.lbl_mbar.Font = new System.Drawing.Font("OpenSymbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mbar.Location = new System.Drawing.Point(6, 16);
            this.lbl_mbar.Name = "lbl_mbar";
            this.lbl_mbar.Size = new System.Drawing.Size(162, 79);
            this.lbl_mbar.TabIndex = 3;
            this.lbl_mbar.Text = "0000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_time);
            this.groupBox3.Location = new System.Drawing.Point(15, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 121);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(170, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(247, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(230, 17);
            this.toolStripStatusLabel1.Text = "  PressureBar by AQAD Abdel -MP (c) 2018";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 327);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PressureBar 0.4  Z:\\Desktop\\PRESSURE_OUTPUT\\";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_srport;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ComboBox cb_interval;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_mbar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbl_exp;
    }
}

