namespace MimyMart.Windows.Forms.UI
{
    partial class MainForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavigationPanel = new Panel();
            panel2 = new Panel();
            DataFeedStatusLabel = new Label();
            panel1 = new Panel();
            VersionLabel = new Label();
            LoggedInUserLabel = new Label();
            DateTimeLabel = new Label();
            TitlePanel = new Panel();
            pictureBox2 = new PictureBox();
            panel9 = new Panel();
            ResizeWindowsButton = new ModernUI.ModernButton();
            CloseWindowsButton = new ModernUI.ModernButton();
            MinimizeWindowsButton = new ModernUI.ModernButton();
            StoreNameLabel = new Label();
            ActivePanel = new Panel();
            ControlPanel = new Panel();
            CloseApplicationButton = new Button();
            LogInButton = new Button();
            SettingsButton = new Button();
            ReportsButton = new Button();
            UsersButton = new Button();
            InventoryButton = new Button();
            SaleButton = new Button();
            NavigationPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel9.SuspendLayout();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.FromArgb(25, 25, 25);
            NavigationPanel.Controls.Add(panel2);
            NavigationPanel.Controls.Add(panel1);
            NavigationPanel.Dock = DockStyle.Bottom;
            NavigationPanel.Location = new Point(0, 1024);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(1800, 41);
            NavigationPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(DataFeedStatusLabel);
            panel2.Location = new Point(549, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 41);
            panel2.TabIndex = 8;
            // 
            // DataFeedStatusLabel
            // 
            DataFeedStatusLabel.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataFeedStatusLabel.ForeColor = Color.WhiteSmoke;
            DataFeedStatusLabel.Location = new Point(3, 3);
            DataFeedStatusLabel.Name = "DataFeedStatusLabel";
            DataFeedStatusLabel.Size = new Size(404, 35);
            DataFeedStatusLabel.TabIndex = 6;
            DataFeedStatusLabel.Text = "DataFeed Push :";
            DataFeedStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(VersionLabel);
            panel1.Controls.Add(LoggedInUserLabel);
            panel1.Controls.Add(DateTimeLabel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(972, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 41);
            panel1.TabIndex = 7;
            // 
            // VersionLabel
            // 
            VersionLabel.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersionLabel.ForeColor = Color.WhiteSmoke;
            VersionLabel.Location = new Point(589, 0);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(236, 35);
            VersionLabel.TabIndex = 7;
            VersionLabel.Text = "Version:";
            VersionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoggedInUserLabel
            // 
            LoggedInUserLabel.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoggedInUserLabel.ForeColor = Color.WhiteSmoke;
            LoggedInUserLabel.Location = new Point(3, 0);
            LoggedInUserLabel.Name = "LoggedInUserLabel";
            LoggedInUserLabel.Size = new Size(265, 35);
            LoggedInUserLabel.TabIndex = 5;
            LoggedInUserLabel.Text = "User:";
            LoggedInUserLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimeLabel.ForeColor = Color.WhiteSmoke;
            DateTimeLabel.Location = new Point(285, 0);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(298, 35);
            DateTimeLabel.TabIndex = 6;
            DateTimeLabel.Text = "Date:";
            DateTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.FromArgb(25, 25, 25);
            TitlePanel.Controls.Add(pictureBox2);
            TitlePanel.Controls.Add(panel9);
            TitlePanel.Controls.Add(StoreNameLabel);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitlePanel.ForeColor = Color.LightGreen;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1800, 52);
            TitlePanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(ResizeWindowsButton);
            panel9.Controls.Add(CloseWindowsButton);
            panel9.Controls.Add(MinimizeWindowsButton);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(1621, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(179, 52);
            panel9.TabIndex = 4;
            // 
            // ResizeWindowsButton
            // 
            ResizeWindowsButton.BackColor = Color.FromArgb(25, 25, 25);
            ResizeWindowsButton.BackgroundColor = Color.FromArgb(25, 25, 25);
            ResizeWindowsButton.BorderColor = Color.FromArgb(38, 38, 38);
            ResizeWindowsButton.BorderRadius = 19;
            ResizeWindowsButton.BorderSize = 1;
            ResizeWindowsButton.FlatAppearance.BorderSize = 0;
            ResizeWindowsButton.FlatStyle = FlatStyle.Flat;
            ResizeWindowsButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResizeWindowsButton.ForeColor = Color.White;
            ResizeWindowsButton.Image = Properties.Resources.maximize_window_24px;
            ResizeWindowsButton.Location = new Point(72, 9);
            ResizeWindowsButton.Name = "ResizeWindowsButton";
            ResizeWindowsButton.Size = new Size(35, 35);
            ResizeWindowsButton.TabIndex = 86;
            ResizeWindowsButton.TextColor = Color.White;
            ResizeWindowsButton.UseVisualStyleBackColor = false;
            ResizeWindowsButton.Click += ResizeWindows_Click;
            // 
            // CloseWindowsButton
            // 
            CloseWindowsButton.BackColor = Color.FromArgb(25, 25, 25);
            CloseWindowsButton.BackgroundColor = Color.FromArgb(25, 25, 25);
            CloseWindowsButton.BorderColor = Color.FromArgb(38, 38, 38);
            CloseWindowsButton.BorderRadius = 19;
            CloseWindowsButton.BorderSize = 1;
            CloseWindowsButton.FlatAppearance.BorderSize = 0;
            CloseWindowsButton.FlatStyle = FlatStyle.Flat;
            CloseWindowsButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseWindowsButton.ForeColor = Color.White;
            CloseWindowsButton.Image = Properties.Resources.close_window_24px;
            CloseWindowsButton.Location = new Point(132, 9);
            CloseWindowsButton.Name = "CloseWindowsButton";
            CloseWindowsButton.Size = new Size(35, 35);
            CloseWindowsButton.TabIndex = 87;
            CloseWindowsButton.TextColor = Color.White;
            CloseWindowsButton.UseVisualStyleBackColor = false;
            CloseWindowsButton.Click += CloseWindows_Click;
            // 
            // MinimizeWindowsButton
            // 
            MinimizeWindowsButton.BackColor = Color.FromArgb(25, 25, 25);
            MinimizeWindowsButton.BackgroundColor = Color.FromArgb(25, 25, 25);
            MinimizeWindowsButton.BorderColor = Color.FromArgb(38, 38, 38);
            MinimizeWindowsButton.BorderRadius = 19;
            MinimizeWindowsButton.BorderSize = 1;
            MinimizeWindowsButton.FlatAppearance.BorderSize = 0;
            MinimizeWindowsButton.FlatStyle = FlatStyle.Flat;
            MinimizeWindowsButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimizeWindowsButton.ForeColor = Color.White;
            MinimizeWindowsButton.Image = Properties.Resources.minimize_window_24px;
            MinimizeWindowsButton.Location = new Point(11, 9);
            MinimizeWindowsButton.Name = "MinimizeWindowsButton";
            MinimizeWindowsButton.Size = new Size(35, 35);
            MinimizeWindowsButton.TabIndex = 85;
            MinimizeWindowsButton.TextColor = Color.White;
            MinimizeWindowsButton.UseVisualStyleBackColor = false;
            MinimizeWindowsButton.Click += MinimizeWindows_Click;
            // 
            // StoreNameLabel
            // 
            StoreNameLabel.Font = new Font("FC Subject [Non-commercial] Reg", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StoreNameLabel.ForeColor = Color.WhiteSmoke;
            StoreNameLabel.Location = new Point(80, 9);
            StoreNameLabel.Name = "StoreNameLabel";
            StoreNameLabel.Size = new Size(890, 39);
            StoreNameLabel.TabIndex = 0;
            StoreNameLabel.Text = "Store Name";
            StoreNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActivePanel
            // 
            ActivePanel.BackColor = Color.FromArgb(30, 30, 30);
            ActivePanel.Dock = DockStyle.Fill;
            ActivePanel.Location = new Point(298, 52);
            ActivePanel.Name = "ActivePanel";
            ActivePanel.Size = new Size(1502, 972);
            ActivePanel.TabIndex = 3;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(CloseApplicationButton);
            ControlPanel.Controls.Add(LogInButton);
            ControlPanel.Controls.Add(SettingsButton);
            ControlPanel.Controls.Add(ReportsButton);
            ControlPanel.Controls.Add(UsersButton);
            ControlPanel.Controls.Add(InventoryButton);
            ControlPanel.Controls.Add(SaleButton);
            ControlPanel.Dock = DockStyle.Left;
            ControlPanel.Location = new Point(0, 52);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(298, 972);
            ControlPanel.TabIndex = 4;
            // 
            // CloseApplicationButton
            // 
            CloseApplicationButton.BackColor = Color.FromArgb(38, 38, 38);
            CloseApplicationButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseApplicationButton.FlatStyle = FlatStyle.Flat;
            CloseApplicationButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CloseApplicationButton.ForeColor = Color.DarkGray;
            CloseApplicationButton.Image = Properties.Resources.CloseWindows_50;
            CloseApplicationButton.Location = new Point(3, 729);
            CloseApplicationButton.Name = "CloseApplicationButton";
            CloseApplicationButton.Size = new Size(292, 115);
            CloseApplicationButton.TabIndex = 5;
            CloseApplicationButton.Text = "ออกจากโปรแกรม";
            CloseApplicationButton.TextAlign = ContentAlignment.BottomCenter;
            CloseApplicationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CloseApplicationButton.UseVisualStyleBackColor = false;
            CloseApplicationButton.Click += CloseApplicationButton_Click;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(38, 38, 38);
            LogInButton.BackgroundImageLayout = ImageLayout.Stretch;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.DarkGray;
            LogInButton.Image = Properties.Resources.LogInPanel_50;
            LogInButton.Location = new Point(3, 608);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(292, 115);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In";
            LogInButton.TextAlign = ContentAlignment.BottomCenter;
            LogInButton.TextImageRelation = TextImageRelation.ImageAboveText;
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(38, 38, 38);
            SettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsButton.ForeColor = Color.DarkGray;
            SettingsButton.Image = Properties.Resources.SettingsPanel_50;
            SettingsButton.Location = new Point(3, 487);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(292, 115);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "การตั้งค่า";
            SettingsButton.TextAlign = ContentAlignment.BottomCenter;
            SettingsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.BackColor = Color.FromArgb(38, 38, 38);
            ReportsButton.BackgroundImageLayout = ImageLayout.Stretch;
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReportsButton.ForeColor = Color.DarkGray;
            ReportsButton.Image = Properties.Resources.Reports_50;
            ReportsButton.Location = new Point(3, 366);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(292, 115);
            ReportsButton.TabIndex = 3;
            ReportsButton.Text = "รายงาน";
            ReportsButton.TextAlign = ContentAlignment.BottomCenter;
            ReportsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ReportsButton.UseVisualStyleBackColor = false;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.FromArgb(38, 38, 38);
            UsersButton.BackgroundImageLayout = ImageLayout.Stretch;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersButton.ForeColor = Color.DarkGray;
            UsersButton.Image = Properties.Resources.User_50;
            UsersButton.ImageAlign = ContentAlignment.BottomCenter;
            UsersButton.Location = new Point(3, 245);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(292, 115);
            UsersButton.TabIndex = 2;
            UsersButton.Text = "การจัดการผู้ใช้";
            UsersButton.TextImageRelation = TextImageRelation.ImageAboveText;
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.FromArgb(38, 38, 38);
            InventoryButton.BackgroundImageLayout = ImageLayout.Stretch;
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = Color.DarkGray;
            InventoryButton.Image = Properties.Resources.Inventory_50;
            InventoryButton.ImageAlign = ContentAlignment.BottomCenter;
            InventoryButton.Location = new Point(3, 124);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(292, 115);
            InventoryButton.TabIndex = 1;
            InventoryButton.Text = "การจัดการสินค้า";
            InventoryButton.TextImageRelation = TextImageRelation.ImageAboveText;
            InventoryButton.UseVisualStyleBackColor = false;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // SaleButton
            // 
            SaleButton.BackColor = Color.FromArgb(38, 38, 38);
            SaleButton.BackgroundImageLayout = ImageLayout.Stretch;
            SaleButton.FlatStyle = FlatStyle.Flat;
            SaleButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaleButton.ForeColor = Color.DarkGray;
            SaleButton.Image = Properties.Resources.Cashier_50;
            SaleButton.Location = new Point(3, 3);
            SaleButton.Name = "SaleButton";
            SaleButton.Size = new Size(292, 115);
            SaleButton.TabIndex = 0;
            SaleButton.Text = "ขายสินค้า";
            SaleButton.TextAlign = ContentAlignment.BottomCenter;
            SaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            SaleButton.UseVisualStyleBackColor = false;
            SaleButton.Click += SaleButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1800, 1065);
            Controls.Add(ActivePanel);
            Controls.Add(ControlPanel);
            Controls.Add(TitlePanel);
            Controls.Add(NavigationPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indy POS";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            NavigationPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel9.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label StoreNameLabel;
		private System.Windows.Forms.Button CloseApplicationButton;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel ControlPanel;
        private ModernUI.ModernButton CloseWindowsButton;
        private ModernUI.ModernButton ResizeWindowsButton;
        private ModernUI.ModernButton MinimizeWindowsButton;
        private System.Windows.Forms.Label LoggedInUserLabel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DataFeedStatusLabel;
    }
}

