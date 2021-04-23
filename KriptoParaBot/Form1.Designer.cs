namespace KriptoParaBot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.anaPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDak = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pcTurkuaz = new System.Windows.Forms.PictureBox();
            this.pcMavi = new System.Windows.Forms.PictureBox();
            this.pcPembe = new System.Windows.Forms.PictureBox();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.anaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTurkuaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPembe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anaPanel
            // 
            this.anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.anaPanel.Controls.Add(this.pictureBox4);
            this.anaPanel.Location = new System.Drawing.Point(0, 55);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(986, 584);
            this.anaPanel.TabIndex = 1;
            this.anaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.anaPanel_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(141, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(704, 380);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(949, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.lblDak);
            this.panel2.Controls.Add(this.lblSn);
            this.panel2.Controls.Add(this.lblSaat);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.pcTurkuaz);
            this.panel2.Controls.Add(this.pcMavi);
            this.panel2.Controls.Add(this.pcPembe);
            this.panel2.Controls.Add(this.btnGraphics);
            this.panel2.Controls.Add(this.btnOperation);
            this.panel2.Controls.Add(this.btnMain);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 58);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblDak
            // 
            this.lblDak.AutoSize = true;
            this.lblDak.Location = new System.Drawing.Point(124, 11);
            this.lblDak.Name = "lblDak";
            this.lblDak.Size = new System.Drawing.Size(35, 25);
            this.lblDak.TabIndex = 14;
            this.lblDak.Text = "0 :";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Location = new System.Drawing.Point(153, 11);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(23, 25);
            this.lblSn.TabIndex = 13;
            this.lblSn.Text = "0";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(95, 11);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(35, 25);
            this.lblSaat.TabIndex = 12;
            this.lblSaat.Text = "0 :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "En",
            "Tr",
            "Ru",
            "Ch",
            "Ar",
            "Es"});
            this.comboBox1.Location = new System.Drawing.Point(795, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "En";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pcTurkuaz
            // 
            this.pcTurkuaz.BackColor = System.Drawing.Color.Olive;
            this.pcTurkuaz.Location = new System.Drawing.Point(610, 45);
            this.pcTurkuaz.Name = "pcTurkuaz";
            this.pcTurkuaz.Size = new System.Drawing.Size(100, 10);
            this.pcTurkuaz.TabIndex = 9;
            this.pcTurkuaz.TabStop = false;
            // 
            // pcMavi
            // 
            this.pcMavi.BackColor = System.Drawing.Color.Olive;
            this.pcMavi.Location = new System.Drawing.Point(412, 45);
            this.pcMavi.Name = "pcMavi";
            this.pcMavi.Size = new System.Drawing.Size(100, 10);
            this.pcMavi.TabIndex = 8;
            this.pcMavi.TabStop = false;
            // 
            // pcPembe
            // 
            this.pcPembe.BackColor = System.Drawing.Color.Olive;
            this.pcPembe.Location = new System.Drawing.Point(217, 45);
            this.pcPembe.Name = "pcPembe";
            this.pcPembe.Size = new System.Drawing.Size(100, 10);
            this.pcPembe.TabIndex = 0;
            this.pcPembe.TabStop = false;
            // 
            // btnGraphics
            // 
            this.btnGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnGraphics.FlatAppearance.BorderSize = 0;
            this.btnGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphics.Location = new System.Drawing.Point(583, 3);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(149, 40);
            this.btnGraphics.TabIndex = 7;
            this.btnGraphics.Text = "Settings";
            this.btnGraphics.UseVisualStyleBackColor = false;
            this.btnGraphics.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnOperation.FlatAppearance.BorderSize = 0;
            this.btnOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperation.Location = new System.Drawing.Point(386, 3);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(149, 40);
            this.btnOperation.TabIndex = 6;
            this.btnOperation.Text = "Operation";
            this.btnOperation.UseVisualStyleBackColor = false;
            this.btnOperation.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(193, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(149, 40);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(908, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(986, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.anaPanel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.anaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTurkuaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPembe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel anaPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcTurkuaz;
        private System.Windows.Forms.PictureBox pcMavi;
        private System.Windows.Forms.PictureBox pcPembe;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDak;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Label lblSaat;
    }
}

