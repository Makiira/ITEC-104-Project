namespace ITEC_104_Project.Controls
{
    partial class Control2
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
            taskContainer = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            editBtn = new Button();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            createBtn = new Button();
            taskContainer.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            SuspendLayout();
            // 
            // taskContainer
            // 
            taskContainer.Controls.Add(panel1);
            taskContainer.Controls.Add(panel2);
            taskContainer.Controls.Add(panel3);
            taskContainer.Controls.Add(panel4);
            taskContainer.Controls.Add(panel5);
            taskContainer.Controls.Add(panel6);
            taskContainer.Dock = DockStyle.Bottom;
            taskContainer.Location = new Point(0, 157);
            taskContainer.Name = "taskContainer";
            taskContainer.Size = new Size(911, 445);
            taskContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 213);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(305, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 213);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(607, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 213);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 222);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(296, 213);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Location = new Point(305, 222);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.Yes;
            panel5.Size = new Size(296, 213);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Location = new Point(607, 222);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.Yes;
            panel6.Size = new Size(296, 213);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(editBtn);
            panel7.Controls.Add(kryptonSeparator1);
            panel7.Controls.Add(createBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(911, 53);
            panel7.TabIndex = 1;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.Transparent;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editBtn.Location = new Point(110, 0);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(116, 50);
            editBtn.TabIndex = 6;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // kryptonSeparator1
            // 
            kryptonSeparator1.Location = new Point(119, 24);
            kryptonSeparator1.Name = "kryptonSeparator1";
            kryptonSeparator1.Size = new Size(5, 5);
            kryptonSeparator1.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.Transparent;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createBtn.Location = new Point(0, 0);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(116, 50);
            createBtn.TabIndex = 2;
            createBtn.Text = "CREATE";
            createBtn.UseVisualStyleBackColor = false;
            // 
            // Control2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 234, 220);
            Controls.Add(panel7);
            Controls.Add(taskContainer);
            Name = "Control2";
            Size = new Size(911, 602);
            taskContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel taskContainer;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button editBtn;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Button createBtn;
    }
}
