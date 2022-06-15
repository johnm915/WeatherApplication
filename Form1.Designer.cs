
using System;

namespace WeatherApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNScearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.TBCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(412, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City:";
            // 
            // BTNScearch
            // 
            this.BTNScearch.BackColor = System.Drawing.Color.Transparent;
            this.BTNScearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNScearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNScearch.ForeColor = System.Drawing.Color.White;
            this.BTNScearch.Location = new System.Drawing.Point(752, 80);
            this.BTNScearch.Name = "BTNScearch";
            this.BTNScearch.Size = new System.Drawing.Size(94, 31);
            this.BTNScearch.TabIndex = 2;
            this.BTNScearch.Text = "Search";
            this.BTNScearch.UseVisualStyleBackColor = false;
            this.BTNScearch.Click += new System.EventHandler(this.BTNScearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.Black;
            this.labCondition.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labCondition.Location = new System.Drawing.Point(278, 187);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(85, 23);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            this.labCondition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.Black;
            this.labDetails.Location = new System.Drawing.Point(278, 222);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(62, 23);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            this.labDetails.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.Location = new System.Drawing.Point(413, 322);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 23);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.Location = new System.Drawing.Point(413, 361);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 23);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(752, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wind Speed:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.Location = new System.Drawing.Point(931, 321);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(39, 23);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.Location = new System.Drawing.Point(931, 361);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 23);
            this.labPressure.TabIndex = 11;
            this.labPressure.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(747, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pressure:";
            // 
            // lab0
            // 
            this.lab0.AutoSize = true;
            this.lab0.BackColor = System.Drawing.Color.Transparent;
            this.lab0.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab0.ForeColor = System.Drawing.Color.Black;
            this.lab0.Location = new System.Drawing.Point(919, 222);
            this.lab0.Name = "lab0";
            this.lab0.Size = new System.Drawing.Size(51, 23);
            this.lab0.TabIndex = 13;
            this.lab0.Text = "Temp";
            this.lab0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(747, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Temperature:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(451, 184);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 61);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 17;
            this.picIcon.TabStop = false;
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.AutoSize = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(227, 452);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(825, 69);
            this.FLP.TabIndex = 19;
            this.FLP.WrapContents = false;
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(542, 80);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(195, 31);
            this.TBCity.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApplication.Properties.Resources.clouds_g05887aa97_19202;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1057, 547);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lab0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.BTNScearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNScearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TextBox TBCity;
        public System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

