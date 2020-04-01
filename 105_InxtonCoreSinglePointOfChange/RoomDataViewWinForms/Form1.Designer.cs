namespace RoomDataViewWinForms
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
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbVOC = new System.Windows.Forms.Label();
            this.lbCO2 = new System.Windows.Forms.Label();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbVOC = new System.Windows.Forms.TextBox();
            this.tbCO2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(74, 37);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(51, 20);
            this.lbTemperature.TabIndex = 0;
            this.lbTemperature.Text = "label1";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Location = new System.Drawing.Point(74, 90);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(51, 20);
            this.lbHumidity.TabIndex = 1;
            this.lbHumidity.Text = "label2";
            // 
            // lbVOC
            // 
            this.lbVOC.AutoSize = true;
            this.lbVOC.Location = new System.Drawing.Point(74, 150);
            this.lbVOC.Name = "lbVOC";
            this.lbVOC.Size = new System.Drawing.Size(51, 20);
            this.lbVOC.TabIndex = 2;
            this.lbVOC.Text = "label3";
            // 
            // lbCO2
            // 
            this.lbCO2.AutoSize = true;
            this.lbCO2.Location = new System.Drawing.Point(74, 209);
            this.lbCO2.Name = "lbCO2";
            this.lbCO2.Size = new System.Drawing.Size(51, 20);
            this.lbCO2.TabIndex = 3;
            this.lbCO2.Text = "label4";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(440, 34);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(100, 26);
            this.tbTemperature.TabIndex = 4;
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(440, 90);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(100, 26);
            this.tbHumidity.TabIndex = 5;
            // 
            // tbVOC
            // 
            this.tbVOC.Location = new System.Drawing.Point(440, 150);
            this.tbVOC.Name = "tbVOC";
            this.tbVOC.Size = new System.Drawing.Size(100, 26);
            this.tbVOC.TabIndex = 6;
            // 
            // tbCO2
            // 
            this.tbCO2.Location = new System.Drawing.Point(440, 209);
            this.tbCO2.Name = "tbCO2";
            this.tbCO2.Size = new System.Drawing.Size(100, 26);
            this.tbCO2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCO2);
            this.Controls.Add(this.tbVOC);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbCO2);
            this.Controls.Add(this.lbVOC);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbVOC;
        private System.Windows.Forms.Label lbCO2;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbVOC;
        private System.Windows.Forms.TextBox tbCO2;
    }
}

