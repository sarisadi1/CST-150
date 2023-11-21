namespace HelloWorldFormsApp
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
            btnHelloButtonTest = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHelloButtonTest
            // 
            btnHelloButtonTest.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelloButtonTest.ForeColor = SystemColors.MenuHighlight;
            btnHelloButtonTest.Location = new Point(336, 85);
            btnHelloButtonTest.Name = "btnHelloButtonTest";
            btnHelloButtonTest.Size = new Size(82, 34);
            btnHelloButtonTest.TabIndex = 0;
            btnHelloButtonTest.Text = "Click Here";
            btnHelloButtonTest.UseVisualStyleBackColor = true;
            btnHelloButtonTest.Click += button1_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "1b1HelloWorldLabel";
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 199);
            label1.Name = "label1";
            label1.Size = new Size(74, 37);
            label1.TabIndex = 1;
            label1.Text = "label";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnHelloButtonTest);
            Name = "Form1";
            Text = "HelloWorldWork";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHelloButtonTest;
        private Label label1;
    }
}
