namespace Animus
{
    partial class weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weather));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labcondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.windspeed = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labcountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(57, 21);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(193, 27);
            this.TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(278, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labcondition
            // 
            this.labcondition.AutoSize = true;
            this.labcondition.BackColor = System.Drawing.Color.Transparent;
            this.labcondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcondition.ForeColor = System.Drawing.Color.White;
            this.labcondition.Location = new System.Drawing.Point(12, 167);
            this.labcondition.Name = "labcondition";
            this.labcondition.Size = new System.Drawing.Size(85, 23);
            this.labcondition.TabIndex = 3;
            this.labcondition.Text = "Condition";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(12, 224);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(62, 23);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(100, 276);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(100, 323);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 23);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(423, 214);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 23);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(297, 214);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(83, 23);
            this.pressure.TabIndex = 11;
            this.pressure.Text = "Pressure:";
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.ForeColor = System.Drawing.Color.White;
            this.labWindspeed.Location = new System.Drawing.Point(423, 167);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(39, 23);
            this.labWindspeed.TabIndex = 10;
            this.labWindspeed.Text = "N/A";
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.ForeColor = System.Drawing.Color.White;
            this.windspeed.Location = new System.Drawing.Point(297, 167);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(106, 23);
            this.windspeed.TabIndex = 9;
            this.windspeed.Text = "Wind speed:";
            // 
            // picicon
            // 
            this.picicon.BackColor = System.Drawing.Color.Transparent;
            this.picicon.Location = new System.Drawing.Point(16, 76);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(123, 61);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picicon.TabIndex = 13;
            this.picicon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(297, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Country";
            // 
            // labcountry
            // 
            this.labcountry.AutoSize = true;
            this.labcountry.BackColor = System.Drawing.Color.Transparent;
            this.labcountry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcountry.ForeColor = System.Drawing.Color.White;
            this.labcountry.Location = new System.Drawing.Point(423, 276);
            this.labcountry.Name = "labcountry";
            this.labcountry.Size = new System.Drawing.Size(39, 23);
            this.labcountry.TabIndex = 15;
            this.labcountry.Text = "N/A";
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 434);
            this.Controls.Add(this.labcountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.labWindspeed);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labcondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "weather";
            this.Text = "weather";
            this.Load += new System.EventHandler(this.weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labcondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.PictureBox picicon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labcountry;
    }
}