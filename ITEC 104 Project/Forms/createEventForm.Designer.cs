﻿namespace ITEC_104_Project.Forms
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
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "EVENT: ";
            // 
            // eventTextBox
            // 
            eventTextBox.AcceptsReturn = true;
            eventTextBox.Location = new Point(89, 33);
            eventTextBox.Name = "eventTextBox";
            eventTextBox.Size = new Size(210, 23);
            eventTextBox.TabIndex = 1;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(25, 154);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(136, 29);
            addBTN.TabIndex = 2;
            addBTN.Text = "button1";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // createEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 226);
            Controls.Add(addBTN);
            Controls.Add(eventTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "createEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox eventTextBox;
        private Button addBTN;
    }
}