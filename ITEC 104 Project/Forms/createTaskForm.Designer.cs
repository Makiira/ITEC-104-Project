namespace ITEC_104_Project.Forms
{
    partial class createTaskForm
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
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            titleTask = new TextBox();
            descTask = new RichTextBox();
            ctfAddBtn = new Button();
            button2 = new Button();
            dtp1 = new DateTimePicker();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // titleTask
            // 
            titleTask.BackColor = SystemColors.Control;
            titleTask.BorderStyle = BorderStyle.None;
            titleTask.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleTask.Location = new Point(12, 89);
            titleTask.Name = "titleTask";
            titleTask.Size = new Size(509, 32);
            titleTask.TabIndex = 0;
            titleTask.Text = "TITLE";
            // 
            // descTask
            // 
            descTask.BackColor = SystemColors.Control;
            descTask.Font = new Font("Poppins ExtraLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            descTask.Location = new Point(12, 127);
            descTask.Name = "descTask";
            descTask.Size = new Size(509, 191);
            descTask.TabIndex = 1;
            descTask.Text = "Note";
            // 
            // ctfAddBtn
            // 
            ctfAddBtn.Location = new Point(12, 324);
            ctfAddBtn.Name = "ctfAddBtn";
            ctfAddBtn.Size = new Size(91, 26);
            ctfAddBtn.TabIndex = 2;
            ctfAddBtn.Text = "ADD";
            ctfAddBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(109, 325);
            button2.Name = "button2";
            button2.Size = new Size(91, 26);
            button2.TabIndex = 3;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(332, 80);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(189, 23);
            dtp1.TabIndex = 4;
            // 
            // createTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(533, 363);
            Controls.Add(dtp1);
            Controls.Add(button2);
            Controls.Add(ctfAddBtn);
            Controls.Add(descTask);
            Controls.Add(titleTask);
            FormBorderStyle = FormBorderStyle.None;
            Name = "createTaskForm";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Text = "createTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private TextBox titleTask;
        private RichTextBox descTask;
        private Button ctfAddBtn;
        private Button button2;
        private DateTimePicker dtp1;
    }
}