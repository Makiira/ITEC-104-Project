namespace ITEC_104_Project.Forms
{
    partial class createTaskForm
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
            components = new System.ComponentModel.Container();
            ctfAddBtn = new Button();
            label1 = new Label();
            titleTextbox = new TextBox();
            label2 = new Label();
            descTextBox = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            statusOption = new ComboBox();
            label5 = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // ctfAddBtn
            // 
            ctfAddBtn.BackColor = Color.FromArgb(85, 124, 211);
            ctfAddBtn.FlatAppearance.BorderSize = 0;
            ctfAddBtn.FlatStyle = FlatStyle.Flat;
            ctfAddBtn.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ctfAddBtn.ForeColor = Color.White;
            ctfAddBtn.Location = new Point(23, 357);
            ctfAddBtn.Name = "ctfAddBtn";
            ctfAddBtn.Size = new Size(117, 34);
            ctfAddBtn.TabIndex = 2;
            ctfAddBtn.Text = "ADD";
            ctfAddBtn.UseVisualStyleBackColor = false;
            ctfAddBtn.Click += ctfAddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 4;
            label1.Text = "Task Name:";
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(149, 69);
            titleTextbox.Name = "titleTextbox";
            titleTextbox.Size = new Size(247, 23);
            titleTextbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 110);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(149, 110);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(246, 101);
            descTextBox.TabIndex = 8;
            descTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 271);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 9;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 317);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 10;
            label4.Text = "End Date:";
            // 
            // statusOption
            // 
            statusOption.FormattingEnabled = true;
            statusOption.Items.AddRange(new object[] { "Low Priority", "Medium Priority", "High Priority" });
            statusOption.Location = new Point(149, 226);
            statusOption.Name = "statusOption";
            statusOption.Size = new Size(246, 23);
            statusOption.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 224);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 12;
            label5.Text = "Status:";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            startDateTimePicker.Location = new Point(150, 269);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(250, 23);
            startDateTimePicker.TabIndex = 13;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(149, 315);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(250, 23);
            endDateTimePicker.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(130, 25);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 15;
            label6.Text = "CREATE A TASK\r\n";
            // 
            // createTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 70);
            ClientSize = new Size(439, 421);
            Controls.Add(label6);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(label5);
            Controls.Add(statusOption);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(descTextBox);
            Controls.Add(label2);
            Controls.Add(titleTextbox);
            Controls.Add(label1);
            Controls.Add(ctfAddBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "createTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ctfAddBtn;
        private Label label1;
        public TextBox titleTextbox;
        private Label label2;
        public RichTextBox descTextBox;
        private Label label3;
        private Label label4;
        public ComboBox statusOption;
        private Label label5;
        public DateTimePicker startDateTimePicker;
        public DateTimePicker endDateTimePicker;
        private Label label6;
    }
}