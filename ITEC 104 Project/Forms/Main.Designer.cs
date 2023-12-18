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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            panel1 = new Panel();
            button1 = new Button();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            mainPanel = new Panel();
            Menu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            Menu.Controls.Add(iconButton3);
            Menu.Controls.Add(iconButton2);
            Menu.Controls.Add(panel2);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(187, 745);
            Menu.TabIndex = 0;
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
            iconButton3.Location = new Point(0, 203);
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
            iconButton2.Location = new Point(0, 136);
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
            // panel2
            // 
            panel2.Controls.Add(kryptonPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 136);
            panel2.TabIndex = 0;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.BackgroundImage = (Image)resources.GetObject("kryptonPictureBox1.BackgroundImage");
            kryptonPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            kryptonPictureBox1.Location = new Point(32, 12);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(129, 112);
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 124, 211);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(iconButton5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(187, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 75);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 0;
            button1.Text = "About Us";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // iconButton5
            // 
            iconButton5.BackgroundImageLayout = ImageLayout.None;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.FromArgb(85, 124, 211);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton5.IconColor = Color.Red;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 20;
            iconButton5.Location = new Point(871, 3);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(37, 29);
            iconButton5.TabIndex = 0;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(187, 75);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(911, 670);
            mainPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 745);
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
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase PaLetteMain;
        private Panel Menu;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel mainPanel;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Button button1;
    }
}