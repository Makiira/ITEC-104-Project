namespace ITEC_104_Project.Controls
{
    partial class Control1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 152);
            panel1.TabIndex = 0;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.Common.StateCommon.Border.Rounding = 10F;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 161);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 0;
            label1.Text = "RECENT ACTIVITIES";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(620, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 356);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(152, 26);
            label2.TabIndex = 0;
            label2.Text = "RECENT ACTIVITIES";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(544, 161);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 21);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 0;
            label3.Text = "TODAY'S TASKS";
            // 
            // Control1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 234, 220);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Control1";
            Size = new Size(859, 553);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label3;
    }
}
