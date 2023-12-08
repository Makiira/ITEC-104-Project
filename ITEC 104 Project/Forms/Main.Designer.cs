namespace ITEC_104_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PaLetteMain = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            Menu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            menuButton = new FontAwesome.Sharp.IconButton();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnExit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            mainPanel = new Panel();
            Menu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PaLetteMain
            // 
            PaLetteMain.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PaLetteMain.BaseFontSize = 9F;
            PaLetteMain.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            PaLetteMain.ThemeName = "";
            PaLetteMain.UseKryptonFileDialogs = true;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(28, 41, 70);
            Menu.Controls.Add(iconButton4);
            Menu.Controls.Add(iconButton3);
            Menu.Controls.Add(iconButton2);
            Menu.Controls.Add(iconButton1);
            Menu.Controls.Add(panel2);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(187, 677);
            Menu.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = SystemColors.ControlLightLight;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(0, 337);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(187, 67);
            iconButton4.TabIndex = 4;
            iconButton4.Tag = "Button4";
            iconButton4.Text = "   HOME";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(0, 270);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(187, 67);
            iconButton3.TabIndex = 3;
            iconButton3.Tag = " Calendar";
            iconButton3.Text = "   Calendar";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(0, 203);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(187, 67);
            iconButton2.TabIndex = 2;
            iconButton2.Tag = "Projects";
            iconButton2.Text = "   Projects";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 136);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(187, 67);
            iconButton1.TabIndex = 1;
            iconButton1.Tag = "Home";
            iconButton1.Text = "   Home";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Controls.Add(kryptonPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 136);
            panel2.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuButton.ForeColor = SystemColors.ControlLightLight;
            menuButton.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            menuButton.IconColor = Color.White;
            menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuButton.IconSize = 40;
            menuButton.Location = new Point(140, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(47, 44);
            menuButton.TabIndex = 5;
            menuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Location = new Point(24, 43);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(66, 62);
            kryptonPictureBox1.TabIndex = 2;
            kryptonPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 124, 211);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(187, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 75);
            panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.BackgroundImageLayout = ImageLayout.None;
            toolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExit, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(911, 33);
            toolStrip1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 30);
            btnExit.Text = "toolStripButton1";
            btnExit.Click += btnExit_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 30);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 30);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(187, 75);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(911, 602);
            mainPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 677);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Palette = PaLetteMain;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 12F;
            Text = "Main";
            Load += Main_Load;
            Menu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase PaLetteMain;
        private Panel Menu;
        private Panel panel1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton menuButton;
        private Panel mainPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
    }
}