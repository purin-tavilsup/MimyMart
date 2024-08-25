using MimyMart.Windows.Forms.Properties;

namespace MimyMart.Windows.Forms.UI.Report
{
    partial class CashFlowCalculatorPanel
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
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            ChangesListView = new ListView();
            PayoutsListView = new ListView();
            Coin1CountTotalLabel = new Label();
            Coin2CountTotalLabel = new Label();
            Coin5CountTotalLabel = new Label();
            Coin10CountTotalLabel = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            BankNote20CountTotalLabel = new Label();
            BankNote50CountTotalLabel = new Label();
            BankNote100CountTotalLabel = new Label();
            BankNote500CountTotalLabel = new Label();
            BankNote1000CountTotalLabel = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label3 = new Label();
            label10 = new Label();
            DateLabel = new Label();
            PullLatestDataFromDatabaseButton = new ModernUI.ModernButton();
            SaveToFileButton = new ModernUI.ModernButton();
            AddChangeButton = new ModernUI.ModernButton();
            RemoveChangeButton = new ModernUI.ModernButton();
            panel1 = new Panel();
            ResetCountingButton = new ModernUI.ModernButton();
            panel2 = new Panel();
            label4 = new Label();
            ChangeAmountTextBox = new ModernUI.ModernTextBox();
            ChangesTotalLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            panel14 = new Panel();
            MoneyTransferPaymentTotalLabel = new Label();
            label19 = new Label();
            panel4 = new Panel();
            SalesTotalLabel = new Label();
            label20 = new Label();
            panel5 = new Panel();
            label22 = new Label();
            RemovePayOutButton = new ModernUI.ModernButton();
            AddPayOutButton = new ModernUI.ModernButton();
            PayoutsTotalLabel = new Label();
            label21 = new Label();
            label14 = new Label();
            PayOutAmountTextBox = new ModernUI.ModernTextBox();
            PayOutItemTextBox = new ModernUI.ModernTextBox();
            label7 = new Label();
            label18 = new Label();
            panel6 = new Panel();
            BankNote20CountTextBox = new ModernUI.ModernTextBox();
            BankNote50CountTextBox = new ModernUI.ModernTextBox();
            BankNote100CountTextBox = new ModernUI.ModernTextBox();
            BankNote500CountTextBox = new ModernUI.ModernTextBox();
            BankNote1000CountTextBox = new ModernUI.ModernTextBox();
            label23 = new Label();
            panel7 = new Panel();
            Coin1CountTextBox = new ModernUI.ModernTextBox();
            Coin2CountTextBox = new ModernUI.ModernTextBox();
            Coin5CountTextBox = new ModernUI.ModernTextBox();
            Coin10CountTextBox = new ModernUI.ModernTextBox();
            label24 = new Label();
            panel9 = new Panel();
            ActualCashTotalLabel = new Label();
            label26 = new Label();
            panel10 = new Panel();
            CalculatedCashTotalLabel = new Label();
            label32 = new Label();
            panel11 = new Panel();
            DiffCashLabel = new Label();
            DiffCashDescriptionLabel = new Label();
            label37 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(29, 177);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 36);
            label8.TabIndex = 4;
            label8.Text = "100";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(29, 134);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 36);
            label5.TabIndex = 1;
            label5.Text = "500";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(29, 91);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 36);
            label6.TabIndex = 0;
            label6.Text = "1,000";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangesListView
            // 
            ChangesListView.BackColor = Color.FromArgb(38, 38, 38);
            ChangesListView.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            ChangesListView.ForeColor = Color.Gainsboro;
            ChangesListView.LabelEdit = true;
            ChangesListView.Location = new Point(39, 160);
            ChangesListView.Margin = new Padding(6, 7, 6, 7);
            ChangesListView.MultiSelect = false;
            ChangesListView.Name = "ChangesListView";
            ChangesListView.Size = new Size(278, 280);
            ChangesListView.TabIndex = 3;
            ChangesListView.UseCompatibleStateImageBehavior = false;
            ChangesListView.View = View.Details;
            ChangesListView.Click += ChangesListView_Click;
            // 
            // PayoutsListView
            // 
            PayoutsListView.BackColor = Color.FromArgb(38, 38, 38);
            PayoutsListView.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            PayoutsListView.ForeColor = Color.Gainsboro;
            PayoutsListView.Location = new Point(47, 220);
            PayoutsListView.Margin = new Padding(6, 7, 6, 7);
            PayoutsListView.MultiSelect = false;
            PayoutsListView.Name = "PayoutsListView";
            PayoutsListView.Size = new Size(334, 454);
            PayoutsListView.TabIndex = 3;
            PayoutsListView.UseCompatibleStateImageBehavior = false;
            PayoutsListView.Click += PayOutListView_Click;
            // 
            // Coin1CountTotalLabel
            // 
            Coin1CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin1CountTotalLabel.ForeColor = Color.Gainsboro;
            Coin1CountTotalLabel.Location = new Point(263, 215);
            Coin1CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            Coin1CountTotalLabel.Name = "Coin1CountTotalLabel";
            Coin1CountTotalLabel.Size = new Size(78, 36);
            Coin1CountTotalLabel.TabIndex = 42;
            Coin1CountTotalLabel.Text = "0.00";
            Coin1CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin2CountTotalLabel
            // 
            Coin2CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin2CountTotalLabel.ForeColor = Color.Gainsboro;
            Coin2CountTotalLabel.Location = new Point(263, 175);
            Coin2CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            Coin2CountTotalLabel.Name = "Coin2CountTotalLabel";
            Coin2CountTotalLabel.Size = new Size(78, 36);
            Coin2CountTotalLabel.TabIndex = 41;
            Coin2CountTotalLabel.Text = "0.00";
            Coin2CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin5CountTotalLabel
            // 
            Coin5CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin5CountTotalLabel.ForeColor = Color.Gainsboro;
            Coin5CountTotalLabel.Location = new Point(263, 135);
            Coin5CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            Coin5CountTotalLabel.Name = "Coin5CountTotalLabel";
            Coin5CountTotalLabel.Size = new Size(78, 36);
            Coin5CountTotalLabel.TabIndex = 40;
            Coin5CountTotalLabel.Text = "0.00";
            Coin5CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Coin10CountTotalLabel
            // 
            Coin10CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin10CountTotalLabel.ForeColor = Color.Gainsboro;
            Coin10CountTotalLabel.Location = new Point(263, 95);
            Coin10CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            Coin10CountTotalLabel.Name = "Coin10CountTotalLabel";
            Coin10CountTotalLabel.Size = new Size(78, 36);
            Coin10CountTotalLabel.TabIndex = 39;
            Coin10CountTotalLabel.Text = "0.00";
            Coin10CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            label27.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label27.ForeColor = Color.Gainsboro;
            label27.Location = new Point(263, 55);
            label27.Margin = new Padding(6, 0, 6, 0);
            label27.Name = "label27";
            label27.Size = new Size(78, 24);
            label27.TabIndex = 38;
            label27.Text = "ยอดรวม";
            label27.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            label28.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label28.ForeColor = Color.Gainsboro;
            label28.Location = new Point(111, 55);
            label28.Margin = new Padding(6, 0, 6, 0);
            label28.Name = "label28";
            label28.Size = new Size(140, 24);
            label28.TabIndex = 37;
            label28.Text = "จำนวนนับ";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label29.ForeColor = Color.Gainsboro;
            label29.Location = new Point(29, 55);
            label29.Margin = new Padding(6, 0, 6, 0);
            label29.Name = "label29";
            label29.Size = new Size(76, 24);
            label29.TabIndex = 36;
            label29.Text = "เหรีญ";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.BorderStyle = BorderStyle.FixedSingle;
            label30.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label30.ForeColor = Color.Gainsboro;
            label30.Location = new Point(29, 215);
            label30.Margin = new Padding(6, 0, 6, 0);
            label30.Name = "label30";
            label30.Size = new Size(76, 36);
            label30.TabIndex = 27;
            label30.Text = "1";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label33.ForeColor = Color.Gainsboro;
            label33.Location = new Point(29, 95);
            label33.Margin = new Padding(6, 0, 6, 0);
            label33.Name = "label33";
            label33.Size = new Size(76, 36);
            label33.TabIndex = 24;
            label33.Text = "10";
            label33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label34.ForeColor = Color.Gainsboro;
            label34.Location = new Point(29, 175);
            label34.Margin = new Padding(6, 0, 6, 0);
            label34.Name = "label34";
            label34.Size = new Size(76, 36);
            label34.TabIndex = 26;
            label34.Text = "2";
            label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            label35.BorderStyle = BorderStyle.FixedSingle;
            label35.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label35.ForeColor = Color.Gainsboro;
            label35.Location = new Point(29, 135);
            label35.Margin = new Padding(6, 0, 6, 0);
            label35.Name = "label35";
            label35.Size = new Size(76, 36);
            label35.TabIndex = 25;
            label35.Text = "5";
            label35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BankNote20CountTotalLabel
            // 
            BankNote20CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote20CountTotalLabel.ForeColor = Color.Gainsboro;
            BankNote20CountTotalLabel.Location = new Point(263, 265);
            BankNote20CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            BankNote20CountTotalLabel.Name = "BankNote20CountTotalLabel";
            BankNote20CountTotalLabel.Size = new Size(78, 34);
            BankNote20CountTotalLabel.TabIndex = 22;
            BankNote20CountTotalLabel.Text = "0.00";
            BankNote20CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote50CountTotalLabel
            // 
            BankNote50CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote50CountTotalLabel.ForeColor = Color.Gainsboro;
            BankNote50CountTotalLabel.Location = new Point(263, 222);
            BankNote50CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            BankNote50CountTotalLabel.Name = "BankNote50CountTotalLabel";
            BankNote50CountTotalLabel.Size = new Size(78, 34);
            BankNote50CountTotalLabel.TabIndex = 21;
            BankNote50CountTotalLabel.Text = "0.00";
            BankNote50CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote100CountTotalLabel
            // 
            BankNote100CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote100CountTotalLabel.ForeColor = Color.Gainsboro;
            BankNote100CountTotalLabel.Location = new Point(263, 179);
            BankNote100CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            BankNote100CountTotalLabel.Name = "BankNote100CountTotalLabel";
            BankNote100CountTotalLabel.Size = new Size(78, 34);
            BankNote100CountTotalLabel.TabIndex = 20;
            BankNote100CountTotalLabel.Text = "0.00";
            BankNote100CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote500CountTotalLabel
            // 
            BankNote500CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote500CountTotalLabel.ForeColor = Color.Gainsboro;
            BankNote500CountTotalLabel.Location = new Point(263, 136);
            BankNote500CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            BankNote500CountTotalLabel.Name = "BankNote500CountTotalLabel";
            BankNote500CountTotalLabel.Size = new Size(78, 34);
            BankNote500CountTotalLabel.TabIndex = 19;
            BankNote500CountTotalLabel.Text = "0.00";
            BankNote500CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNote1000CountTotalLabel
            // 
            BankNote1000CountTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote1000CountTotalLabel.ForeColor = Color.Gainsboro;
            BankNote1000CountTotalLabel.Location = new Point(263, 93);
            BankNote1000CountTotalLabel.Margin = new Padding(6, 0, 6, 0);
            BankNote1000CountTotalLabel.Name = "BankNote1000CountTotalLabel";
            BankNote1000CountTotalLabel.Size = new Size(78, 34);
            BankNote1000CountTotalLabel.TabIndex = 18;
            BankNote1000CountTotalLabel.Text = "0.00";
            BankNote1000CountTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label13.ForeColor = Color.Gainsboro;
            label13.Location = new Point(263, 52);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(78, 24);
            label13.TabIndex = 17;
            label13.Text = "ยอดรวม";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(111, 52);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 24);
            label12.TabIndex = 16;
            label12.Text = "จำนวนนับ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(29, 52);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(76, 24);
            label11.TabIndex = 15;
            label11.Text = "ธนบัตร";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(29, 220);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 36);
            label3.TabIndex = 5;
            label3.Text = "50";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(29, 263);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 36);
            label10.TabIndex = 6;
            label10.Text = "20";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            DateLabel.BackColor = Color.FromArgb(38, 38, 38);
            DateLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            DateLabel.ForeColor = Color.Gainsboro;
            DateLabel.Location = new Point(1240, 15);
            DateLabel.Margin = new Padding(6, 0, 6, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(280, 42);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Date";
            DateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PullLatestDataFromDatabaseButton
            // 
            PullLatestDataFromDatabaseButton.BackColor = Color.FromArgb(38, 38, 38);
            PullLatestDataFromDatabaseButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            PullLatestDataFromDatabaseButton.BorderColor = Color.Gainsboro;
            PullLatestDataFromDatabaseButton.BorderRadius = 5;
            PullLatestDataFromDatabaseButton.BorderSize = 1;
            PullLatestDataFromDatabaseButton.FlatAppearance.BorderSize = 0;
            PullLatestDataFromDatabaseButton.FlatStyle = FlatStyle.Flat;
            PullLatestDataFromDatabaseButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PullLatestDataFromDatabaseButton.ForeColor = Color.Gainsboro;
            PullLatestDataFromDatabaseButton.Location = new Point(34, 15);
            PullLatestDataFromDatabaseButton.Name = "PullLatestDataFromDatabaseButton";
            PullLatestDataFromDatabaseButton.Size = new Size(180, 42);
            PullLatestDataFromDatabaseButton.TabIndex = 107;
            PullLatestDataFromDatabaseButton.Text = "ดึงข้อมูลล่าสุด";
            PullLatestDataFromDatabaseButton.TextColor = Color.Gainsboro;
            PullLatestDataFromDatabaseButton.UseVisualStyleBackColor = false;
            PullLatestDataFromDatabaseButton.Click += PullLatestDataFromDatabaseButton_Click;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.BackColor = Color.FromArgb(38, 38, 38);
            SaveToFileButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            SaveToFileButton.BorderColor = Color.Gainsboro;
            SaveToFileButton.BorderRadius = 5;
            SaveToFileButton.BorderSize = 1;
            SaveToFileButton.FlatAppearance.BorderSize = 0;
            SaveToFileButton.FlatStyle = FlatStyle.Flat;
            SaveToFileButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveToFileButton.ForeColor = Color.Gainsboro;
            SaveToFileButton.Location = new Point(452, 15);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(180, 42);
            SaveToFileButton.TabIndex = 108;
            SaveToFileButton.Text = "บันทึก";
            SaveToFileButton.TextColor = Color.Gainsboro;
            SaveToFileButton.UseVisualStyleBackColor = false;
            SaveToFileButton.Click += SaveToFileButton_Click;
            // 
            // AddChangeButton
            // 
            AddChangeButton.BackColor = Color.FromArgb(38, 38, 38);
            AddChangeButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            AddChangeButton.BorderColor = Color.MediumSpringGreen;
            AddChangeButton.BorderRadius = 5;
            AddChangeButton.BorderSize = 1;
            AddChangeButton.FlatAppearance.BorderSize = 0;
            AddChangeButton.FlatStyle = FlatStyle.Flat;
            AddChangeButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddChangeButton.ForeColor = Color.White;
            AddChangeButton.Location = new Point(240, 114);
            AddChangeButton.Name = "AddChangeButton";
            AddChangeButton.Size = new Size(77, 34);
            AddChangeButton.TabIndex = 109;
            AddChangeButton.Text = "เพิ่ม";
            AddChangeButton.TextColor = Color.White;
            AddChangeButton.UseVisualStyleBackColor = false;
            AddChangeButton.Click += AddChangeButton_Click;
            // 
            // RemoveChangeButton
            // 
            RemoveChangeButton.BackColor = Color.FromArgb(38, 38, 38);
            RemoveChangeButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            RemoveChangeButton.BorderColor = Color.Salmon;
            RemoveChangeButton.BorderRadius = 5;
            RemoveChangeButton.BorderSize = 1;
            RemoveChangeButton.FlatAppearance.BorderSize = 0;
            RemoveChangeButton.FlatStyle = FlatStyle.Flat;
            RemoveChangeButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveChangeButton.ForeColor = Color.White;
            RemoveChangeButton.Location = new Point(242, 450);
            RemoveChangeButton.Name = "RemoveChangeButton";
            RemoveChangeButton.Size = new Size(75, 34);
            RemoveChangeButton.TabIndex = 110;
            RemoveChangeButton.Text = "ลบ";
            RemoveChangeButton.TextColor = Color.White;
            RemoveChangeButton.UseVisualStyleBackColor = false;
            RemoveChangeButton.Click += RemoveChangeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 38, 38);
            panel1.Controls.Add(ResetCountingButton);
            panel1.Controls.Add(PullLatestDataFromDatabaseButton);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(SaveToFileButton);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1546, 68);
            panel1.TabIndex = 112;
            // 
            // ResetCountingButton
            // 
            ResetCountingButton.BackColor = Color.FromArgb(38, 38, 38);
            ResetCountingButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            ResetCountingButton.BorderColor = Color.Gainsboro;
            ResetCountingButton.BorderRadius = 5;
            ResetCountingButton.BorderSize = 1;
            ResetCountingButton.FlatAppearance.BorderSize = 0;
            ResetCountingButton.FlatStyle = FlatStyle.Flat;
            ResetCountingButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetCountingButton.ForeColor = Color.Gainsboro;
            ResetCountingButton.Location = new Point(243, 15);
            ResetCountingButton.Name = "ResetCountingButton";
            ResetCountingButton.Size = new Size(180, 42);
            ResetCountingButton.TabIndex = 131;
            ResetCountingButton.Text = "เริ่มการนับใหม่";
            ResetCountingButton.TextColor = Color.Gainsboro;
            ResetCountingButton.UseVisualStyleBackColor = false;
            ResetCountingButton.Click += ResetCountingButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ChangeAmountTextBox);
            panel2.Controls.Add(ChangesTotalLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ChangesListView);
            panel2.Controls.Add(AddChangeButton);
            panel2.Controls.Add(RemoveChangeButton);
            panel2.Location = new Point(15, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 511);
            panel2.TabIndex = 113;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(38, 38, 38);
            label4.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(39, 53);
            label4.Name = "label4";
            label4.Size = new Size(82, 39);
            label4.TabIndex = 131;
            label4.Text = "ยอดรวม";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChangeAmountTextBox
            // 
            ChangeAmountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            ChangeAmountTextBox.BorderColor = Color.DimGray;
            ChangeAmountTextBox.BorderSize = 1;
            ChangeAmountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeAmountTextBox.ForeColor = Color.Gainsboro;
            ChangeAmountTextBox.Location = new Point(39, 111);
            ChangeAmountTextBox.Multiline = false;
            ChangeAmountTextBox.Name = "ChangeAmountTextBox";
            ChangeAmountTextBox.Padding = new Padding(7);
            ChangeAmountTextBox.PasswordChar = false;
            ChangeAmountTextBox.PlaceholderColor = Color.DarkGray;
            ChangeAmountTextBox.PlaceholderText = "";
            ChangeAmountTextBox.ReadOnly = false;
            ChangeAmountTextBox.Size = new Size(195, 37);
            ChangeAmountTextBox.TabIndex = 127;
            ChangeAmountTextBox.TextAlign = HorizontalAlignment.Center;
            ChangeAmountTextBox.Texts = "";
            ChangeAmountTextBox.UnderlinedStyle = true;
            // 
            // ChangesTotalLabel
            // 
            ChangesTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            ChangesTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            ChangesTotalLabel.ForeColor = Color.PeachPuff;
            ChangesTotalLabel.Location = new Point(127, 43);
            ChangesTotalLabel.Name = "ChangesTotalLabel";
            ChangesTotalLabel.Size = new Size(205, 53);
            ChangesTotalLabel.TabIndex = 88;
            ChangesTotalLabel.Text = "0.00";
            ChangesTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(38, 38, 38);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 39);
            label1.TabIndex = 84;
            label1.Text = " รายการ [ เงินทอน ]";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(38, 38, 38);
            label2.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(15, 87);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 42);
            label2.TabIndex = 10;
            label2.Text = "เงินสด [ คำนวณ ]";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(38, 38, 38);
            panel14.Controls.Add(MoneyTransferPaymentTotalLabel);
            panel14.Controls.Add(label19);
            panel14.Location = new Point(15, 252);
            panel14.Name = "panel14";
            panel14.Size = new Size(361, 111);
            panel14.TabIndex = 125;
            // 
            // MoneyTransferPaymentTotalLabel
            // 
            MoneyTransferPaymentTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            MoneyTransferPaymentTotalLabel.Dock = DockStyle.Fill;
            MoneyTransferPaymentTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            MoneyTransferPaymentTotalLabel.ForeColor = Color.Khaki;
            MoneyTransferPaymentTotalLabel.Location = new Point(0, 39);
            MoneyTransferPaymentTotalLabel.Name = "MoneyTransferPaymentTotalLabel";
            MoneyTransferPaymentTotalLabel.Size = new Size(361, 72);
            MoneyTransferPaymentTotalLabel.TabIndex = 87;
            MoneyTransferPaymentTotalLabel.Text = "0.00";
            MoneyTransferPaymentTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = Color.FromArgb(38, 38, 38);
            label19.Dock = DockStyle.Top;
            label19.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label19.ForeColor = Color.Gainsboro;
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(361, 39);
            label19.TabIndex = 83;
            label19.Text = " ยอดเงินโอน";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 38, 38);
            panel4.Controls.Add(SalesTotalLabel);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(15, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 111);
            panel4.TabIndex = 124;
            // 
            // SalesTotalLabel
            // 
            SalesTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            SalesTotalLabel.Dock = DockStyle.Fill;
            SalesTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            SalesTotalLabel.ForeColor = Color.PaleGreen;
            SalesTotalLabel.Location = new Point(0, 39);
            SalesTotalLabel.Name = "SalesTotalLabel";
            SalesTotalLabel.Size = new Size(361, 72);
            SalesTotalLabel.TabIndex = 87;
            SalesTotalLabel.Text = "0.00";
            SalesTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = Color.FromArgb(38, 38, 38);
            label20.Dock = DockStyle.Top;
            label20.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label20.ForeColor = Color.Gainsboro;
            label20.Location = new Point(0, 0);
            label20.Name = "label20";
            label20.Size = new Size(361, 39);
            label20.TabIndex = 83;
            label20.Text = " ยอดขาย";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(38, 38, 38);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(RemovePayOutButton);
            panel5.Controls.Add(AddPayOutButton);
            panel5.Controls.Add(PayoutsTotalLabel);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(PayoutsListView);
            panel5.Controls.Add(PayOutAmountTextBox);
            panel5.Controls.Add(PayOutItemTextBox);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(382, 135);
            panel5.Name = "panel5";
            panel5.Size = new Size(433, 745);
            panel5.TabIndex = 127;
            // 
            // label22
            // 
            label22.BackColor = Color.FromArgb(38, 38, 38);
            label22.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label22.ForeColor = Color.Gainsboro;
            label22.Location = new Point(47, 52);
            label22.Name = "label22";
            label22.Size = new Size(82, 39);
            label22.TabIndex = 135;
            label22.Text = "ยอดรวม";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RemovePayOutButton
            // 
            RemovePayOutButton.BackColor = Color.FromArgb(38, 38, 38);
            RemovePayOutButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            RemovePayOutButton.BorderColor = Color.Salmon;
            RemovePayOutButton.BorderRadius = 5;
            RemovePayOutButton.BorderSize = 1;
            RemovePayOutButton.FlatAppearance.BorderSize = 0;
            RemovePayOutButton.FlatStyle = FlatStyle.Flat;
            RemovePayOutButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemovePayOutButton.ForeColor = Color.White;
            RemovePayOutButton.Location = new Point(306, 686);
            RemovePayOutButton.Name = "RemovePayOutButton";
            RemovePayOutButton.Size = new Size(75, 34);
            RemovePayOutButton.TabIndex = 134;
            RemovePayOutButton.Text = "ลบ";
            RemovePayOutButton.TextColor = Color.White;
            RemovePayOutButton.UseVisualStyleBackColor = false;
            RemovePayOutButton.Click += RemovePayOutItemButton_Click;
            // 
            // AddPayOutButton
            // 
            AddPayOutButton.BackColor = Color.FromArgb(38, 38, 38);
            AddPayOutButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            AddPayOutButton.BorderColor = Color.MediumSpringGreen;
            AddPayOutButton.BorderRadius = 5;
            AddPayOutButton.BorderSize = 1;
            AddPayOutButton.FlatAppearance.BorderSize = 0;
            AddPayOutButton.FlatStyle = FlatStyle.Flat;
            AddPayOutButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddPayOutButton.ForeColor = Color.White;
            AddPayOutButton.Location = new Point(304, 154);
            AddPayOutButton.Name = "AddPayOutButton";
            AddPayOutButton.Size = new Size(77, 34);
            AddPayOutButton.TabIndex = 133;
            AddPayOutButton.Text = "เพิ่ม";
            AddPayOutButton.TextColor = Color.White;
            AddPayOutButton.UseVisualStyleBackColor = false;
            AddPayOutButton.Click += AddPayOutItemButton_Click;
            // 
            // PayoutsTotalLabel
            // 
            PayoutsTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            PayoutsTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            PayoutsTotalLabel.ForeColor = Color.LightSalmon;
            PayoutsTotalLabel.Location = new Point(129, 43);
            PayoutsTotalLabel.Name = "PayoutsTotalLabel";
            PayoutsTotalLabel.Size = new Size(252, 53);
            PayoutsTotalLabel.TabIndex = 132;
            PayoutsTotalLabel.Text = "0.00";
            PayoutsTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = Color.FromArgb(38, 38, 38);
            label21.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label21.ForeColor = Color.Gainsboro;
            label21.Location = new Point(47, 152);
            label21.Name = "label21";
            label21.Size = new Size(76, 39);
            label21.TabIndex = 131;
            label21.Text = "จำนวน";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(38, 38, 38);
            label14.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label14.ForeColor = Color.Gainsboro;
            label14.Location = new Point(47, 104);
            label14.Name = "label14";
            label14.Size = new Size(76, 39);
            label14.TabIndex = 130;
            label14.Text = "รายการ";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PayOutAmountTextBox
            // 
            PayOutAmountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            PayOutAmountTextBox.BorderColor = Color.DimGray;
            PayOutAmountTextBox.BorderSize = 1;
            PayOutAmountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PayOutAmountTextBox.ForeColor = Color.Gainsboro;
            PayOutAmountTextBox.Location = new Point(129, 147);
            PayOutAmountTextBox.Multiline = false;
            PayOutAmountTextBox.Name = "PayOutAmountTextBox";
            PayOutAmountTextBox.Padding = new Padding(7);
            PayOutAmountTextBox.PasswordChar = false;
            PayOutAmountTextBox.PlaceholderColor = Color.DarkGray;
            PayOutAmountTextBox.PlaceholderText = "";
            PayOutAmountTextBox.ReadOnly = false;
            PayOutAmountTextBox.Size = new Size(169, 37);
            PayOutAmountTextBox.TabIndex = 129;
            PayOutAmountTextBox.TextAlign = HorizontalAlignment.Center;
            PayOutAmountTextBox.Texts = "";
            PayOutAmountTextBox.UnderlinedStyle = true;
            // 
            // PayOutItemTextBox
            // 
            PayOutItemTextBox.BackColor = Color.FromArgb(38, 38, 38);
            PayOutItemTextBox.BorderColor = Color.DimGray;
            PayOutItemTextBox.BorderSize = 1;
            PayOutItemTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PayOutItemTextBox.ForeColor = Color.Gainsboro;
            PayOutItemTextBox.Location = new Point(129, 104);
            PayOutItemTextBox.Multiline = false;
            PayOutItemTextBox.Name = "PayOutItemTextBox";
            PayOutItemTextBox.Padding = new Padding(7);
            PayOutItemTextBox.PasswordChar = false;
            PayOutItemTextBox.PlaceholderColor = Color.DarkGray;
            PayOutItemTextBox.PlaceholderText = "";
            PayOutItemTextBox.ReadOnly = false;
            PayOutItemTextBox.Size = new Size(169, 37);
            PayOutItemTextBox.TabIndex = 128;
            PayOutItemTextBox.TextAlign = HorizontalAlignment.Center;
            PayOutItemTextBox.Texts = "";
            PayOutItemTextBox.UnderlinedStyle = true;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(38, 38, 38);
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(433, 39);
            label7.TabIndex = 85;
            label7.Text = " รายการ [ รายจ่าย ]";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(38, 38, 38);
            label18.Font = new Font("FC Subject [Non-commercial] Reg", 11.2499981F);
            label18.ForeColor = Color.Gainsboro;
            label18.Location = new Point(821, 87);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(373, 42);
            label18.TabIndex = 128;
            label18.Text = "เงินสด [ นับ ]";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(38, 38, 38);
            panel6.Controls.Add(BankNote20CountTextBox);
            panel6.Controls.Add(BankNote50CountTextBox);
            panel6.Controls.Add(BankNote100CountTextBox);
            panel6.Controls.Add(BankNote500CountTextBox);
            panel6.Controls.Add(BankNote1000CountTextBox);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(BankNote1000CountTotalLabel);
            panel6.Controls.Add(BankNote500CountTotalLabel);
            panel6.Controls.Add(BankNote100CountTotalLabel);
            panel6.Controls.Add(BankNote50CountTotalLabel);
            panel6.Controls.Add(BankNote20CountTotalLabel);
            panel6.Location = new Point(821, 135);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 328);
            panel6.TabIndex = 129;
            // 
            // BankNote20CountTextBox
            // 
            BankNote20CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            BankNote20CountTextBox.BorderColor = Color.DimGray;
            BankNote20CountTextBox.BorderSize = 1;
            BankNote20CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote20CountTextBox.ForeColor = Color.Gainsboro;
            BankNote20CountTextBox.Location = new Point(114, 262);
            BankNote20CountTextBox.Multiline = false;
            BankNote20CountTextBox.Name = "BankNote20CountTextBox";
            BankNote20CountTextBox.Padding = new Padding(7);
            BankNote20CountTextBox.PasswordChar = false;
            BankNote20CountTextBox.PlaceholderColor = Color.DarkGray;
            BankNote20CountTextBox.PlaceholderText = "";
            BankNote20CountTextBox.ReadOnly = false;
            BankNote20CountTextBox.Size = new Size(140, 34);
            BankNote20CountTextBox.TabIndex = 133;
            BankNote20CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote20CountTextBox.Texts = "";
            BankNote20CountTextBox.UnderlinedStyle = true;
            BankNote20CountTextBox.ModernTextChanged += BankNote20CountTextBox_TextChanged;
            BankNote20CountTextBox.Leave += BankNote20CountTextBox_Leave;
            // 
            // BankNote50CountTextBox
            // 
            BankNote50CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            BankNote50CountTextBox.BorderColor = Color.DimGray;
            BankNote50CountTextBox.BorderSize = 1;
            BankNote50CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote50CountTextBox.ForeColor = Color.Gainsboro;
            BankNote50CountTextBox.Location = new Point(114, 219);
            BankNote50CountTextBox.Multiline = false;
            BankNote50CountTextBox.Name = "BankNote50CountTextBox";
            BankNote50CountTextBox.Padding = new Padding(7);
            BankNote50CountTextBox.PasswordChar = false;
            BankNote50CountTextBox.PlaceholderColor = Color.DarkGray;
            BankNote50CountTextBox.PlaceholderText = "";
            BankNote50CountTextBox.ReadOnly = false;
            BankNote50CountTextBox.Size = new Size(140, 34);
            BankNote50CountTextBox.TabIndex = 132;
            BankNote50CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote50CountTextBox.Texts = "";
            BankNote50CountTextBox.UnderlinedStyle = true;
            BankNote50CountTextBox.ModernTextChanged += BankNote50CountTextBox_TextChanged;
            BankNote50CountTextBox.Leave += BankNote50CountTextBox_Leave;
            // 
            // BankNote100CountTextBox
            // 
            BankNote100CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            BankNote100CountTextBox.BorderColor = Color.DimGray;
            BankNote100CountTextBox.BorderSize = 1;
            BankNote100CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote100CountTextBox.ForeColor = Color.Gainsboro;
            BankNote100CountTextBox.Location = new Point(114, 176);
            BankNote100CountTextBox.Multiline = false;
            BankNote100CountTextBox.Name = "BankNote100CountTextBox";
            BankNote100CountTextBox.Padding = new Padding(7);
            BankNote100CountTextBox.PasswordChar = false;
            BankNote100CountTextBox.PlaceholderColor = Color.DarkGray;
            BankNote100CountTextBox.PlaceholderText = "";
            BankNote100CountTextBox.ReadOnly = false;
            BankNote100CountTextBox.Size = new Size(140, 34);
            BankNote100CountTextBox.TabIndex = 131;
            BankNote100CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote100CountTextBox.Texts = "";
            BankNote100CountTextBox.UnderlinedStyle = true;
            BankNote100CountTextBox.ModernTextChanged += BankNote100CountTextBox_TextChanged;
            BankNote100CountTextBox.Leave += BankNote100CountTextBox_Leave;
            // 
            // BankNote500CountTextBox
            // 
            BankNote500CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            BankNote500CountTextBox.BorderColor = Color.DimGray;
            BankNote500CountTextBox.BorderSize = 1;
            BankNote500CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote500CountTextBox.ForeColor = Color.Gainsboro;
            BankNote500CountTextBox.Location = new Point(114, 133);
            BankNote500CountTextBox.Multiline = false;
            BankNote500CountTextBox.Name = "BankNote500CountTextBox";
            BankNote500CountTextBox.Padding = new Padding(7);
            BankNote500CountTextBox.PasswordChar = false;
            BankNote500CountTextBox.PlaceholderColor = Color.DarkGray;
            BankNote500CountTextBox.PlaceholderText = "";
            BankNote500CountTextBox.ReadOnly = false;
            BankNote500CountTextBox.Size = new Size(140, 34);
            BankNote500CountTextBox.TabIndex = 130;
            BankNote500CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote500CountTextBox.Texts = "";
            BankNote500CountTextBox.UnderlinedStyle = true;
            BankNote500CountTextBox.ModernTextChanged += BankNote500CountTextBox_TextChanged;
            BankNote500CountTextBox.Leave += BankNote500CountTextBox_Leave;
            // 
            // BankNote1000CountTextBox
            // 
            BankNote1000CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            BankNote1000CountTextBox.BorderColor = Color.DimGray;
            BankNote1000CountTextBox.BorderSize = 1;
            BankNote1000CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            BankNote1000CountTextBox.ForeColor = Color.Gainsboro;
            BankNote1000CountTextBox.Location = new Point(114, 90);
            BankNote1000CountTextBox.Multiline = false;
            BankNote1000CountTextBox.Name = "BankNote1000CountTextBox";
            BankNote1000CountTextBox.Padding = new Padding(7);
            BankNote1000CountTextBox.PasswordChar = false;
            BankNote1000CountTextBox.PlaceholderColor = Color.DarkGray;
            BankNote1000CountTextBox.PlaceholderText = "";
            BankNote1000CountTextBox.ReadOnly = false;
            BankNote1000CountTextBox.Size = new Size(140, 34);
            BankNote1000CountTextBox.TabIndex = 129;
            BankNote1000CountTextBox.TextAlign = HorizontalAlignment.Center;
            BankNote1000CountTextBox.Texts = "";
            BankNote1000CountTextBox.UnderlinedStyle = true;
            BankNote1000CountTextBox.ModernTextChanged += BankNote1000CountTextBox_TextChanged;
            BankNote1000CountTextBox.Leave += BankNote1000CountTextBox_Leave;
            // 
            // label23
            // 
            label23.BackColor = Color.FromArgb(38, 38, 38);
            label23.Dock = DockStyle.Top;
            label23.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label23.ForeColor = Color.Gainsboro;
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(373, 39);
            label23.TabIndex = 86;
            label23.Text = " รายการ [ ธนบัตร ]";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(38, 38, 38);
            panel7.Controls.Add(Coin1CountTextBox);
            panel7.Controls.Add(Coin2CountTextBox);
            panel7.Controls.Add(Coin5CountTextBox);
            panel7.Controls.Add(Coin10CountTextBox);
            panel7.Controls.Add(label24);
            panel7.Controls.Add(Coin1CountTotalLabel);
            panel7.Controls.Add(label29);
            panel7.Controls.Add(Coin2CountTotalLabel);
            panel7.Controls.Add(label35);
            panel7.Controls.Add(Coin5CountTotalLabel);
            panel7.Controls.Add(label34);
            panel7.Controls.Add(Coin10CountTotalLabel);
            panel7.Controls.Add(label33);
            panel7.Controls.Add(label27);
            panel7.Controls.Add(label30);
            panel7.Controls.Add(label28);
            panel7.Location = new Point(821, 469);
            panel7.Name = "panel7";
            panel7.Size = new Size(373, 286);
            panel7.TabIndex = 130;
            // 
            // Coin1CountTextBox
            // 
            Coin1CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            Coin1CountTextBox.BorderColor = Color.DimGray;
            Coin1CountTextBox.BorderSize = 1;
            Coin1CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin1CountTextBox.ForeColor = Color.Gainsboro;
            Coin1CountTextBox.Location = new Point(114, 217);
            Coin1CountTextBox.Multiline = false;
            Coin1CountTextBox.Name = "Coin1CountTextBox";
            Coin1CountTextBox.Padding = new Padding(7);
            Coin1CountTextBox.PasswordChar = false;
            Coin1CountTextBox.PlaceholderColor = Color.DarkGray;
            Coin1CountTextBox.PlaceholderText = "";
            Coin1CountTextBox.ReadOnly = false;
            Coin1CountTextBox.Size = new Size(140, 34);
            Coin1CountTextBox.TabIndex = 137;
            Coin1CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin1CountTextBox.Texts = "";
            Coin1CountTextBox.UnderlinedStyle = true;
            Coin1CountTextBox.ModernTextChanged += Coin1CountTextBox_TextChanged;
            Coin1CountTextBox.Leave += Coin1CountTextBox_Leave;
            // 
            // Coin2CountTextBox
            // 
            Coin2CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            Coin2CountTextBox.BorderColor = Color.DimGray;
            Coin2CountTextBox.BorderSize = 1;
            Coin2CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin2CountTextBox.ForeColor = Color.Gainsboro;
            Coin2CountTextBox.Location = new Point(114, 177);
            Coin2CountTextBox.Multiline = false;
            Coin2CountTextBox.Name = "Coin2CountTextBox";
            Coin2CountTextBox.Padding = new Padding(7);
            Coin2CountTextBox.PasswordChar = false;
            Coin2CountTextBox.PlaceholderColor = Color.DarkGray;
            Coin2CountTextBox.PlaceholderText = "";
            Coin2CountTextBox.ReadOnly = false;
            Coin2CountTextBox.Size = new Size(140, 34);
            Coin2CountTextBox.TabIndex = 136;
            Coin2CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin2CountTextBox.Texts = "";
            Coin2CountTextBox.UnderlinedStyle = true;
            Coin2CountTextBox.ModernTextChanged += Coin2CountTextBox_TextChanged;
            Coin2CountTextBox.Leave += Coin2CountTextBox_Leave;
            // 
            // Coin5CountTextBox
            // 
            Coin5CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            Coin5CountTextBox.BorderColor = Color.DimGray;
            Coin5CountTextBox.BorderSize = 1;
            Coin5CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin5CountTextBox.ForeColor = Color.Gainsboro;
            Coin5CountTextBox.Location = new Point(114, 137);
            Coin5CountTextBox.Multiline = false;
            Coin5CountTextBox.Name = "Coin5CountTextBox";
            Coin5CountTextBox.Padding = new Padding(7);
            Coin5CountTextBox.PasswordChar = false;
            Coin5CountTextBox.PlaceholderColor = Color.DarkGray;
            Coin5CountTextBox.PlaceholderText = "";
            Coin5CountTextBox.ReadOnly = false;
            Coin5CountTextBox.Size = new Size(140, 34);
            Coin5CountTextBox.TabIndex = 135;
            Coin5CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin5CountTextBox.Texts = "";
            Coin5CountTextBox.UnderlinedStyle = true;
            Coin5CountTextBox.ModernTextChanged += Coin5CountTextBox_TextChanged;
            Coin5CountTextBox.Leave += Coin5CountTextBox_Leave;
            // 
            // Coin10CountTextBox
            // 
            Coin10CountTextBox.BackColor = Color.FromArgb(38, 38, 38);
            Coin10CountTextBox.BorderColor = Color.DimGray;
            Coin10CountTextBox.BorderSize = 1;
            Coin10CountTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 9.749999F);
            Coin10CountTextBox.ForeColor = Color.Gainsboro;
            Coin10CountTextBox.Location = new Point(114, 97);
            Coin10CountTextBox.Multiline = false;
            Coin10CountTextBox.Name = "Coin10CountTextBox";
            Coin10CountTextBox.Padding = new Padding(7);
            Coin10CountTextBox.PasswordChar = false;
            Coin10CountTextBox.PlaceholderColor = Color.DarkGray;
            Coin10CountTextBox.PlaceholderText = "";
            Coin10CountTextBox.ReadOnly = false;
            Coin10CountTextBox.Size = new Size(140, 34);
            Coin10CountTextBox.TabIndex = 134;
            Coin10CountTextBox.TextAlign = HorizontalAlignment.Center;
            Coin10CountTextBox.Texts = "";
            Coin10CountTextBox.UnderlinedStyle = true;
            Coin10CountTextBox.ModernTextChanged += Coin10CountTextBox_TextChanged;
            Coin10CountTextBox.Leave += Coin10CountTextBox_Leave;
            // 
            // label24
            // 
            label24.BackColor = Color.FromArgb(38, 38, 38);
            label24.Dock = DockStyle.Top;
            label24.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label24.ForeColor = Color.Gainsboro;
            label24.Location = new Point(0, 0);
            label24.Name = "label24";
            label24.Size = new Size(373, 39);
            label24.TabIndex = 86;
            label24.Text = " รายการ [ เหรียญ ]";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(38, 38, 38);
            panel9.Controls.Add(ActualCashTotalLabel);
            panel9.Controls.Add(label26);
            panel9.Location = new Point(1200, 87);
            panel9.Name = "panel9";
            panel9.Size = new Size(361, 111);
            panel9.TabIndex = 133;
            // 
            // ActualCashTotalLabel
            // 
            ActualCashTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            ActualCashTotalLabel.Dock = DockStyle.Fill;
            ActualCashTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            ActualCashTotalLabel.ForeColor = Color.Turquoise;
            ActualCashTotalLabel.Location = new Point(0, 39);
            ActualCashTotalLabel.Name = "ActualCashTotalLabel";
            ActualCashTotalLabel.Size = new Size(361, 72);
            ActualCashTotalLabel.TabIndex = 87;
            ActualCashTotalLabel.Text = "0.00";
            ActualCashTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            label26.BackColor = Color.FromArgb(38, 38, 38);
            label26.Dock = DockStyle.Top;
            label26.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label26.ForeColor = Color.Gainsboro;
            label26.Location = new Point(0, 0);
            label26.Name = "label26";
            label26.Size = new Size(361, 39);
            label26.TabIndex = 83;
            label26.Text = " ยอดรวมเงินสด [ นับ ]";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(38, 38, 38);
            panel10.Controls.Add(CalculatedCashTotalLabel);
            panel10.Controls.Add(label32);
            panel10.Location = new Point(1200, 204);
            panel10.Name = "panel10";
            panel10.Size = new Size(361, 111);
            panel10.TabIndex = 134;
            // 
            // CalculatedCashTotalLabel
            // 
            CalculatedCashTotalLabel.BackColor = Color.FromArgb(38, 38, 38);
            CalculatedCashTotalLabel.Dock = DockStyle.Fill;
            CalculatedCashTotalLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            CalculatedCashTotalLabel.ForeColor = Color.SkyBlue;
            CalculatedCashTotalLabel.Location = new Point(0, 39);
            CalculatedCashTotalLabel.Name = "CalculatedCashTotalLabel";
            CalculatedCashTotalLabel.Size = new Size(361, 72);
            CalculatedCashTotalLabel.TabIndex = 87;
            CalculatedCashTotalLabel.Text = "0.00";
            CalculatedCashTotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.BackColor = Color.FromArgb(38, 38, 38);
            label32.Dock = DockStyle.Top;
            label32.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label32.ForeColor = Color.Gainsboro;
            label32.Location = new Point(0, 0);
            label32.Name = "label32";
            label32.Size = new Size(361, 39);
            label32.TabIndex = 83;
            label32.Text = " ยอดรวมเงินสด [ คำนวณ ]";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(38, 38, 38);
            panel11.Controls.Add(DiffCashLabel);
            panel11.Controls.Add(DiffCashDescriptionLabel);
            panel11.Controls.Add(label37);
            panel11.Location = new Point(1200, 321);
            panel11.Name = "panel11";
            panel11.Size = new Size(361, 142);
            panel11.TabIndex = 135;
            // 
            // DiffCashLabel
            // 
            DiffCashLabel.BackColor = Color.FromArgb(38, 38, 38);
            DiffCashLabel.Dock = DockStyle.Fill;
            DiffCashLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F);
            DiffCashLabel.ForeColor = Color.Lavender;
            DiffCashLabel.Location = new Point(0, 39);
            DiffCashLabel.Name = "DiffCashLabel";
            DiffCashLabel.Size = new Size(361, 62);
            DiffCashLabel.TabIndex = 87;
            DiffCashLabel.Text = "0.00";
            DiffCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DiffCashDescriptionLabel
            // 
            DiffCashDescriptionLabel.Dock = DockStyle.Bottom;
            DiffCashDescriptionLabel.Font = new Font("FC Subject [Non-commercial] Reg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiffCashDescriptionLabel.ForeColor = Color.Gainsboro;
            DiffCashDescriptionLabel.Location = new Point(0, 101);
            DiffCashDescriptionLabel.Margin = new Padding(6, 0, 6, 0);
            DiffCashDescriptionLabel.Name = "DiffCashDescriptionLabel";
            DiffCashDescriptionLabel.Size = new Size(361, 41);
            DiffCashDescriptionLabel.TabIndex = 88;
            DiffCashDescriptionLabel.Text = "?";
            DiffCashDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            label37.BackColor = Color.FromArgb(38, 38, 38);
            label37.Dock = DockStyle.Top;
            label37.Font = new Font("FC Subject [Non-commercial] Reg", 12F);
            label37.ForeColor = Color.Gainsboro;
            label37.Location = new Point(0, 0);
            label37.Name = "label37";
            label37.Size = new Size(361, 39);
            label37.TabIndex = 83;
            label37.Text = " ผลต่าง";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CashFlowCalculatorPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label18);
            Controls.Add(panel5);
            Controls.Add(panel14);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("FC Subject [Non-commercial] Reg", 14.25F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CashFlowCalculatorPanel";
            Size = new Size(1610, 925);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label8;
        private ListView ChangesListView;
        private ListView PayoutsListView;
        private Label label3;
        private Label label10;
        private Label BankNote20CountTotalLabel;
        private Label BankNote50CountTotalLabel;
        private Label BankNote100CountTotalLabel;
        private Label BankNote500CountTotalLabel;
        private Label BankNote1000CountTotalLabel;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label Coin1CountTotalLabel;
        private Label Coin2CountTotalLabel;
        private Label Coin5CountTotalLabel;
        private Label Coin10CountTotalLabel;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label PayoutsTotalLabel;
        private Label DateLabel;
        private ModernUI.ModernButton PullLatestDataFromDatabaseButton;
        private ModernUI.ModernButton SaveToFileButton;
        private ModernUI.ModernButton AddChangeButton;
        private ModernUI.ModernButton RemoveChangeButton;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel14;
        private Label MoneyTransferPaymentTotalLabel;
        private Label label19;
        private Panel panel4;
        private Label SalesTotalLabel;
        private Label label20;
        private Label ChangesTotalLabel;
        private ModernUI.ModernTextBox ChangeAmountTextBox;
        private Panel panel5;
        private Label label21;
        private Label label14;
        private ModernUI.ModernTextBox PayOutAmountTextBox;
        private ModernUI.ModernTextBox PayOutItemTextBox;
        private Label label7;
        private ModernUI.ModernButton AddPayOutButton;
        private ModernUI.ModernButton RemovePayOutButton;
        private Label label4;
        private Label label18;
        private Label label22;
        private Panel panel6;
        private Label label23;
        private Panel panel7;
        private Label label24;
        private ModernUI.ModernTextBox BankNote20CountTextBox;
        private ModernUI.ModernTextBox BankNote50CountTextBox;
        private ModernUI.ModernTextBox BankNote100CountTextBox;
        private ModernUI.ModernTextBox BankNote500CountTextBox;
        private ModernUI.ModernTextBox BankNote1000CountTextBox;
        private ModernUI.ModernTextBox Coin1CountTextBox;
        private ModernUI.ModernTextBox Coin2CountTextBox;
        private ModernUI.ModernTextBox Coin5CountTextBox;
        private ModernUI.ModernTextBox Coin10CountTextBox;
        private ModernUI.ModernButton ResetCountingButton;
        private Panel panel9;
        private Label ActualCashTotalLabel;
        private Label label26;
        private Panel panel10;
        private Label CalculatedCashTotalLabel;
        private Label label32;
        private Panel panel11;
        private Label DiffCashLabel;
        private Label label37;
        private Label DiffCashDescriptionLabel;
    }
}
