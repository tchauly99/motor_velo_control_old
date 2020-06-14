namespace EncoderGUI
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
            this.set_speed = new System.Windows.Forms.Button();
            this.set_position = new System.Windows.Forms.Button();
            this.set_home = new System.Windows.Forms.Button();
            this.speed_setpoint_entry = new System.Windows.Forms.TextBox();
            this.position_setpoint_entry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.encoder_mode = new System.Windows.Forms.ComboBox();
            this.direction = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.current_direction_display = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.current_position_display = new System.Windows.Forms.TextBox();
            this.current_speed_display = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.get_port_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.bytes_to_send = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.connection_status = new System.Windows.Forms.TextBox();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.parity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stop_bits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.data_bits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.baud_rate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hold = new System.Windows.Forms.CheckBox();
            this.clear_graph_button = new System.Windows.Forms.Button();
            this.graph = new ZedGraph.ZedGraphControl();
            this.label11 = new System.Windows.Forms.Label();
            this.pulse_number_display = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pulse_setpoint_display = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // set_speed
            // 
            this.set_speed.Location = new System.Drawing.Point(22, 56);
            this.set_speed.Name = "set_speed";
            this.set_speed.Size = new System.Drawing.Size(100, 23);
            this.set_speed.TabIndex = 0;
            this.set_speed.Text = "set speed (rpm)";
            this.set_speed.UseVisualStyleBackColor = true;
            this.set_speed.Click += new System.EventHandler(this.set_speed_Click);
            // 
            // set_position
            // 
            this.set_position.Location = new System.Drawing.Point(157, 56);
            this.set_position.Name = "set_position";
            this.set_position.Size = new System.Drawing.Size(100, 23);
            this.set_position.TabIndex = 1;
            this.set_position.Text = "set position";
            this.set_position.UseVisualStyleBackColor = true;
            this.set_position.Click += new System.EventHandler(this.set_position_Click);
            // 
            // set_home
            // 
            this.set_home.Location = new System.Drawing.Point(286, 56);
            this.set_home.Name = "set_home";
            this.set_home.Size = new System.Drawing.Size(75, 23);
            this.set_home.TabIndex = 2;
            this.set_home.Text = "set home";
            this.set_home.UseVisualStyleBackColor = true;
            this.set_home.Click += new System.EventHandler(this.set_home_Click);
            // 
            // speed_setpoint_entry
            // 
            this.speed_setpoint_entry.Location = new System.Drawing.Point(22, 30);
            this.speed_setpoint_entry.Name = "speed_setpoint_entry";
            this.speed_setpoint_entry.Size = new System.Drawing.Size(100, 20);
            this.speed_setpoint_entry.TabIndex = 3;
            this.speed_setpoint_entry.Text = "0";
            this.speed_setpoint_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // position_setpoint_entry
            // 
            this.position_setpoint_entry.Location = new System.Drawing.Point(157, 30);
            this.position_setpoint_entry.Name = "position_setpoint_entry";
            this.position_setpoint_entry.Size = new System.Drawing.Size(100, 20);
            this.position_setpoint_entry.TabIndex = 4;
            this.position_setpoint_entry.Text = "0";
            this.position_setpoint_entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pulse_setpoint_display);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.encoder_mode);
            this.groupBox1.Controls.Add(this.direction);
            this.groupBox1.Controls.Add(this.speed_setpoint_entry);
            this.groupBox1.Controls.Add(this.position_setpoint_entry);
            this.groupBox1.Controls.Add(this.set_speed);
            this.groupBox1.Controls.Add(this.set_position);
            this.groupBox1.Controls.Add(this.set_home);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "encoder mode";
            // 
            // encoder_mode
            // 
            this.encoder_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encoder_mode.FormattingEnabled = true;
            this.encoder_mode.Items.AddRange(new object[] {
            "x1",
            "x4"});
            this.encoder_mode.Location = new System.Drawing.Point(22, 98);
            this.encoder_mode.Name = "encoder_mode";
            this.encoder_mode.Size = new System.Drawing.Size(121, 21);
            this.encoder_mode.TabIndex = 6;
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Location = new System.Drawing.Point(286, 30);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(61, 17);
            this.direction.TabIndex = 5;
            this.direction.Text = "reverse";
            this.direction.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pulse_number_display);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.current_direction_display);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.current_position_display);
            this.groupBox2.Controls.Add(this.current_speed_display);
            this.groupBox2.Location = new System.Drawing.Point(418, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "status";
            // 
            // current_direction_display
            // 
            this.current_direction_display.Location = new System.Drawing.Point(262, 56);
            this.current_direction_display.Name = "current_direction_display";
            this.current_direction_display.ReadOnly = true;
            this.current_direction_display.Size = new System.Drawing.Size(100, 20);
            this.current_direction_display.TabIndex = 7;
            this.current_direction_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "current direction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "current position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "current speed (rpm)";
            // 
            // current_position_display
            // 
            this.current_position_display.Location = new System.Drawing.Point(138, 56);
            this.current_position_display.Name = "current_position_display";
            this.current_position_display.ReadOnly = true;
            this.current_position_display.Size = new System.Drawing.Size(100, 20);
            this.current_position_display.TabIndex = 7;
            this.current_position_display.Text = "0";
            this.current_position_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // current_speed_display
            // 
            this.current_speed_display.Location = new System.Drawing.Point(19, 56);
            this.current_speed_display.Name = "current_speed_display";
            this.current_speed_display.ReadOnly = true;
            this.current_speed_display.Size = new System.Drawing.Size(100, 20);
            this.current_speed_display.TabIndex = 0;
            this.current_speed_display.Text = "0";
            this.current_speed_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.get_port_button);
            this.tabPage1.Controls.Add(this.send_button);
            this.tabPage1.Controls.Add(this.bytes_to_send);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.connection_status);
            this.tabPage1.Controls.Add(this.disconnect_button);
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Controls.Add(this.parity);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.stop_bits);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.terminal);
            this.tabPage1.Controls.Add(this.data_bits);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.baud_rate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.port_name);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(802, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // get_port_button
            // 
            this.get_port_button.Location = new System.Drawing.Point(609, 31);
            this.get_port_button.Name = "get_port_button";
            this.get_port_button.Size = new System.Drawing.Size(91, 23);
            this.get_port_button.TabIndex = 18;
            this.get_port_button.Text = "get port name";
            this.get_port_button.UseVisualStyleBackColor = true;
            this.get_port_button.Click += new System.EventHandler(this.get_port_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(609, 220);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 17;
            this.send_button.Text = "send_button";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // bytes_to_send
            // 
            this.bytes_to_send.Location = new System.Drawing.Point(609, 194);
            this.bytes_to_send.Name = "bytes_to_send";
            this.bytes_to_send.Size = new System.Drawing.Size(156, 20);
            this.bytes_to_send.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Connection status";
            // 
            // connection_status
            // 
            this.connection_status.Location = new System.Drawing.Point(609, 74);
            this.connection_status.Name = "connection_status";
            this.connection_status.ReadOnly = true;
            this.connection_status.Size = new System.Drawing.Size(156, 20);
            this.connection_status.TabIndex = 14;
            this.connection_status.Text = "disconnected";
            this.connection_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disconnect_button
            // 
            this.disconnect_button.BackColor = System.Drawing.Color.Transparent;
            this.disconnect_button.Location = new System.Drawing.Point(690, 100);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.disconnect_button.TabIndex = 13;
            this.disconnect_button.Text = "disconnect";
            this.disconnect_button.UseVisualStyleBackColor = false;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.Transparent;
            this.connect_button.Location = new System.Drawing.Point(609, 100);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 12;
            this.connect_button.Text = "connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // parity
            // 
            this.parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity.FormattingEnabled = true;
            this.parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parity.Location = new System.Drawing.Point(26, 153);
            this.parity.Name = "parity";
            this.parity.Size = new System.Drawing.Size(121, 21);
            this.parity.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Parity";
            // 
            // stop_bits
            // 
            this.stop_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stop_bits.FormattingEnabled = true;
            this.stop_bits.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.stop_bits.Location = new System.Drawing.Point(26, 193);
            this.stop_bits.Name = "stop_bits";
            this.stop_bits.Size = new System.Drawing.Size(121, 21);
            this.stop_bits.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stop bits";
            // 
            // terminal
            // 
            this.terminal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.terminal.Location = new System.Drawing.Point(220, 17);
            this.terminal.Name = "terminal";
            this.terminal.ReadOnly = true;
            this.terminal.Size = new System.Drawing.Size(343, 437);
            this.terminal.TabIndex = 7;
            this.terminal.Text = "";
            // 
            // data_bits
            // 
            this.data_bits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.data_bits.FormattingEnabled = true;
            this.data_bits.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.data_bits.Location = new System.Drawing.Point(26, 113);
            this.data_bits.Name = "data_bits";
            this.data_bits.Size = new System.Drawing.Size(121, 21);
            this.data_bits.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data bits";
            // 
            // baud_rate
            // 
            this.baud_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baud_rate.FormattingEnabled = true;
            this.baud_rate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "1400",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "152000",
            "128000",
            "256000"});
            this.baud_rate.Location = new System.Drawing.Point(26, 74);
            this.baud_rate.Name = "baud_rate";
            this.baud_rate.Size = new System.Drawing.Size(121, 21);
            this.baud_rate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Baud rate";
            // 
            // port_name
            // 
            this.port_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port_name.FormattingEnabled = true;
            this.port_name.Location = new System.Drawing.Point(26, 33);
            this.port_name.Name = "port_name";
            this.port_name.Size = new System.Drawing.Size(121, 21);
            this.port_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hold);
            this.tabPage2.Controls.Add(this.clear_graph_button);
            this.tabPage2.Controls.Add(this.graph);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(802, 511);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Motor control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hold
            // 
            this.hold.AutoSize = true;
            this.hold.Location = new System.Drawing.Point(698, 315);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(46, 17);
            this.hold.TabIndex = 11;
            this.hold.Text = "hold";
            this.hold.UseVisualStyleBackColor = true;
            this.hold.CheckedChanged += new System.EventHandler(this.hold_CheckedChanged);
            // 
            // clear_graph_button
            // 
            this.clear_graph_button.Location = new System.Drawing.Point(685, 338);
            this.clear_graph_button.Name = "clear_graph_button";
            this.clear_graph_button.Size = new System.Drawing.Size(75, 23);
            this.clear_graph_button.TabIndex = 10;
            this.clear_graph_button.Text = "clear_graph";
            this.clear_graph_button.UseVisualStyleBackColor = true;
            this.clear_graph_button.Click += new System.EventHandler(this.clear_graph_button_Click);
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(18, 158);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(641, 353);
            this.graph.TabIndex = 7;
            this.graph.UseExtendedPrintDialog = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "pulse number";
            // 
            // pulse_number_display
            // 
            this.pulse_number_display.Location = new System.Drawing.Point(19, 95);
            this.pulse_number_display.Name = "pulse_number_display";
            this.pulse_number_display.ReadOnly = true;
            this.pulse_number_display.Size = new System.Drawing.Size(100, 20);
            this.pulse_number_display.TabIndex = 12;
            this.pulse_number_display.Text = "0";
            this.pulse_number_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "speed setpoint (pulse per control period)";
            // 
            // pulse_setpoint_display
            // 
            this.pulse_setpoint_display.Location = new System.Drawing.Point(157, 98);
            this.pulse_setpoint_display.Name = "pulse_setpoint_display";
            this.pulse_setpoint_display.Size = new System.Drawing.Size(178, 20);
            this.pulse_setpoint_display.TabIndex = 9;
            this.pulse_setpoint_display.Text = "0";
            this.pulse_setpoint_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EncoderGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button set_speed;
        private System.Windows.Forms.Button set_position;
        private System.Windows.Forms.Button set_home;
        private System.Windows.Forms.TextBox speed_setpoint_entry;
        private System.Windows.Forms.TextBox position_setpoint_entry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox current_position_display;
        private System.Windows.Forms.TextBox current_speed_display;
        private System.Windows.Forms.CheckBox direction;
        private System.Windows.Forms.TextBox current_direction_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox baud_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox port_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox data_bits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox terminal;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ComboBox parity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stop_bits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox connection_status;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox bytes_to_send;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button get_port_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox encoder_mode;
        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.Button clear_graph_button;
        private System.Windows.Forms.CheckBox hold;
        private System.Windows.Forms.TextBox pulse_number_display;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pulse_setpoint_display;
        private System.Windows.Forms.Label label12;
    }
}

