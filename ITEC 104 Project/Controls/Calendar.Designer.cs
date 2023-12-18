namespace ITEC_104_Project
{
    partial class Calendar
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
            panel1 = new Panel();
            calendarPrevButton = new Button();
            lbdate = new Label();
            calendarNextButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            daycontainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(calendarPrevButton);
            panel1.Controls.Add(lbdate);
            panel1.Controls.Add(calendarNextButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(daycontainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 670);
            panel1.TabIndex = 4;
            // 
            // calendarPrevButton
            // 
            calendarPrevButton.BackColor = Color.FromArgb(85, 124, 211);
            calendarPrevButton.FlatAppearance.BorderSize = 0;
            calendarPrevButton.FlatStyle = FlatStyle.Flat;
            calendarPrevButton.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            calendarPrevButton.ForeColor = Color.White;
            calendarPrevButton.Location = new Point(18, 625);
            calendarPrevButton.Name = "calendarPrevButton";
            calendarPrevButton.Size = new Size(95, 32);
            calendarPrevButton.TabIndex = 13;
            calendarPrevButton.Text = "PREVIOUS";
            calendarPrevButton.UseVisualStyleBackColor = false;
            calendarPrevButton.Click += calendarPrevButton_Click;
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Font = new Font("Poppins", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbdate.Location = new Point(365, 2);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(134, 31);
            lbdate.TabIndex = 12;
            lbdate.Text = "MONTH YEAR";
            // 
            // calendarNextButton
            // 
            calendarNextButton.BackColor = Color.FromArgb(85, 124, 211);
            calendarNextButton.FlatAppearance.BorderSize = 0;
            calendarNextButton.FlatStyle = FlatStyle.Flat;
            calendarNextButton.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            calendarNextButton.ForeColor = Color.White;
            calendarNextButton.Location = new Point(119, 625);
            calendarNextButton.Name = "calendarNextButton";
            calendarNextButton.Size = new Size(65, 32);
            calendarNextButton.TabIndex = 11;
            calendarNextButton.Text = "NEXT";
            calendarNextButton.UseVisualStyleBackColor = false;
            calendarNextButton.Click += calendarNextButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(749, 33);
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
            label6.Location = new Point(646, 33);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 9;
            label6.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(519, 33);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 8;
            label5.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(393, 33);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(284, 33);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 6;
            label3.Text = "Tuesday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(166, 33);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 5;
            label2.Text = "Monday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 4;
            label1.Text = "Sunday";
            // 
            // daycontainer
            // 
            daycontainer.BackColor = Color.White;
            daycontainer.Location = new Point(21, 61);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(844, 542);
            daycontainer.TabIndex = 3;
            daycontainer.Paint += daycontainer_Paint;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Calendar";
            Size = new Size(911, 670);
            Load += Calendar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button calendarPrevButton;
        private Label lbdate;
        private Button calendarNextButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel daycontainer;
    }
}
