namespace ITEC_104_Project.Controls
{
    partial class Control3
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
            panel2 = new Panel();
            prevButton = new Button();
            lbdate = new Label();
            nxtButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            daycontainer = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(prevButton);
            panel2.Controls.Add(lbdate);
            panel2.Controls.Add(nxtButton);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(daycontainer);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(686, 599);
            panel2.TabIndex = 3;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(18, 553);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(71, 32);
            prevButton.TabIndex = 13;
            prevButton.Text = "PREVIOUS";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbdate.Location = new Point(306, 0);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(104, 25);
            lbdate.TabIndex = 12;
            lbdate.Text = "MONTH YEAR";
            lbdate.Click += lbdate_Click;
            // 
            // nxtButton
            // 
            nxtButton.Location = new Point(89, 553);
            nxtButton.Name = "nxtButton";
            nxtButton.Size = new Size(65, 32);
            nxtButton.TabIndex = 11;
            nxtButton.Text = "NEXT";
            nxtButton.UseVisualStyleBackColor = true;
            nxtButton.Click += nxtButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(584, 33);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 10;
            label7.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(500, 33);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 9;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(394, 33);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 8;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(291, 33);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(210, 33);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 6;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 5;
            label2.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 4;
            label1.Text = "Sunday";
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(3, 64);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(678, 483);
            daycontainer.TabIndex = 3;
            // 
            // Control3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 234, 220);
            Controls.Add(panel2);
            Name = "Control3";
            Size = new Size(911, 602);
            Load += Control3_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel daycontainer;
        private Button nxtButton;
        private Label lbdate;
        private Button prevButton;
    }
}
