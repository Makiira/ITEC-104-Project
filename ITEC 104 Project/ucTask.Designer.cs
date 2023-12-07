namespace ITEC_104_Project
{
    partial class ucTask
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 69);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 36);
            textBox1.TabIndex = 1;
            textBox1.Text = "TITLE";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(258, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 20);
            textBox2.TabIndex = 2;
            textBox2.Text = "date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins ExtraLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 100);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 3;
            label1.Text = "Note";
            // 
            // ucTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ucTask";
            Size = new Size(296, 213);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}
