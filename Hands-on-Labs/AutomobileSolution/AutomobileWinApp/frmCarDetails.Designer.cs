namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbCarID = new Label();
            SuspendLayout();
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Times New Roman", 10.2F);
            lbCarName.Location = new Point(32, 74);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(77, 19);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Times New Roman", 10.2F);
            lbManufacturer.Location = new Point(32, 116);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(101, 19);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Times New Roman", 10.2F);
            lbPrice.Location = new Point(32, 161);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(46, 19);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Times New Roman", 10.2F);
            lbReleaseYear.Location = new Point(32, 198);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(104, 19);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.BackColor = SystemColors.Window;
            txtCarID.Location = new Point(180, 37);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(337, 25);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.BackColor = Color.White;
            txtCarName.Location = new Point(180, 74);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(337, 25);
            txtCarName.TabIndex = 6;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(180, 195);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(337, 25);
            txtReleaseYear.TabIndex = 7;
            txtReleaseYear.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 157);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(337, 25);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.BackColor = SystemColors.Window;
            cboManufacturer.ForeColor = SystemColors.ControlText;
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new Point(180, 116);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(337, 25);
            cboManufacturer.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(180, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 255, 192);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(397, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Times New Roman", 10.2F);
            lbCarID.ForeColor = SystemColors.ControlText;
            lbCarID.Location = new Point(32, 38);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(54, 19);
            lbCarID.TabIndex = 12;
            lbCarID.Text = "Car ID";
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 364);
            Controls.Add(lbCarID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private MaskedTextBox txtReleaseYear;
        private MaskedTextBox txtPrice;
        private ComboBox cboManufacturer;
        private Button btnSave;
        private Button btnCancel;
        private Label lbCarID;
    }
}