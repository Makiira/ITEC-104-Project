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
            label1 = new Label();
            label2 = new Label();
            emailTxtBox = new Krypton.Toolkit.KryptonTextBox();
            loginButton1 = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            btnExit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnMaximize = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            passTxtBox = new Krypton.Toolkit.KryptonTextBox();
            signUpButton = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            kryptonToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FormLoginPalette
            // 
            FormLoginPalette.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormLoginPalette.BaseFontSize = 9F;
            FormLoginPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            FormLoginPalette.ButtonSpecs.FormClose.Image = (Image)resources.GetObject("resource.Image");
            FormLoginPalette.ButtonSpecs.FormClose.Style = Krypton.Toolkit.PaletteButtonStyle.Alternate;
            FormLoginPalette.Common.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FormLoginPalette.ThemeName = "";
            FormLoginPalette.UseKryptonFileDialogs = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(406, 54);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO TASK TUNE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins ExtraLight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 92);
            label2.Name = "label2";
            label2.Size = new Size(498, 112);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(28, 252);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(262, 31);
            emailTxtBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            emailTxtBox.StateActive.Border.Rounding = 12F;
            emailTxtBox.TabIndex = 3;
            // 
            // loginButton1
            // 
            loginButton1.Location = new Point(24, 379);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(179, 54);
            loginButton1.StateCommon.Back.Color1 = Color.Blue;
            loginButton1.StateCommon.Back.Color2 = Color.Cyan;
            loginButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            loginButton1.StateCommon.Border.Rounding = 12F;
            loginButton1.TabIndex = 4;
            loginButton1.Values.Text = "GET STARTED";
            loginButton1.Click += loginButton1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(85, 124, 211);
            panel1.Controls.Add(kryptonToolStrip1);
            panel1.Location = new Point(528, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 469);
            panel1.TabIndex = 6;
            // 
            // kryptonToolStrip1
            // 
            kryptonToolStrip1.AutoSize = false;
            kryptonToolStrip1.BackColor = Color.Transparent;
            kryptonToolStrip1.BackgroundImageLayout = ImageLayout.None;
            kryptonToolStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonToolStrip1.Items.AddRange(new ToolStripItem[] { btnExit, toolStripSeparator1, btnMaximize, toolStripSeparator2, toolStripButton3 });
            kryptonToolStrip1.Location = new Point(0, 0);
            kryptonToolStrip1.Name = "kryptonToolStrip1";
            kryptonToolStrip1.RenderMode = ToolStripRenderMode.System;
            kryptonToolStrip1.RightToLeft = RightToLeft.Yes;
            kryptonToolStrip1.Size = new Size(290, 28);
            kryptonToolStrip1.Stretch = true;
            kryptonToolStrip1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(23, 25);
            btnExit.Text = "toolStripButton1";
            btnExit.Click += btnExit_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnMaximize
            // 
            btnMaximize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.ImageTransparentColor = Color.Magenta;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(23, 25);
            btnMaximize.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 25);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // passTxtBox
            // 
            passTxtBox.Location = new Point(28, 326);
            passTxtBox.Name = "passTxtBox";
            passTxtBox.Size = new Size(262, 31);
            passTxtBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            passTxtBox.StateActive.Border.Rounding = 12F;
            passTxtBox.TabIndex = 7;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(251, 379);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(179, 54);
            signUpButton.StateCommon.Back.Color1 = Color.Blue;
            signUpButton.StateCommon.Back.Color2 = Color.Cyan;
            signUpButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            signUpButton.StateCommon.Border.Rounding = 12F;
            signUpButton.TabIndex = 8;
            signUpButton.Values.Text = "SIGN UP";
            signUpButton.Click += signUpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 221);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 295);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 189);
            ClientSize = new Size(818, 469);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(signUpButton);
            Controls.Add(passTxtBox);
            Controls.Add(panel1);
            Controls.Add(loginButton1);
            Controls.Add(emailTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Palette = FormLoginPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Back.Color1 = Color.FromArgb(192, 255, 255);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 24F;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            kryptonToolStrip1.ResumeLayout(false);
            kryptonToolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase FormLoginPalette;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox emailTxtBox;
        private Krypton.Toolkit.KryptonButton loginButton1;
        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox passTxtBox;
        private Krypton.Toolkit.KryptonButton signUpButton;
        private Label label3;
        private Label label4;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnMaximize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
    }
}