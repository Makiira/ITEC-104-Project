namespace ITEC_104_Project
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            registerPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            UsernameInput = new GroupBox();
            UsernameTxtbox = new Krypton.Toolkit.KryptonTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            groupBox1 = new GroupBox();
            confirmpasstxtbox = new Krypton.Toolkit.KryptonTextBox();
            groupBox2 = new GroupBox();
            passwordtxtBox = new Krypton.Toolkit.KryptonTextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            createAccount = new Krypton.Toolkit.KryptonButton();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            UsernameInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // registerPalette
            // 
            registerPalette.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerPalette.BaseFontSize = 9F;
            registerPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            registerPalette.Common.StateCommon.Back.Color1 = Color.FromArgb(192, 255, 255);
            registerPalette.Common.StateCommon.Back.Color2 = Color.Cyan;
            registerPalette.ThemeName = "";
            registerPalette.UseKryptonFileDialogs = true;
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = Color.Transparent;
            UsernameInput.Controls.Add(UsernameTxtbox);
            UsernameInput.Controls.Add(iconPictureBox1);
            UsernameInput.Font = new Font("Poppins Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameInput.ForeColor = Color.FromArgb(0, 59, 189);
            UsernameInput.Location = new Point(36, 138);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(273, 53);
            UsernameInput.TabIndex = 0;
            UsernameInput.TabStop = false;
            UsernameInput.Text = "Username";
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.Location = new Point(48, 16);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(219, 33);
            UsernameTxtbox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UsernameTxtbox.StateActive.Border.Rounding = 12F;
            UsernameTxtbox.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 59, 189);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox1.IconColor = Color.FromArgb(0, 59, 189);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(6, 22);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(36, 25);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(iconPictureBox2);
            groupBox1.Controls.Add(confirmpasstxtbox);
            groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(0, 59, 189);
            groupBox1.Location = new Point(36, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 53);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Confirm Password";
            // 
            // confirmpasstxtbox
            // 
            confirmpasstxtbox.Location = new Point(48, 16);
            confirmpasstxtbox.Name = "confirmpasstxtbox";
            confirmpasstxtbox.Size = new Size(219, 32);
            confirmpasstxtbox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            confirmpasstxtbox.StateActive.Border.Rounding = 12F;
            confirmpasstxtbox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(passwordtxtBox);
            groupBox2.Controls.Add(iconPictureBox3);
            groupBox2.Font = new Font("Poppins Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(0, 59, 189);
            groupBox2.Location = new Point(36, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 53);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // passwordtxtBox
            // 
            passwordtxtBox.Location = new Point(48, 16);
            passwordtxtBox.Name = "passwordtxtBox";
            passwordtxtBox.Size = new Size(219, 33);
            passwordtxtBox.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            passwordtxtBox.StateActive.Border.Rounding = 12F;
            passwordtxtBox.TabIndex = 1;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = Color.FromArgb(0, 59, 189);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = Color.FromArgb(0, 59, 189);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 25;
            iconPictureBox3.Location = new Point(6, 22);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(36, 25);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(232, 358);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(42, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOGIN";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 358);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 4;
            label1.Text = "Already have an account?";
            // 
            // createAccount
            // 
            createAccount.Location = new Point(56, 389);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(208, 54);
            createAccount.StateCommon.Back.Color1 = Color.DodgerBlue;
            createAccount.StateCommon.Back.Color2 = Color.Cyan;
            createAccount.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            createAccount.StateCommon.Border.Rounding = 12F;
            createAccount.TabIndex = 9;
            createAccount.Values.Text = "GET STARTED";
            createAccount.Click += createAccount_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 59, 189);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(0, 59, 189);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(6, 23);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(36, 25);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 2;
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 59, 189);
            label2.Location = new Point(56, 27);
            label2.Name = "label2";
            label2.Size = new Size(232, 72);
            label2.TabIndex = 10;
            label2.Text = "WELCOME\r\nCREATE AN ACCOUNT\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(342, 455);
            Controls.Add(label2);
            Controls.Add(createAccount);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(UsernameInput);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Palette = registerPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 10F;
            Text = "RegistrationForm";
            UsernameInput.ResumeLayout(false);
            UsernameInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase registerPalette;
        private GroupBox UsernameInput;
        private Krypton.Toolkit.KryptonTextBox UsernameTxtbox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonTextBox confirmpasstxtbox;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonTextBox passwordtxtBox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private LinkLabel linkLabel1;
        private Label label1;
        private Krypton.Toolkit.KryptonButton createAccount;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
    }
}