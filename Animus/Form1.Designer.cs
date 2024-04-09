namespace Animus
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
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.recordimages = new System.Windows.Forms.ImageList(this.components);
            this.Searchbtn = new System.Windows.Forms.Button();
            this.answerbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gB = new System.Windows.Forms.Button();
            this.exB = new System.Windows.Forms.Button();
            this.wB = new System.Windows.Forms.Button();
            this.tB = new System.Windows.Forms.Button();
            this.cB = new System.Windows.Forms.Button();
            this.eB = new System.Windows.Forms.Button();
            this.mB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lblcpu = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.cpulabel = new System.Windows.Forms.Label();
            this.ramlabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbox
            // 
            this.Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbox.Location = new System.Drawing.Point(69, 399);
            this.Searchbox.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(245, 26);
            this.Searchbox.TabIndex = 0;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // recordimages
            // 
            this.recordimages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("recordimages.ImageStream")));
            this.recordimages.TransparentColor = System.Drawing.Color.Transparent;
            this.recordimages.Images.SetKeyName(0, "record.png");
            this.recordimages.Images.SetKeyName(1, "record_clicked.png");
            this.recordimages.Images.SetKeyName(2, "record_hover.png");
            // 
            // Searchbtn
            // 
            this.Searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Searchbtn.FlatAppearance.BorderSize = 3;
            this.Searchbtn.Image = global::Animus.Properties.Resources.search_small;
            this.Searchbtn.Location = new System.Drawing.Point(1, 378);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(64, 52);
            this.Searchbtn.TabIndex = 1;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // answerbox
            // 
            this.answerbox.BackColor = System.Drawing.Color.Black;
            this.answerbox.Enabled = false;
            this.answerbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answerbox.Location = new System.Drawing.Point(13, 44);
            this.answerbox.Margin = new System.Windows.Forms.Padding(2);
            this.answerbox.Multiline = true;
            this.answerbox.Name = "answerbox";
            this.answerbox.Size = new System.Drawing.Size(381, 109);
            this.answerbox.TabIndex = 3;
            this.answerbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Response";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gB
            // 
            this.gB.BackColor = System.Drawing.Color.Transparent;
            this.gB.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.gB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB.ForeColor = System.Drawing.Color.Gold;
            this.gB.Location = new System.Drawing.Point(173, 183);
            this.gB.Margin = new System.Windows.Forms.Padding(2);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(77, 27);
            this.gB.TabIndex = 8;
            this.gB.Text = "Google";
            this.gB.UseVisualStyleBackColor = false;
            this.gB.Click += new System.EventHandler(this.gB_Click);
            // 
            // exB
            // 
            this.exB.BackColor = System.Drawing.Color.Transparent;
            this.exB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.exB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exB.ForeColor = System.Drawing.Color.Gold;
            this.exB.Location = new System.Drawing.Point(173, 330);
            this.exB.Margin = new System.Windows.Forms.Padding(2);
            this.exB.Name = "exB";
            this.exB.Size = new System.Drawing.Size(59, 23);
            this.exB.TabIndex = 9;
            this.exB.Text = "Explorer";
            this.exB.UseVisualStyleBackColor = false;
            this.exB.Click += new System.EventHandler(this.hB_Click);
            // 
            // wB
            // 
            this.wB.BackColor = System.Drawing.Color.Transparent;
            this.wB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.wB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wB.ForeColor = System.Drawing.Color.Gold;
            this.wB.Location = new System.Drawing.Point(173, 251);
            this.wB.Margin = new System.Windows.Forms.Padding(2);
            this.wB.Name = "wB";
            this.wB.Size = new System.Drawing.Size(71, 31);
            this.wB.TabIndex = 10;
            this.wB.Text = "Weather";
            this.wB.UseVisualStyleBackColor = false;
            this.wB.Click += new System.EventHandler(this.wB_Click);
            // 
            // tB
            // 
            this.tB.BackColor = System.Drawing.Color.Transparent;
            this.tB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.tB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB.ForeColor = System.Drawing.Color.Gold;
            this.tB.Location = new System.Drawing.Point(272, 183);
            this.tB.Margin = new System.Windows.Forms.Padding(2);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(103, 27);
            this.tB.TabIndex = 11;
            this.tB.Text = "Task Manager";
            this.tB.UseVisualStyleBackColor = false;
            this.tB.Click += new System.EventHandler(this.tB_Click);
            // 
            // cB
            // 
            this.cB.BackColor = System.Drawing.Color.Transparent;
            this.cB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.cB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB.ForeColor = System.Drawing.Color.Gold;
            this.cB.Location = new System.Drawing.Point(272, 251);
            this.cB.Margin = new System.Windows.Forms.Padding(2);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(103, 34);
            this.cB.TabIndex = 13;
            this.cB.Text = "Control Panel";
            this.cB.UseVisualStyleBackColor = false;
            this.cB.Click += new System.EventHandler(this.cB_Click);
            // 
            // eB
            // 
            this.eB.BackColor = System.Drawing.Color.Transparent;
            this.eB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eB.ForeColor = System.Drawing.Color.Red;
            this.eB.Location = new System.Drawing.Point(606, 401);
            this.eB.Margin = new System.Windows.Forms.Padding(2);
            this.eB.Name = "eB";
            this.eB.Size = new System.Drawing.Size(56, 29);
            this.eB.TabIndex = 14;
            this.eB.Text = "Exit";
            this.eB.UseVisualStyleBackColor = false;
            this.eB.Click += new System.EventHandler(this.eB_Click);
            // 
            // mB
            // 
            this.mB.BackColor = System.Drawing.Color.Transparent;
            this.mB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mB.ForeColor = System.Drawing.Color.Red;
            this.mB.Location = new System.Drawing.Point(501, 399);
            this.mB.Margin = new System.Windows.Forms.Padding(2);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(81, 30);
            this.mB.TabIndex = 15;
            this.mB.Text = "Power Off";
            this.mB.UseVisualStyleBackColor = false;
            this.mB.Click += new System.EventHandler(this.mB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(458, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date & Time";
            // 
            // dT
            // 
            this.dT.AutoSize = true;
            this.dT.BackColor = System.Drawing.Color.Transparent;
            this.dT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT.ForeColor = System.Drawing.Color.Gold;
            this.dT.Location = new System.Drawing.Point(578, 215);
            this.dT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dT.Name = "dT";
            this.dT.Size = new System.Drawing.Size(67, 16);
            this.dT.TabIndex = 17;
            this.dT.Text = "Fetching...";
            this.dT.Click += new System.EventHandler(this.dT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Animus.Properties.Resources.hud;
            this.pictureBox4.Location = new System.Drawing.Point(448, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Transparent;
            this.btnEnable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnable.BackgroundImage")));
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(334, 389);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(56, 47);
            this.btnEnable.TabIndex = 20;
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Transparent;
            this.btnDisable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisable.BackgroundImage")));
            this.btnDisable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDisable.Enabled = false;
            this.btnDisable.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisable.Location = new System.Drawing.Point(423, 390);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(49, 46);
            this.btnDisable.TabIndex = 21;
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lblcpu
            // 
            this.lblcpu.AutoSize = true;
            this.lblcpu.BackColor = System.Drawing.Color.Transparent;
            this.lblcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblcpu.Location = new System.Drawing.Point(458, 124);
            this.lblcpu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcpu.Name = "lblcpu";
            this.lblcpu.Size = new System.Drawing.Size(97, 20);
            this.lblcpu.TabIndex = 22;
            this.lblcpu.Text = "CPU Usage:";
            this.lblcpu.Click += new System.EventHandler(this.lblcpu_Click);
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.BackColor = System.Drawing.Color.Transparent;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRam.Location = new System.Drawing.Point(458, 167);
            this.lblRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(116, 20);
            this.lblRam.TabIndex = 23;
            this.lblRam.Text = "RAM Available:";
            this.lblRam.Click += new System.EventHandler(this.lblRam_Click);
            // 
            // cpulabel
            // 
            this.cpulabel.AutoSize = true;
            this.cpulabel.BackColor = System.Drawing.Color.Transparent;
            this.cpulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpulabel.ForeColor = System.Drawing.Color.Gold;
            this.cpulabel.Location = new System.Drawing.Point(578, 126);
            this.cpulabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpulabel.Name = "cpulabel";
            this.cpulabel.Size = new System.Drawing.Size(67, 16);
            this.cpulabel.TabIndex = 24;
            this.cpulabel.Text = "Fetching...";
            this.cpulabel.Click += new System.EventHandler(this.cpulabel_Click);
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.BackColor = System.Drawing.Color.Transparent;
            this.ramlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramlabel.ForeColor = System.Drawing.Color.Gold;
            this.ramlabel.Location = new System.Drawing.Point(578, 171);
            this.ramlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Size = new System.Drawing.Size(67, 16);
            this.ramlabel.TabIndex = 25;
            this.ramlabel.Text = "Fetching...";
            this.ramlabel.Click += new System.EventHandler(this.ramlabel_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(272, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Command list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Animus.Properties.Resources.animus_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(699, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ramlabel);
            this.Controls.Add(this.cpulabel);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblcpu);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mB);
            this.Controls.Add(this.eB);
            this.Controls.Add(this.cB);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.wB);
            this.Controls.Add(this.exB);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerbox);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Animus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ImageList recordimages;
        private System.Windows.Forms.TextBox answerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gB;
        private System.Windows.Forms.Button exB;
        private System.Windows.Forms.Button wB;
        private System.Windows.Forms.Button tB;
        private System.Windows.Forms.Button cB;
        private System.Windows.Forms.Button eB;
        private System.Windows.Forms.Button mB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label lblcpu;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label cpulabel;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}

