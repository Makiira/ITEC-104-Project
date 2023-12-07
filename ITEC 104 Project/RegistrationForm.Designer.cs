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
            registerPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            SuspendLayout();
            // 
            // registerPalette
            // 
            registerPalette.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerPalette.BaseFontSize = 9F;
            registerPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            registerPalette.ThemeName = "";
            registerPalette.UseKryptonFileDialogs = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Name = "RegistrationForm";
            Palette = registerPalette;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Text = "RegistrationForm";
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase registerPalette;
    }
}