namespace ITEC_104_Project
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            FormLoginPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnMaximize = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            emailTxtBox = new Krypton.Toolkit.KryptonTextBox();
            loginButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FormLoginPalette
            // 
            FormLoginPalette.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormLoginPalette.BaseFontSize = 9F;
            FormLoginPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            FormLoginPalette.Common.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FormLoginPalette.ThemeName = "";
            FormLoginPalette.UseKryptonFileDialogs = true;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.BackColor = Color.Transparent;
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, btnMaximize, toolStripSeparator2, toolStripButton3 });
            kryptonToolStrip1.Location = new Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.RightToLeft = RightToLeft.Yes;
            kryptonToolStrip1.Size = new Size(800, 25);
            kryptonToolStrip1.TabIndex = 0;
            kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnMaximize
            // 
            btnMaximize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.ImageTransparentColor = Color.Magenta;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(23, 22);
            btnMaximize.Text = "toolStripButton2";
            btnMaximize.Click += btnMaximize_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 99);
            label1.Name = "label1";
            label1.Size = new Size(346, 70);
            label1.TabIndex = 1;
            label1.Text = "To-Do-List Application for \r\nWindows Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 196);
            label2.Name = "label2";
            label2.Size = new Size(410, 48);
            label2.TabIndex = 2;
            label2.Text = "A C# winform application that streamlines the \r\nstudent's activities";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(32, 263);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(410, 31);
            emailTxtBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            emailTxtBox.StateActive.Border.Rounding = 12F;
            emailTxtBox.TabIndex = 3;
            // 
            // loginButton1
            // 
            loginButton1.Location = new Point(32, 331);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(179, 54);
            loginButton1.StateCommon.Back.Color1 = Color.DodgerBlue;
            loginButton1.StateCommon.Back.Color2 = Color.Cyan;
            loginButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton1.StateCommon.Border.Rounding = 12F;
            loginButton1.TabIndex = 4;
            loginButton1.Values.Text = "GET STARTED";
            loginButton1.Click += loginButton1_Click;
            loginButton1.KeyPress += loginButton1_KeyPress;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(262, 331);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(180, 54);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 12F;
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.Text = "GET STARTED";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(471, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 425);
            panel1.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(kryptonButton1);
            Controls.Add(loginButton1);
            Controls.Add(emailTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kryptonToolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Palette = FormLoginPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StateActive.Back.Color1 = Color.FromArgb(192, 255, 255);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 24F;
            Text = "FormLogin";
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase FormLoginPalette;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnMaximize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox emailTxtBox;
        private Krypton.Toolkit.KryptonButton loginButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Panel panel1;
    }
}