namespace ITEC_104_Project
{
    partial class ucDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDays = new Label();
            nameLabel = new Label();
            SuspendLayout();
            // 
            // lbDays
            // 
            lbDays.AutoSize = true;
            lbDays.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDays.Location = new Point(3, 9);
            lbDays.Name = "lbDays";
            lbDays.Size = new Size(23, 16);
            lbDays.TabIndex = 1;
            lbDays.Text = "00";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(3, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 16);
            nameLabel.TabIndex = 2;
            // 
            // ucDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameLabel);
            Controls.Add(lbDays);
            Name = "ucDays";
            Size = new Size(108, 83);
            Load += ucDays_Load;
            Click += ucDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDays;
        private Label nameLabel;
    }
}
