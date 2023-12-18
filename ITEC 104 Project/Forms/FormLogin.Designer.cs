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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            loginButton1 = new Button();
            extiButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Font = new Font("Century Gothic", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(378, 37);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO TASK TUNE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 129);
            label2.Name = "label2";
            label2.Size = new Size(354, 100);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 124, 211);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(419, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 358);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 217);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginButton1
            // 
            loginButton1.BackColor = Color.FromArgb(0, 170, 245);
            loginButton1.FlatAppearance.BorderSize = 0;
            loginButton1.FlatStyle = FlatStyle.Flat;
            loginButton1.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton1.ForeColor = SystemColors.ControlLightLight;
            loginButton1.Location = new Point(24, 268);
            loginButton1.Name = "loginButton1";
            loginButton1.Size = new Size(159, 54);
            loginButton1.TabIndex = 8;
            loginButton1.Text = "GET STARTED";
            loginButton1.UseVisualStyleBackColor = false;
            loginButton1.Click += loginButton1_Click_1;
            // 
            // extiButton
            // 
            extiButton.BackColor = Color.Red;
            extiButton.FlatAppearance.BorderSize = 0;
            extiButton.FlatStyle = FlatStyle.Flat;
            extiButton.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            extiButton.ForeColor = SystemColors.ControlLightLight;
            extiButton.Location = new Point(243, 268);
            extiButton.Name = "extiButton";
            extiButton.Size = new Size(159, 54);
            extiButton.TabIndex = 9;
            extiButton.Text = "EXIT";
            extiButton.UseVisualStyleBackColor = false;
            extiButton.Click += extiButton_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 59, 189);
            ClientSize = new Size(706, 358);
            Controls.Add(extiButton);
            Controls.Add(loginButton1);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase FormLoginPalette;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button loginButton1;
        private Button extiButton;
    }
}