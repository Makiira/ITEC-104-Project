namespace ITEC_104_Project.Forms
{
    partial class createEventForm
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
            eventTextBox = new TextBox();
            addBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "EVENT: ";
            // 
            // eventTextBox
            // 
            eventTextBox.AcceptsReturn = true;
            eventTextBox.Location = new Point(78, 40);
            eventTextBox.Name = "eventTextBox";
            eventTextBox.Size = new Size(185, 23);
            eventTextBox.TabIndex = 1;
            //eventTextBox.TextChanged += eventTextBox_TextChanged;
            // 
            // addBTN
            // 
            addBTN.BackColor = Color.FromArgb(85, 124, 211);
            addBTN.FlatAppearance.BorderSize = 0;
            addBTN.FlatStyle = FlatStyle.Flat;
            addBTN.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBTN.ForeColor = Color.White;
            addBTN.Location = new Point(78, 81);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(136, 29);
            addBTN.TabIndex = 2;
            addBTN.Text = "ADD EVENT";
            addBTN.UseVisualStyleBackColor = false;
            addBTN.Click += addBTN_Click;
            // 
            // createEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 41, 70);
            ClientSize = new Size(275, 146);
            Controls.Add(addBTN);
            Controls.Add(eventTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "createEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox eventTextBox;
        private Button addBTN;
    }
}