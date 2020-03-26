namespace recieve_save_data
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
            this.value_tb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.save_data_btn = new System.Windows.Forms.Button();
            this.port_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value_pb = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.stop_bits_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data_bits_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parity_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.baud_rate_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port_name_cb = new System.Windows.Forms.ComboBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.serial_monitor_gb = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.serial_monitor_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // value_tb
            // 
            this.value_tb.Location = new System.Drawing.Point(6, 21);
            this.value_tb.Multiline = true;
            this.value_tb.Name = "value_tb";
            this.value_tb.Size = new System.Drawing.Size(267, 353);
            this.value_tb.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Lime;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(297, 321);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(138, 47);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Red;
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(297, 374);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(138, 47);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // save_data_btn
            // 
            this.save_data_btn.Location = new System.Drawing.Point(449, 321);
            this.save_data_btn.Name = "save_data_btn";
            this.save_data_btn.Size = new System.Drawing.Size(138, 47);
            this.save_data_btn.TabIndex = 3;
            this.save_data_btn.Text = "Save Data";
            this.save_data_btn.UseVisualStyleBackColor = true;
            this.save_data_btn.Click += new System.EventHandler(this.datasave_btn_Click);
            // 
            // port_tb
            // 
            this.port_tb.Location = new System.Drawing.Point(102, 36);
            this.port_tb.Name = "port_tb";
            this.port_tb.Size = new System.Drawing.Size(185, 22);
            this.port_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT NAME";
            // 
            // value_pb
            // 
            this.value_pb.Location = new System.Drawing.Point(9, 380);
            this.value_pb.Name = "value_pb";
            this.value_pb.Size = new System.Drawing.Size(264, 23);
            this.value_pb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "1024";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.stop_bits_cb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.data_bits_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.parity_cb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.baud_rate_cb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.port_name_cb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.port_tb);
            this.groupBox1.Location = new System.Drawing.Point(297, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 284);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port settings";
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(81, 231);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(138, 47);
            this.connect_btn.TabIndex = 16;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_click);
            // 
            // stop_bits_cb
            // 
            this.stop_bits_cb.FormattingEnabled = true;
            this.stop_bits_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.stop_bits_cb.Location = new System.Drawing.Point(102, 191);
            this.stop_bits_cb.Name = "stop_bits_cb";
            this.stop_bits_cb.Size = new System.Drawing.Size(185, 24);
            this.stop_bits_cb.TabIndex = 15;
            this.stop_bits_cb.Text = "Select Stop Bits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Stop Bits:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data Bits:";
            // 
            // data_bits_cb
            // 
            this.data_bits_cb.FormattingEnabled = true;
            this.data_bits_cb.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.data_bits_cb.Location = new System.Drawing.Point(102, 154);
            this.data_bits_cb.Name = "data_bits_cb";
            this.data_bits_cb.Size = new System.Drawing.Size(185, 24);
            this.data_bits_cb.TabIndex = 12;
            this.data_bits_cb.Text = "Select Data Bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Parity:";
            // 
            // parity_cb
            // 
            this.parity_cb.FormattingEnabled = true;
            this.parity_cb.Items.AddRange(new object[] {
            "none",
            "Even",
            "Odd"});
            this.parity_cb.Location = new System.Drawing.Point(102, 124);
            this.parity_cb.Name = "parity_cb";
            this.parity_cb.Size = new System.Drawing.Size(185, 24);
            this.parity_cb.TabIndex = 10;
            this.parity_cb.Text = "Select Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Baud rate:";
            // 
            // baud_rate_cb
            // 
            this.baud_rate_cb.FormattingEnabled = true;
            this.baud_rate_cb.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_rate_cb.Location = new System.Drawing.Point(102, 94);
            this.baud_rate_cb.Name = "baud_rate_cb";
            this.baud_rate_cb.Size = new System.Drawing.Size(185, 24);
            this.baud_rate_cb.TabIndex = 8;
            this.baud_rate_cb.Text = "Select Baud rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "COM Port:";
            // 
            // port_name_cb
            // 
            this.port_name_cb.FormattingEnabled = true;
            this.port_name_cb.Location = new System.Drawing.Point(102, 64);
            this.port_name_cb.Name = "port_name_cb";
            this.port_name_cb.Size = new System.Drawing.Size(185, 24);
            this.port_name_cb.TabIndex = 6;
            this.port_name_cb.Text = "Select COM Port";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(449, 374);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(138, 47);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_click);
            // 
            // serial_monitor_gb
            // 
            this.serial_monitor_gb.Controls.Add(this.value_tb);
            this.serial_monitor_gb.Controls.Add(this.value_pb);
            this.serial_monitor_gb.Controls.Add(this.label3);
            this.serial_monitor_gb.Controls.Add(this.label4);
            this.serial_monitor_gb.Location = new System.Drawing.Point(12, 12);
            this.serial_monitor_gb.Name = "serial_monitor_gb";
            this.serial_monitor_gb.Size = new System.Drawing.Size(279, 426);
            this.serial_monitor_gb.TabIndex = 12;
            this.serial_monitor_gb.TabStop = false;
            this.serial_monitor_gb.Text = "Serail Monitor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.serial_monitor_gb);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save_data_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial Data Monitor & Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serial_monitor_gb.ResumeLayout(false);
            this.serial_monitor_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox value_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button save_data_btn;
        private System.Windows.Forms.TextBox port_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar value_pb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox baud_rate_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox port_name_cb;
        private System.Windows.Forms.ComboBox stop_bits_cb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox data_bits_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parity_cb;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.GroupBox serial_monitor_gb;
    }
}

