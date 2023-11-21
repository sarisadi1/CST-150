namespace EarthWeightToMars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEarth = new Label();
            txtEarthWeight = new TextBox();
            lblMars = new Label();
            lblMarsWeight = new Label();
            btnConvert = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEarth
            // 
            lblEarth.AutoSize = true;
            lblEarth.Location = new Point(168, 83);
            lblEarth.Name = "lblEarth";
            lblEarth.Size = new Size(147, 15);
            lblEarth.TabIndex = 0;
            lblEarth.Text = "Enter your weight on Earth";
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Location = new Point(365, 80);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.Size = new Size(100, 23);
            txtEarthWeight.TabIndex = 1;
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.Location = new Point(218, 161);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(116, 15);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your weight on Mars";
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.AutoSize = true;
            lblMarsWeight.Location = new Point(375, 161);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(38, 15);
            lblMarsWeight.TabIndex = 3;
            lblMarsWeight.Text = "label1";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(365, 248);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 83);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "lbs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(lblMarsWeight);
            Controls.Add(lblMars);
            Controls.Add(txtEarthWeight);
            Controls.Add(lblEarth);
            Name = "Form1";
            Text = "Your Weight on Mars";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEarth;
        private TextBox txtEarthWeight;
        private Label lblMars;
        private Label lblMarsWeight;
        private Button btnConvert;
        private Label label1;
    }
}
