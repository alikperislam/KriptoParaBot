namespace KriptoParaBot
{
    partial class frmSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboTrading = new Guna.UI.WinForms.GunaComboBox();
            this.comboBotMode = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaGoogleSwitch2 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.gunaGoogleSwitch1 = new Guna.UI.WinForms.GunaGoogleSwitch();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.comboblackList = new Guna.UI.WinForms.GunaComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboTrading);
            this.panel1.Controls.Add(this.comboBotMode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 481);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(22, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "$ 0,00000000";
            // 
            // comboTrading
            // 
            this.comboTrading.BackColor = System.Drawing.Color.Transparent;
            this.comboTrading.BaseColor = System.Drawing.Color.White;
            this.comboTrading.BorderColor = System.Drawing.Color.White;
            this.comboTrading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTrading.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTrading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrading.FocusedColor = System.Drawing.Color.Empty;
            this.comboTrading.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTrading.ForeColor = System.Drawing.Color.Black;
            this.comboTrading.FormattingEnabled = true;
            this.comboTrading.Items.AddRange(new object[] {
            "USDT",
            "BTC",
            "BNB",
            "ADA",
            "CHZ",
            "BTT",
            "HOT",
            "WİNK",
            "ETH",
            "USDC",
            "DOGE",
            "XRP",
            "DOT",
            "BCH",
            "THETA",
            "TRX",
            "EOS",
            "LUNA",
            "MKR",
            "ETC",
            "DASH",
            "ENJ",
            "BAT",
            "FIO"});
            this.comboTrading.Location = new System.Drawing.Point(27, 349);
            this.comboTrading.Name = "comboTrading";
            this.comboTrading.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.comboTrading.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboTrading.Size = new System.Drawing.Size(237, 33);
            this.comboTrading.TabIndex = 10;
            // 
            // comboBotMode
            // 
            this.comboBotMode.BackColor = System.Drawing.Color.Transparent;
            this.comboBotMode.BaseColor = System.Drawing.Color.White;
            this.comboBotMode.BorderColor = System.Drawing.Color.White;
            this.comboBotMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBotMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBotMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBotMode.FocusedColor = System.Drawing.Color.Empty;
            this.comboBotMode.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBotMode.ForeColor = System.Drawing.Color.Black;
            this.comboBotMode.FormattingEnabled = true;
            this.comboBotMode.Items.AddRange(new object[] {
            "Very high risk",
            "High risk",
            "Normal",
            "Low risk",
            "Very low risk"});
            this.comboBotMode.Location = new System.Drawing.Point(27, 281);
            this.comboBotMode.Name = "comboBotMode";
            this.comboBotMode.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.comboBotMode.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBotMode.Size = new System.Drawing.Size(237, 33);
            this.comboBotMode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "API";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(22, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Balance limit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(22, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trading pair :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(22, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bot mode :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(22, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "hwrVZDW2R5HKTZ7u";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Api secret :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "oFI3OKIBHk90PTDI4Ow\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Api key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exchange : Binance";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.gunaGoogleSwitch2);
            this.panel2.Controls.Add(this.gunaGoogleSwitch1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(340, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 481);
            this.panel2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(20, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 34);
            this.label15.TabIndex = 12;
            this.label15.Text = "Preferences";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(80, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Buy BNB when low.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(80, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "No more buy. Sell only";
            // 
            // gunaGoogleSwitch2
            // 
            this.gunaGoogleSwitch2.BackColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch2.CheckedOffColor = System.Drawing.Color.Red;
            this.gunaGoogleSwitch2.CheckedOnColor = System.Drawing.Color.Green;
            this.gunaGoogleSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGoogleSwitch2.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch2.Location = new System.Drawing.Point(26, 157);
            this.gunaGoogleSwitch2.Name = "gunaGoogleSwitch2";
            this.gunaGoogleSwitch2.Size = new System.Drawing.Size(38, 20);
            this.gunaGoogleSwitch2.TabIndex = 14;
            // 
            // gunaGoogleSwitch1
            // 
            this.gunaGoogleSwitch1.BackColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGoogleSwitch1.CheckedOffColor = System.Drawing.Color.Red;
            this.gunaGoogleSwitch1.CheckedOnColor = System.Drawing.Color.Green;
            this.gunaGoogleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaGoogleSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaGoogleSwitch1.Location = new System.Drawing.Point(26, 106);
            this.gunaGoogleSwitch1.Name = "gunaGoogleSwitch1";
            this.gunaGoogleSwitch1.Size = new System.Drawing.Size(38, 20);
            this.gunaGoogleSwitch1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Buy this more, at market price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "If BNB Balance is lower than";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.White;
            this.trackBar2.Location = new System.Drawing.Point(14, 361);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(274, 56);
            this.trackBar2.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(14, 250);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(274, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnGraphics);
            this.panel3.Controls.Add(this.comboblackList);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(662, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 481);
            this.panel3.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(38, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(279, 38);
            this.label18.TabIndex = 17;
            this.label18.Text = "GTRBOT will not trad (neitherbuy,\r\nnor sell) these coins:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(36, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 34);
            this.label17.TabIndex = 17;
            this.label17.Text = "Black List";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(38, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 21);
            this.label16.TabIndex = 17;
            this.label16.Text = "Select coin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(231, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 33);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.BackColor = System.Drawing.Color.White;
            this.btnGraphics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGraphics.BackgroundImage")));
            this.btnGraphics.FlatAppearance.BorderSize = 0;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Location = new System.Drawing.Point(188, 170);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(33, 33);
            this.btnGraphics.TabIndex = 13;
            this.btnGraphics.UseVisualStyleBackColor = false;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // comboblackList
            // 
            this.comboblackList.BackColor = System.Drawing.Color.Transparent;
            this.comboblackList.BaseColor = System.Drawing.Color.White;
            this.comboblackList.BorderColor = System.Drawing.Color.White;
            this.comboblackList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboblackList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboblackList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboblackList.FocusedColor = System.Drawing.Color.Empty;
            this.comboblackList.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboblackList.ForeColor = System.Drawing.Color.Black;
            this.comboblackList.FormattingEnabled = true;
            this.comboblackList.Items.AddRange(new object[] {
            "USDT",
            "BTC",
            "BNB",
            "ADA",
            "CHZ",
            "BTT",
            "HOT",
            "WİNK",
            "ETH",
            "USDC",
            "DOGE",
            "XRP",
            "DOT",
            "BCH",
            "THETA",
            "TRX",
            "EOS",
            "LUNA",
            "MKR",
            "ETC",
            "DASH",
            "ENJ",
            "BAT",
            "FIO"});
            this.comboblackList.Location = new System.Drawing.Point(40, 170);
            this.comboblackList.Name = "comboblackList";
            this.comboblackList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.comboblackList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboblackList.Size = new System.Drawing.Size(142, 33);
            this.comboblackList.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(40, 225);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // frmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(986, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSet";
            this.Text = "frmSet";
            this.Load += new System.EventHandler(this.frmSet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox comboBotMode;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox comboTrading;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar2;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch2;
        private Guna.UI.WinForms.GunaGoogleSwitch gunaGoogleSwitch1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaComboBox comboblackList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}