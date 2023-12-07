namespace ITEC_104_Project
{
    partial class splashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            palette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            label1 = new Label();
            label2 = new Label();
            progress = new Krypton.Toolkit.KryptonProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // palette
            // 
            palette.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            palette.BaseFontSize = 9F;
            palette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            palette.Common.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            palette.Common.StateCommon.Border.Rounding = 24F;
            palette.ThemeName = "";
            palette.UseKryptonFileDialogs = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins Black", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 146);
            label1.Name = "label1";
            label1.Size = new Size(196, 58);
            label1.TabIndex = 1;
            label1.Text = "WELCOME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(424, 258);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 2;
            label2.Text = "VERSION 1.0";
            // 
            // progress
            // 
            progress.Location = new Point(2, 277);
            progress.Name = "progress";
            progress.Size = new Size(515, 18);
            progress.StateCommon.Back.Color1 = Color.FromArgb(192, 255, 192);
            progress.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            progress.StateCommon.Border.Rounding = 8F;
            progress.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progress.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            progress.TabIndex = 3;
            progress.Values.Text = "";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 188);
            label3.Name = "label3";
            label3.Size = new Size(255, 70);
            label3.TabIndex = 4;
            label3.Text = "TASK TUNE";
            // 
            // splashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(518, 292);
            Controls.Add(label3);
            Controls.Add(progress);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "splashScreen";
            Palette = palette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += splashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase palette;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonProgressBar progress;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}