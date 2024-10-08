﻿namespace ControleDeReservatorio
{
    partial class FormControlPanel
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBridge = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnRegiterUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_serial = new System.Windows.Forms.Panel();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnUpdateSerialPorts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_login_date = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_ship_distance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_status_closing = new System.Windows.Forms.Label();
            this.lbl_bridge = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pb_TrafficLight2 = new System.Windows.Forms.PictureBox();
            this.pb_TrafficLight = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_traffic_light = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblTrafficState = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_serial.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TrafficLight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TrafficLight)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMenu.Controls.Add(this.btnBridge);
            this.panelMenu.Controls.Add(this.btnMode);
            this.panelMenu.Controls.Add(this.btnRegiterUser);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(218, 481);
            this.panelMenu.TabIndex = 0;
            // 
            // btnBridge
            // 
            this.btnBridge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBridge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBridge.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnBridge.Location = new System.Drawing.Point(0, 238);
            this.btnBridge.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBridge.Name = "btnBridge";
            this.btnBridge.Size = new System.Drawing.Size(218, 48);
            this.btnBridge.TabIndex = 7;
            this.btnBridge.Text = "Acionar Ponte";
            this.btnBridge.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBridge.UseVisualStyleBackColor = true;
            this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
            // 
            // btnMode
            // 
            this.btnMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnMode.Location = new System.Drawing.Point(0, 190);
            this.btnMode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(218, 48);
            this.btnMode.TabIndex = 6;
            this.btnMode.Text = "Mudar Modo";
            this.btnMode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnRegiterUser
            // 
            this.btnRegiterUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegiterUser.FlatAppearance.BorderSize = 0;
            this.btnRegiterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegiterUser.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegiterUser.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnRegiterUser.Image = global::SuspensionBridge.Properties.Resources.Contact;
            this.btnRegiterUser.Location = new System.Drawing.Point(0, 142);
            this.btnRegiterUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegiterUser.Name = "btnRegiterUser";
            this.btnRegiterUser.Size = new System.Drawing.Size(218, 48);
            this.btnRegiterUser.TabIndex = 5;
            this.btnRegiterUser.Text = "Cadastrar Usuário";
            this.btnRegiterUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegiterUser.UseVisualStyleBackColor = true;
            this.btnRegiterUser.Visible = false;
            this.btnRegiterUser.Click += new System.EventHandler(this.btnRegiterUser_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_serial);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 205);
            this.panel3.TabIndex = 1;
            // 
            // pnl_serial
            // 
            this.pnl_serial.Controls.Add(this.cbBaudRate);
            this.pnl_serial.Controls.Add(this.btnUpdateSerialPorts);
            this.pnl_serial.Controls.Add(this.label2);
            this.pnl_serial.Controls.Add(this.cbSerialPort);
            this.pnl_serial.Controls.Add(this.label3);
            this.pnl_serial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_serial.Location = new System.Drawing.Point(0, 0);
            this.pnl_serial.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnl_serial.Name = "pnl_serial";
            this.pnl_serial.Size = new System.Drawing.Size(218, 152);
            this.pnl_serial.TabIndex = 0;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(7, 96);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(205, 21);
            this.cbBaudRate.TabIndex = 5;
            // 
            // btnUpdateSerialPorts
            // 
            this.btnUpdateSerialPorts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateSerialPorts.FlatAppearance.BorderSize = 0;
            this.btnUpdateSerialPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSerialPorts.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSerialPorts.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateSerialPorts.Location = new System.Drawing.Point(0, 123);
            this.btnUpdateSerialPorts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateSerialPorts.Name = "btnUpdateSerialPorts";
            this.btnUpdateSerialPorts.Size = new System.Drawing.Size(218, 29);
            this.btnUpdateSerialPorts.TabIndex = 2;
            this.btnUpdateSerialPorts.Text = "Actualizar";
            this.btnUpdateSerialPorts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSerialPorts.UseVisualStyleBackColor = true;
            this.btnUpdateSerialPorts.Click += new System.EventHandler(this.btnUpdateSerialPorts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Porta Serial:";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(7, 42);
            this.cbSerialPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(205, 21);
            this.cbSerialPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baud Rate:";
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConnect.Location = new System.Drawing.Point(0, 154);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(218, 51);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_nav);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lbl_login_date);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 142);
            this.panel2.TabIndex = 1;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnl_nav.Location = new System.Drawing.Point(0, 188);
            this.pnl_nav.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(2, 65);
            this.pnl_nav.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "On:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 81);
            this.panel4.TabIndex = 2;
            // 
            // lbl_login_date
            // 
            this.lbl_login_date.AutoSize = true;
            this.lbl_login_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbl_login_date.Location = new System.Drawing.Point(73, 111);
            this.lbl_login_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_date.Name = "lbl_login_date";
            this.lbl_login_date.Size = new System.Drawing.Size(57, 13);
            this.lbl_login_date.TabIndex = 2;
            this.lbl_login_date.Text = "14:31:02";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_username.Location = new System.Drawing.Point(59, 74);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(89, 17);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Eng. Pedro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SuspensionBridge.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(69, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(874, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 68);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_2);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(218, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(933, 481);
            this.panel5.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ship_distance);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox3.Location = new System.Drawing.Point(573, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(179, 126);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distância do Návio";
            // 
            // lbl_ship_distance
            // 
            this.lbl_ship_distance.AutoSize = true;
            this.lbl_ship_distance.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ship_distance.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_ship_distance.Location = new System.Drawing.Point(79, 55);
            this.lbl_ship_distance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ship_distance.Name = "lbl_ship_distance";
            this.lbl_ship_distance.Size = new System.Drawing.Size(17, 19);
            this.lbl_ship_distance.TabIndex = 0;
            this.lbl_ship_distance.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_status_closing);
            this.groupBox2.Controls.Add(this.lbl_bridge);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Location = new System.Drawing.Point(51, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(191, 126);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado da Ponte";
            // 
            // lbl_status_closing
            // 
            this.lbl_status_closing.AutoSize = true;
            this.lbl_status_closing.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_closing.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_status_closing.Location = new System.Drawing.Point(5, 98);
            this.lbl_status_closing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status_closing.Name = "lbl_status_closing";
            this.lbl_status_closing.Size = new System.Drawing.Size(118, 19);
            this.lbl_status_closing.TabIndex = 2;
            this.lbl_status_closing.Text = "Abrindo Ponte...";
            this.lbl_status_closing.Visible = false;
            // 
            // lbl_bridge
            // 
            this.lbl_bridge.AutoSize = true;
            this.lbl_bridge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bridge.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_bridge.Location = new System.Drawing.Point(46, 55);
            this.lbl_bridge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bridge.Name = "lbl_bridge";
            this.lbl_bridge.Size = new System.Drawing.Size(55, 19);
            this.lbl_bridge.TabIndex = 0;
            this.lbl_bridge.Text = "Aberta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mode);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(328, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(176, 126);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo";
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mode.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_mode.Location = new System.Drawing.Point(49, 55);
            this.lbl_mode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(87, 19);
            this.lbl_mode.TabIndex = 0;
            this.lbl_mode.Text = "Automático";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblTrafficState);
            this.panel7.Controls.Add(this.pb_TrafficLight2);
            this.panel7.Controls.Add(this.pb_TrafficLight);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lbl_traffic_light);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(757, 413);
            this.panel7.TabIndex = 16;
            // 
            // pb_TrafficLight2
            // 
            this.pb_TrafficLight2.Image = global::SuspensionBridge.Properties.Resources.red;
            this.pb_TrafficLight2.Location = new System.Drawing.Point(526, 315);
            this.pb_TrafficLight2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_TrafficLight2.Name = "pb_TrafficLight2";
            this.pb_TrafficLight2.Size = new System.Drawing.Size(197, 210);
            this.pb_TrafficLight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TrafficLight2.TabIndex = 18;
            this.pb_TrafficLight2.TabStop = false;
            // 
            // pb_TrafficLight
            // 
            this.pb_TrafficLight.Image = global::SuspensionBridge.Properties.Resources.red;
            this.pb_TrafficLight.Location = new System.Drawing.Point(122, 315);
            this.pb_TrafficLight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_TrafficLight.Name = "pb_TrafficLight";
            this.pb_TrafficLight.Size = new System.Drawing.Size(199, 210);
            this.pb_TrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TrafficLight.TabIndex = 17;
            this.pb_TrafficLight.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estado do Semáforo";
            // 
            // lbl_traffic_light
            // 
            this.lbl_traffic_light.AutoSize = true;
            this.lbl_traffic_light.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_traffic_light.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_traffic_light.Location = new System.Drawing.Point(284, 134);
            this.lbl_traffic_light.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_traffic_light.Name = "lbl_traffic_light";
            this.lbl_traffic_light.Size = new System.Drawing.Size(84, 21);
            this.lbl_traffic_light.TabIndex = 0;
            this.lbl_traffic_light.Text = "Vermelho";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 68);
            this.panel1.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 68);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(108, 413);
            this.panel8.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(865, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(68, 413);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(108, 68);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(757, 413);
            this.panel10.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox3);
            this.panel11.Controls.Add(this.groupBox2);
            this.panel11.Controls.Add(this.groupBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(757, 182);
            this.panel11.TabIndex = 17;
            // 
            // lblTrafficState
            // 
            this.lblTrafficState.AutoSize = true;
            this.lblTrafficState.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrafficState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(212)))), ((int)(((byte)(245)))));
            this.lblTrafficState.Location = new System.Drawing.Point(375, 386);
            this.lblTrafficState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrafficState.Name = "lblTrafficState";
            this.lblTrafficState.Size = new System.Drawing.Size(97, 25);
            this.lblTrafficState.TabIndex = 6;
            this.lblTrafficState.Text = "Vermelho";
            // 
            // FormControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1151, 481);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(852, 435);
            this.Name = "FormControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_serial.ResumeLayout(false);
            this.pnl_serial.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TrafficLight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TrafficLight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_login_date;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateSerialPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btnRegiterUser;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnl_serial;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_mode;
        private System.Windows.Forms.Label lbl_bridge;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_traffic_light;
        private System.Windows.Forms.Button btnBridge;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.PictureBox pb_TrafficLight;
        private System.Windows.Forms.Label lbl_status_closing;
        private System.Windows.Forms.Label lbl_ship_distance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_TrafficLight2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTrafficState;
    }
}

