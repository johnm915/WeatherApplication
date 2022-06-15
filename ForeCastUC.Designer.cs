
namespace WeatherApplication
{
    partial class ForeCastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labDT = new System.Windows.Forms.Label();
            this.labWeatherCond = new System.Windows.Forms.Label();
            this.LabMainWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(0, 0);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(76, 59);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(8, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.Color.Black;
            this.labDT.Location = new System.Drawing.Point(82, 0);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(47, 15);
            this.labDT.TabIndex = 2;
            this.labDT.Text = "Sunday";
            // 
            // labWeatherCond
            // 
            this.labWeatherCond.AutoSize = true;
            this.labWeatherCond.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherCond.ForeColor = System.Drawing.Color.Black;
            this.labWeatherCond.Location = new System.Drawing.Point(82, 15);
            this.labWeatherCond.Name = "labWeatherCond";
            this.labWeatherCond.Size = new System.Drawing.Size(36, 15);
            this.labWeatherCond.TabIndex = 3;
            this.labWeatherCond.Text = "Clear";
            // 
            // LabMainWeather
            // 
            this.LabMainWeather.AutoSize = true;
            this.LabMainWeather.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMainWeather.ForeColor = System.Drawing.Color.Black;
            this.LabMainWeather.Location = new System.Drawing.Point(82, 30);
            this.LabMainWeather.Name = "LabMainWeather";
            this.LabMainWeather.Size = new System.Drawing.Size(72, 15);
            this.LabMainWeather.TabIndex = 4;
            this.LabMainWeather.Text = "Descreption";
            // 
            // ForeCastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabMainWeather);
            this.Controls.Add(this.labWeatherCond);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picWeatherIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ForeCastUC";
            this.Size = new System.Drawing.Size(157, 61);
            this.Load += new System.EventHandler(this.ForeCastUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labWeatherCond;
        public System.Windows.Forms.Label LabMainWeather;
        public System.Windows.Forms.Label labDT;
    }
}
