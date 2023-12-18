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
            eventLabel = new Label();
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
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.Font = new Font("Century", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            eventLabel.Location = new Point(9, 56);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(23, 15);
            eventLabel.TabIndex = 3;
            eventLabel.Text = "    ";
            // 
            // ucDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(eventLabel);
            Controls.Add(nameLabel);
            Controls.Add(lbDays);
            Name = "ucDays";
            Size = new Size(113, 102);
            Load += ucDays_Load;
            Click += ucDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDays;
        private Label nameLabel;
        private Label eventLabel;
    }
}
