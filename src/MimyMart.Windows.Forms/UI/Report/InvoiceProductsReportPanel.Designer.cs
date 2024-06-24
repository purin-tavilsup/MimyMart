namespace MimyMart.Windows.Forms.UI.Report
{
    partial class InvoiceProductsReportPanel
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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel8 = new Panel();
            ShowProductsByDateRangeButton = new ModernUI.ModernButton();
            label11 = new Label();
            label9 = new Label();
            EndDatePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            InvoiceProductsDataView = new DataGridView();
            Priority = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceProductsDataView).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(30, 30, 30);
            panel8.Controls.Add(ShowProductsByDateRangeButton);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(EndDatePicker);
            panel8.Controls.Add(StartDatePicker);
            panel8.Controls.Add(InvoiceProductsDataView);
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(3);
            panel8.Size = new Size(1610, 925);
            panel8.TabIndex = 4;
            // 
            // ShowProductsByDateRangeButton
            // 
            ShowProductsByDateRangeButton.BackColor = Color.FromArgb(38, 38, 38);
            ShowProductsByDateRangeButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ShowProductsByDateRangeButton.BorderColor = Color.DarkGray;
            ShowProductsByDateRangeButton.BorderRadius = 5;
            ShowProductsByDateRangeButton.BorderSize = 1;
            ShowProductsByDateRangeButton.FlatAppearance.BorderSize = 0;
            ShowProductsByDateRangeButton.FlatStyle = FlatStyle.Flat;
            ShowProductsByDateRangeButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowProductsByDateRangeButton.ForeColor = Color.White;
            ShowProductsByDateRangeButton.Location = new Point(1012, 3);
            ShowProductsByDateRangeButton.Name = "ShowProductsByDateRangeButton";
            ShowProductsByDateRangeButton.Size = new Size(180, 34);
            ShowProductsByDateRangeButton.TabIndex = 106;
            ShowProductsByDateRangeButton.Text = "แสดงผล";
            ShowProductsByDateRangeButton.TextColor = Color.White;
            ShowProductsByDateRangeButton.UseVisualStyleBackColor = false;
            ShowProductsByDateRangeButton.Click += ShowProductsByDateRangeButton_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(38, 38, 38);
            label11.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(381, 9);
            label11.Name = "label11";
            label11.Size = new Size(56, 31);
            label11.TabIndex = 105;
            label11.Text = "ถึง";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(38, 38, 38);
            label9.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(169, 9);
            label9.Name = "label9";
            label9.Size = new Size(56, 31);
            label9.TabIndex = 104;
            label9.Text = "จาก";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(443, 11);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(144, 25);
            EndDatePicker.TabIndex = 103;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(231, 11);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(144, 25);
            StartDatePicker.TabIndex = 101;
            // 
            // InvoiceProductsDataView
            // 
            InvoiceProductsDataView.AllowUserToAddRows = false;
            InvoiceProductsDataView.AllowUserToDeleteRows = false;
            InvoiceProductsDataView.AllowUserToResizeColumns = false;
            InvoiceProductsDataView.AllowUserToResizeRows = false;
            InvoiceProductsDataView.BackgroundColor = Color.FromArgb(38, 38, 38);
            InvoiceProductsDataView.BorderStyle = BorderStyle.None;
            InvoiceProductsDataView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            InvoiceProductsDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle1.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            InvoiceProductsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            InvoiceProductsDataView.ColumnHeadersHeight = 50;
            InvoiceProductsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            InvoiceProductsDataView.Columns.AddRange(new DataGridViewColumn[] { Priority, ProductCode, Description, Quantity, UnitPrice, Total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle2.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            InvoiceProductsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            InvoiceProductsDataView.Dock = DockStyle.Fill;
            InvoiceProductsDataView.EnableHeadersVisualStyles = false;
            InvoiceProductsDataView.GridColor = Color.DimGray;
            InvoiceProductsDataView.Location = new Point(3, 43);
            InvoiceProductsDataView.MultiSelect = false;
            InvoiceProductsDataView.Name = "InvoiceProductsDataView";
            InvoiceProductsDataView.ReadOnly = true;
            InvoiceProductsDataView.RowHeadersVisible = false;
            InvoiceProductsDataView.RowHeadersWidth = 60;
            InvoiceProductsDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(38, 38, 38);
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.ForeColor = Color.Gainsboro;
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            InvoiceProductsDataView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gainsboro;
            InvoiceProductsDataView.RowTemplate.Height = 35;
            InvoiceProductsDataView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            InvoiceProductsDataView.Size = new Size(1604, 879);
            InvoiceProductsDataView.TabIndex = 1;
            // 
            // Priority
            // 
            Priority.HeaderText = "ลำดับ";
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            // 
            // ProductCode
            // 
            ProductCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ProductCode.HeaderText = "รหัสสินค้า";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            ProductCode.Width = 200;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Description.HeaderText = "คำอธิบาย";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 350;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantity.HeaderText = "จำนวน";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            UnitPrice.HeaderText = "ราคาต่อหน่วย";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 150;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total.HeaderText = "ราคารวม";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(38, 38, 38);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(3, 3);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(1604, 40);
            label3.TabIndex = 48;
            label3.Text = "รายการสินค้า";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InvoiceProductsReportPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel8);
            Name = "InvoiceProductsReportPanel";
            Size = new Size(1610, 925);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoiceProductsDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView InvoiceProductsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private ModernUI.ModernButton ShowProductsByDateRangeButton;
    }
}
