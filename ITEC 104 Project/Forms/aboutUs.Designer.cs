namespace ITEC_104_Project.Forms
{
    partial class aboutUs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(214, 22);
            label1.TabIndex = 0;
            label1.Text = "ITEC 104 FINAL PROJECT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 82);
            label2.Name = "label2";
            label2.Size = new Size(279, 75);
            label2.TabIndex = 1;
            label2.Text = "TaskTune was developed by a team of BS computer\r\n science students at LSPU - SPCC  as their final \r\nrequirement for ITEC 104, to be submitted to\r\nMs Arida\r\n\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 168);
            label3.Name = "label3";
            label3.Size = new Size(181, 119);
            label3.TabIndex = 2;
            label3.Text = "DEVELOPERS\r\nALIBUYOG, Paul Jensen\r\nBALATBAT, Ellaine Rose\r\nBALELA, Karylle Rose\r\nCABAEL, Ben Jiru\r\nCOPIOSO, Mark Rainier S.\r\n\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 70);
            ClientSize = new Size(303, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "aboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}