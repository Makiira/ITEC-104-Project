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
            ctfAddBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            titleTextbox = new TextBox();
            label2 = new Label();
            descTextBox = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            statusOption = new ComboBox();
            label5 = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            panel1.SuspendLayout();
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
            // ctfAddBtn
            // 
            ctfAddBtn.Location = new Point(23, 394);
            ctfAddBtn.Name = "ctfAddBtn";
            ctfAddBtn.Size = new Size(91, 26);
            ctfAddBtn.TabIndex = 2;
            ctfAddBtn.Text = "ADD";
            ctfAddBtn.UseVisualStyleBackColor = true;
            ctfAddBtn.Click += ctfAddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 101);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "Task Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 189);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 53);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(398, 0);
            button1.Name = "button1";
            button1.Size = new Size(29, 27);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(150, 98);
            titleTextbox.Name = "titleTextbox";
            titleTextbox.Size = new Size(247, 23);
            titleTextbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 146);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(150, 146);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(246, 124);
            descTextBox.TabIndex = 8;
            descTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 328);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 9;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 359);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 10;
            label4.Text = "End Date:";
            // 
            // statusOption
            // 
            statusOption.FormattingEnabled = true;
            statusOption.Items.AddRange(new object[] { "Low Priority", "Medium Priority", "High Priority" });
            statusOption.Location = new Point(150, 285);
            statusOption.Name = "statusOption";
            statusOption.Size = new Size(246, 23);
            statusOption.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 288);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 12;
            label5.Text = "Status:";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(150, 326);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(250, 23);
            startDateTimePicker.TabIndex = 13;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(150, 355);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(250, 23);
            endDateTimePicker.TabIndex = 14;
            // 
            // createTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 465);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateTimePicker);
            Controls.Add(label5);
            Controls.Add(statusOption);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(descTextBox);
            Controls.Add(label2);
            Controls.Add(titleTextbox);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(ctfAddBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "createTaskForm";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 12F;
            StateCommon.Back.Color1 = Color.FromArgb(140, 148, 255);
            StateInactive.Back.Color1 = Color.FromArgb(140, 148, 255);
            Text = "createTaskForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Button ctfAddBtn;
        private Label label1;
        private Panel panel1;
        public TextBox titleTextbox;
        private Label label2;
        public RichTextBox descTextBox;
        private Label label3;
        private Label label4;
        public ComboBox statusOption;
        private Label label5;
        public DateTimePicker startDateTimePicker;
        public DateTimePicker endDateTimePicker;
        private Button button1;
    }
}