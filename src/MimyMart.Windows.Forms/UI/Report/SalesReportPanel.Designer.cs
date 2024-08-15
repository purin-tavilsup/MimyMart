namespace MimyMart.Windows.Forms.UI.Report
{
    partial class SalesReportPanel
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
            panel6 = new Panel();
            PeriodLabel = new Label();
            ShowReportByThisYearButton = new ModernUI.ModernButton();
            ShowReportByTodayButton = new ModernUI.ModernButton();
            ShowReportByThisMonthButton = new ModernUI.ModernButton();
            panel1 = new Panel();
            OverallSaleLabel = new Label();
            label26 = new Label();
            label5 = new Label();
            panel14 = new Panel();
            PaymentByTransferLabel = new Label();
            label29 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            ShowReportByDateRangeButton = new ModernUI.ModernButton();
            label11 = new Label();
            label9 = new Label();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            label7 = new Label();
            panel3 = new Panel();
            PaymentByCashLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(38, 38, 38);
            panel6.Controls.Add(PeriodLabel);
            panel6.Controls.Add(ShowReportByThisYearButton);
            panel6.Controls.Add(ShowReportByTodayButton);
            panel6.Controls.Add(ShowReportByThisMonthButton);
            panel6.Location = new Point(3, 7);
            panel6.Name = "panel6";
            panel6.Size = new Size(433, 92);
            panel6.TabIndex = 106;
            // 
            // PeriodLabel
            // 
            PeriodLabel.BackColor = Color.FromArgb(38, 38, 38);
            PeriodLabel.Dock = DockStyle.Top;
            PeriodLabel.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F);
            PeriodLabel.ForeColor = Color.MediumAquamarine;
            PeriodLabel.Location = new Point(0, 0);
            PeriodLabel.Name = "PeriodLabel";
            PeriodLabel.Size = new Size(433, 39);
            PeriodLabel.TabIndex = 83;
            PeriodLabel.Text = "เลือกเวลา";
            PeriodLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowReportByThisYearButton
            // 
            ShowReportByThisYearButton.BackColor = Color.FromArgb(38, 38, 38);
            ShowReportByThisYearButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ShowReportByThisYearButton.BorderColor = Color.Gray;
            ShowReportByThisYearButton.BorderRadius = 5;
            ShowReportByThisYearButton.BorderSize = 1;
            ShowReportByThisYearButton.FlatAppearance.BorderSize = 0;
            ShowReportByThisYearButton.FlatStyle = FlatStyle.Flat;
            ShowReportByThisYearButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            ShowReportByThisYearButton.ForeColor = Color.White;
            ShowReportByThisYearButton.Location = new Point(286, 42);
            ShowReportByThisYearButton.Name = "ShowReportByThisYearButton";
            ShowReportByThisYearButton.Size = new Size(130, 36);
            ShowReportByThisYearButton.TabIndex = 97;
            ShowReportByThisYearButton.Text = "ปีนี้";
            ShowReportByThisYearButton.TextColor = Color.White;
            ShowReportByThisYearButton.UseVisualStyleBackColor = false;
            ShowReportByThisYearButton.Click += ShowReportByThisYearButton_Click;
            // 
            // ShowReportByTodayButton
            // 
            ShowReportByTodayButton.BackColor = Color.FromArgb(38, 38, 38);
            ShowReportByTodayButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ShowReportByTodayButton.BorderColor = Color.Gray;
            ShowReportByTodayButton.BorderRadius = 5;
            ShowReportByTodayButton.BorderSize = 1;
            ShowReportByTodayButton.FlatAppearance.BorderSize = 0;
            ShowReportByTodayButton.FlatStyle = FlatStyle.Flat;
            ShowReportByTodayButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            ShowReportByTodayButton.ForeColor = Color.White;
            ShowReportByTodayButton.Location = new Point(16, 42);
            ShowReportByTodayButton.Name = "ShowReportByTodayButton";
            ShowReportByTodayButton.Size = new Size(130, 36);
            ShowReportByTodayButton.TabIndex = 94;
            ShowReportByTodayButton.Text = "วันนี้";
            ShowReportByTodayButton.TextColor = Color.White;
            ShowReportByTodayButton.UseVisualStyleBackColor = false;
            ShowReportByTodayButton.Click += ShowReportByTodayButton_Click;
            // 
            // ShowReportByThisMonthButton
            // 
            ShowReportByThisMonthButton.BackColor = Color.FromArgb(38, 38, 38);
            ShowReportByThisMonthButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ShowReportByThisMonthButton.BorderColor = Color.Gray;
            ShowReportByThisMonthButton.BorderRadius = 5;
            ShowReportByThisMonthButton.BorderSize = 1;
            ShowReportByThisMonthButton.FlatAppearance.BorderSize = 0;
            ShowReportByThisMonthButton.FlatStyle = FlatStyle.Flat;
            ShowReportByThisMonthButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            ShowReportByThisMonthButton.ForeColor = Color.White;
            ShowReportByThisMonthButton.Location = new Point(151, 42);
            ShowReportByThisMonthButton.Name = "ShowReportByThisMonthButton";
            ShowReportByThisMonthButton.Size = new Size(130, 36);
            ShowReportByThisMonthButton.TabIndex = 96;
            ShowReportByThisMonthButton.Text = "เดือนนี้";
            ShowReportByThisMonthButton.TextColor = Color.White;
            ShowReportByThisMonthButton.UseVisualStyleBackColor = false;
            ShowReportByThisMonthButton.Click += ShowReportByThisMonthButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 38, 38);
            panel1.Controls.Add(OverallSaleLabel);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(3, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 190);
            panel1.TabIndex = 102;
            // 
            // OverallSaleLabel
            // 
            OverallSaleLabel.BackColor = Color.FromArgb(38, 38, 38);
            OverallSaleLabel.Dock = DockStyle.Fill;
            OverallSaleLabel.Font = new Font("FC Subject [Non-commercial] Reg", 24F);
            OverallSaleLabel.ForeColor = Color.PaleGreen;
            OverallSaleLabel.Location = new Point(0, 39);
            OverallSaleLabel.Name = "OverallSaleLabel";
            OverallSaleLabel.Size = new Size(300, 115);
            OverallSaleLabel.TabIndex = 87;
            OverallSaleLabel.Text = "0.00";
            OverallSaleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.BackColor = Color.FromArgb(38, 38, 38);
            label26.Dock = DockStyle.Bottom;
            label26.Font = new Font("FC Subject [Non-commercial] Reg", 9F);
            label26.ForeColor = Color.Gainsboro;
            label26.Location = new Point(0, 154);
            label26.Name = "label26";
            label26.Size = new Size(300, 36);
            label26.TabIndex = 88;
            label26.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(38, 38, 38);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(300, 39);
            label5.TabIndex = 83;
            label5.Text = " ยอดขาย";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(38, 38, 38);
            panel14.Controls.Add(PaymentByTransferLabel);
            panel14.Controls.Add(label29);
            panel14.Controls.Add(label4);
            panel14.Location = new Point(615, 105);
            panel14.Name = "panel14";
            panel14.Size = new Size(300, 190);
            panel14.TabIndex = 113;
            // 
            // PaymentByTransferLabel
            // 
            PaymentByTransferLabel.BackColor = Color.FromArgb(38, 38, 38);
            PaymentByTransferLabel.Dock = DockStyle.Fill;
            PaymentByTransferLabel.Font = new Font("FC Subject [Non-commercial] Reg", 24F);
            PaymentByTransferLabel.ForeColor = Color.Khaki;
            PaymentByTransferLabel.Location = new Point(0, 39);
            PaymentByTransferLabel.Name = "PaymentByTransferLabel";
            PaymentByTransferLabel.Size = new Size(300, 115);
            PaymentByTransferLabel.TabIndex = 87;
            PaymentByTransferLabel.Text = "0.00";
            PaymentByTransferLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.BackColor = Color.FromArgb(38, 38, 38);
            label29.Dock = DockStyle.Bottom;
            label29.Font = new Font("FC Subject [Non-commercial] Reg", 9F);
            label29.ForeColor = Color.Gainsboro;
            label29.Location = new Point(0, 154);
            label29.Name = "label29";
            label29.Size = new Size(300, 36);
            label29.TabIndex = 89;
            label29.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(38, 38, 38);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(300, 39);
            label4.TabIndex = 83;
            label4.Text = " ยอดโอนเงิน";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.Controls.Add(ShowReportByDateRangeButton);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(StartDatePicker);
            panel2.Controls.Add(EndDatePicker);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(442, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 92);
            panel2.TabIndex = 122;
            // 
            // ShowReportByDateRangeButton
            // 
            ShowReportByDateRangeButton.BackColor = Color.FromArgb(38, 38, 38);
            ShowReportByDateRangeButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ShowReportByDateRangeButton.BorderColor = Color.DarkGray;
            ShowReportByDateRangeButton.BorderRadius = 5;
            ShowReportByDateRangeButton.BorderSize = 1;
            ShowReportByDateRangeButton.FlatAppearance.BorderSize = 0;
            ShowReportByDateRangeButton.FlatStyle = FlatStyle.Flat;
            ShowReportByDateRangeButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            ShowReportByDateRangeButton.ForeColor = Color.White;
            ShowReportByDateRangeButton.Location = new Point(500, 42);
            ShowReportByDateRangeButton.Name = "ShowReportByDateRangeButton";
            ShowReportByDateRangeButton.Size = new Size(180, 36);
            ShowReportByDateRangeButton.TabIndex = 108;
            ShowReportByDateRangeButton.Text = "แสดงผล";
            ShowReportByDateRangeButton.TextColor = Color.White;
            ShowReportByDateRangeButton.UseVisualStyleBackColor = false;
            ShowReportByDateRangeButton.Click += ShowReportByDateRangeButton_Click;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(38, 38, 38);
            label11.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(255, 44);
            label11.Name = "label11";
            label11.Size = new Size(56, 31);
            label11.TabIndex = 107;
            label11.Text = "ถึง";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(38, 38, 38);
            label9.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(22, 44);
            label9.Name = "label9";
            label9.Size = new Size(56, 31);
            label9.TabIndex = 106;
            label9.Text = "จาก";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(84, 46);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(153, 25);
            StartDatePicker.TabIndex = 105;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(317, 46);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(153, 25);
            EndDatePicker.TabIndex = 104;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(38, 38, 38);
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1085, 39);
            label7.TabIndex = 84;
            label7.Text = " เลือกช่วงเวลาแบบกำหนดเอง";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 38, 38);
            panel3.Controls.Add(PaymentByCashLabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(309, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 190);
            panel3.TabIndex = 123;
            // 
            // PaymentByCashLabel
            // 
            PaymentByCashLabel.BackColor = Color.FromArgb(38, 38, 38);
            PaymentByCashLabel.Dock = DockStyle.Fill;
            PaymentByCashLabel.Font = new Font("FC Subject [Non-commercial] Reg", 24F);
            PaymentByCashLabel.ForeColor = Color.Turquoise;
            PaymentByCashLabel.Location = new Point(0, 39);
            PaymentByCashLabel.Name = "PaymentByCashLabel";
            PaymentByCashLabel.Size = new Size(300, 115);
            PaymentByCashLabel.TabIndex = 87;
            PaymentByCashLabel.Text = "0.00";
            PaymentByCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(38, 38, 38);
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("FC Subject [Non-commercial] Reg", 9F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 154);
            label2.Name = "label2";
            label2.Size = new Size(300, 36);
            label2.TabIndex = 89;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(38, 38, 38);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(300, 39);
            label3.TabIndex = 83;
            label3.Text = " ยอดเงินสด";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SalesReportPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel14);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "SalesReportPanel";
            Size = new Size(1610, 925);
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Label PeriodLabel;
        private ModernUI.ModernButton ShowReportByThisYearButton;
        private ModernUI.ModernButton ShowReportByTodayButton;
        private ModernUI.ModernButton ShowReportByThisMonthButton;
        private Panel panel1;
        private Label OverallSaleLabel;
        private Label label5;
        private Label PaymentByTransferLabel;
        private Panel panel14;
        private Label label4;
        private Label label26;
        private Label label29;
        private Panel panel2;
        private Label label7;
        private ModernUI.ModernButton ShowReportByDateRangeButton;
        private Label label11;
        private Label label9;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Panel panel3;
        private Label PaymentByCashLabel;
        private Label label2;
        private Label label3;
    }
}
