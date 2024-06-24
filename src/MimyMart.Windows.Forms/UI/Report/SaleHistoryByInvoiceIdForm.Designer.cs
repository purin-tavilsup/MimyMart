namespace MimyMart.Windows.Forms.UI.Report
{
    partial class SaleHistoryByInvoiceIdForm
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
            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();
            var dataGridViewCellStyle4 = new DataGridViewCellStyle();
            InvoiceIdLabel = new Label();
            panel2 = new Panel();
            CloseButton = new ModernUI.ModernButton();
            panel3 = new Panel();
            panel4 = new Panel();
            InvoiceProductsDataView = new DataGridView();
            Priority = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel5 = new Panel();
            PaymentDataView = new DataGridView();
            PaymentPriority = new DataGridViewTextBoxColumn();
            PaymentType = new DataGridViewTextBoxColumn();
            PaymentAmount = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceProductsDataView).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDataView).BeginInit();
            SuspendLayout();
            // 
            // InvoiceIdLabel
            // 
            InvoiceIdLabel.BackColor = Color.DarkSlateGray;
            InvoiceIdLabel.Dock = DockStyle.Top;
            InvoiceIdLabel.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceIdLabel.ForeColor = Color.WhiteSmoke;
            InvoiceIdLabel.Location = new Point(0, 0);
            InvoiceIdLabel.Name = "InvoiceIdLabel";
            InvoiceIdLabel.Size = new Size(1700, 39);
            InvoiceIdLabel.TabIndex = 38;
            InvoiceIdLabel.Text = "Invoice ID :";
            InvoiceIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 25, 25);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 907);
            panel2.Name = "panel2";
            panel2.Size = new Size(1700, 93);
            panel2.TabIndex = 47;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(38, 38, 38);
            CloseButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            CloseButton.BorderColor = Color.FromArgb(50, 190, 166);
            CloseButton.BorderRadius = 19;
            CloseButton.BorderSize = 1;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(771, 18);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(158, 53);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "ปิด";
            CloseButton.TextColor = Color.White;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(1700, 868);
            panel3.TabIndex = 112;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(InvoiceProductsDataView);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1700, 658);
            panel4.TabIndex = 0;
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
            InvoiceProductsDataView.Location = new Point(0, 40);
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
            InvoiceProductsDataView.Size = new Size(1698, 616);
            InvoiceProductsDataView.TabIndex = 51;
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
            // label2
            // 
            label2.BackColor = Color.FromArgb(38, 38, 38);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(1698, 40);
            label2.TabIndex = 50;
            label2.Text = "รายการสินค้า";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(PaymentDataView);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 658);
            panel5.Name = "panel5";
            panel5.Size = new Size(1700, 210);
            panel5.TabIndex = 1;
            // 
            // PaymentDataView
            // 
            PaymentDataView.AllowUserToAddRows = false;
            PaymentDataView.AllowUserToDeleteRows = false;
            PaymentDataView.AllowUserToResizeColumns = false;
            PaymentDataView.AllowUserToResizeRows = false;
            PaymentDataView.BackgroundColor = Color.FromArgb(38, 38, 38);
            PaymentDataView.BorderStyle = BorderStyle.None;
            PaymentDataView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PaymentDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            PaymentDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PaymentDataView.ColumnHeadersHeight = 50;
            PaymentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PaymentDataView.Columns.AddRange(new DataGridViewColumn[] { PaymentPriority, PaymentType, PaymentAmount, Note });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(38, 38, 38);
            dataGridViewCellStyle4.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            PaymentDataView.DefaultCellStyle = dataGridViewCellStyle4;
            PaymentDataView.Dock = DockStyle.Fill;
            PaymentDataView.EnableHeadersVisualStyles = false;
            PaymentDataView.GridColor = Color.DimGray;
            PaymentDataView.Location = new Point(0, 40);
            PaymentDataView.MultiSelect = false;
            PaymentDataView.Name = "PaymentDataView";
            PaymentDataView.ReadOnly = true;
            PaymentDataView.RowHeadersVisible = false;
            PaymentDataView.RowHeadersWidth = 60;
            PaymentDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            PaymentDataView.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PaymentDataView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(38, 38, 38);
            PaymentDataView.RowTemplate.DefaultCellStyle.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentDataView.RowTemplate.DefaultCellStyle.ForeColor = Color.Gainsboro;
            PaymentDataView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
            PaymentDataView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gainsboro;
            PaymentDataView.RowTemplate.Height = 35;
            PaymentDataView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            PaymentDataView.Size = new Size(855, 168);
            PaymentDataView.TabIndex = 51;
            // 
            // PaymentPriority
            // 
            PaymentPriority.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaymentPriority.HeaderText = "ลำดับ";
            PaymentPriority.Name = "PaymentPriority";
            PaymentPriority.ReadOnly = true;
            // 
            // PaymentType
            // 
            PaymentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaymentType.HeaderText = "ประเภทการชำระเงิน";
            PaymentType.Name = "PaymentType";
            PaymentType.ReadOnly = true;
            PaymentType.Width = 300;
            // 
            // PaymentAmount
            // 
            PaymentAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaymentAmount.HeaderText = "จำนวนเงิน";
            PaymentAmount.Name = "PaymentAmount";
            PaymentAmount.ReadOnly = true;
            PaymentAmount.Width = 250;
            // 
            // Note
            // 
            Note.HeaderText = "Note";
            Note.Name = "Note";
            Note.ReadOnly = true;
            Note.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 38, 38);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(855, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 168);
            panel1.TabIndex = 52;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(38, 38, 38);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(1698, 40);
            label3.TabIndex = 50;
            label3.Text = "รายการเงิน";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SaleHistoryByInvoiceIdForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1700, 1000);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(InvoiceIdLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SaleHistoryByInvoiceIdForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoiceProductsDataView).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PaymentDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label InvoiceIdLabel;
        private System.Windows.Forms.Panel panel2;
        private ModernUI.ModernButton CloseButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView InvoiceProductsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView PaymentDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}