namespace ITEC_104_Project.Controls
{
    public partial class Control2
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
            panel7 = new Panel();
            editBTN = new Button();
            delBTN = new Button();
            srchTXTBox = new TextBox();
            srchBTN = new Button();
            kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            createBtn = new Button();
            data = new DataGridView();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(editBTN);
            panel7.Controls.Add(delBTN);
            panel7.Controls.Add(srchTXTBox);
            panel7.Controls.Add(srchBTN);
            panel7.Controls.Add(kryptonSeparator1);
            panel7.Controls.Add(createBtn);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(911, 53);
            panel7.TabIndex = 1;
            // 
            // editBTN
            // 
            editBTN.BackColor = Color.Transparent;
            editBTN.FlatAppearance.BorderSize = 0;
            editBTN.FlatStyle = FlatStyle.Flat;
            editBTN.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editBTN.Location = new Point(633, 0);
            editBTN.Name = "editBTN";
            editBTN.Size = new Size(120, 50);
            editBTN.TabIndex = 9;
            editBTN.Text = "EDIT";
            editBTN.UseVisualStyleBackColor = false;
            // 
            // delBTN
            // 
            delBTN.BackColor = Color.Transparent;
            delBTN.FlatAppearance.BorderSize = 0;
            delBTN.FlatStyle = FlatStyle.Flat;
            delBTN.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            delBTN.Location = new Point(184, 0);
            delBTN.Name = "delBTN";
            delBTN.Size = new Size(120, 50);
            delBTN.TabIndex = 8;
            delBTN.Text = "DELETE";
            delBTN.UseVisualStyleBackColor = false;
            delBTN.Click += delBTN_Click;
            // 
            // srchTXTBox
            // 
            srchTXTBox.Location = new Point(310, 16);
            srchTXTBox.Name = "srchTXTBox";
            srchTXTBox.Size = new Size(317, 23);
            srchTXTBox.TabIndex = 7;
            // 
            // srchBTN
            // 
            srchBTN.BackColor = Color.Transparent;
            srchBTN.FlatAppearance.BorderSize = 0;
            srchBTN.FlatStyle = FlatStyle.Flat;
            srchBTN.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            srchBTN.Location = new Point(77, 0);
            srchBTN.Name = "srchBTN";
            srchBTN.Size = new Size(120, 50);
            srchBTN.TabIndex = 6;
            srchBTN.Text = "SEARCH";
            srchBTN.UseVisualStyleBackColor = false;
            srchBTN.Click += srchBTN_Click;
            // 
            // kryptonSeparator1
            // 
            kryptonSeparator1.Location = new Point(119, 24);
            kryptonSeparator1.Name = "kryptonSeparator1";
            kryptonSeparator1.Size = new Size(5, 5);
            kryptonSeparator1.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.Transparent;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createBtn.Location = new Point(0, 0);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(81, 50);
            createBtn.TabIndex = 2;
            createBtn.Text = "ADD";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // data
            // 
            data.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.BackgroundColor = Color.White;
            data.BorderStyle = BorderStyle.Fixed3D;
            data.CellBorderStyle = DataGridViewCellBorderStyle.None;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(20, 76);
            data.MultiSelect = false;
            data.Name = "data";
            data.RowHeadersVisible = false;
            data.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
            data.RowTemplate.Height = 25;
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.Size = new Size(851, 484);
            data.TabIndex = 2;
            // 
            // Control2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 234, 220);
            Controls.Add(data);
            Controls.Add(panel7);
            Name = "Control2";
            Size = new Size(911, 602);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private Button createBtn;
        private DataGridView data;
        private TextBox srchTXTBox;
        private Button srchBTN;
        private Button delBTN;
        private Button editBTN;
    }
}
