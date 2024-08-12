namespace MimyMart.Windows.Forms.UI.Login
{
    partial class UserLogInPanel
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
            PasswordVisibilityButton = new ModernUI.ModernButton();
            label10 = new Label();
            UserSecretTextBox = new ModernUI.ModernTextBox();
            label2 = new Label();
            LogInButton = new ModernUI.ModernButton();
            UserInputPanel = new Panel();
            UsersComboBox = new ModernUI.ModernComboBox();
            pictureBox1 = new PictureBox();
            UserInputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PasswordVisibilityButton
            // 
            PasswordVisibilityButton.BackColor = Color.FromArgb(30, 30, 30);
            PasswordVisibilityButton.BackgroundColor = Color.FromArgb(30, 30, 30);
            PasswordVisibilityButton.BorderColor = Color.FromArgb(38, 38, 38);
            PasswordVisibilityButton.BorderRadius = 19;
            PasswordVisibilityButton.BorderSize = 1;
            PasswordVisibilityButton.FlatAppearance.BorderSize = 0;
            PasswordVisibilityButton.FlatStyle = FlatStyle.Flat;
            PasswordVisibilityButton.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordVisibilityButton.ForeColor = Color.White;
            PasswordVisibilityButton.Image = Properties.Resources.Visible_25;
            PasswordVisibilityButton.Location = new Point(396, 79);
            PasswordVisibilityButton.Name = "PasswordVisibilityButton";
            PasswordVisibilityButton.Size = new Size(39, 39);
            PasswordVisibilityButton.TabIndex = 81;
            PasswordVisibilityButton.TextColor = Color.White;
            PasswordVisibilityButton.UseVisualStyleBackColor = false;
            PasswordVisibilityButton.Click += PasswordVisibilityButton_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(30, 30, 30);
            label10.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(20, 34);
            label10.Name = "label10";
            label10.Size = new Size(92, 39);
            label10.TabIndex = 82;
            label10.Text = "Username";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserSecretTextBox
            // 
            UserSecretTextBox.BackColor = Color.FromArgb(30, 30, 30);
            UserSecretTextBox.BorderColor = Color.DimGray;
            UserSecretTextBox.BorderSize = 1;
            UserSecretTextBox.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSecretTextBox.ForeColor = Color.Gainsboro;
            UserSecretTextBox.Location = new Point(118, 79);
            UserSecretTextBox.Multiline = false;
            UserSecretTextBox.Name = "UserSecretTextBox";
            UserSecretTextBox.Padding = new Padding(7);
            UserSecretTextBox.PasswordChar = true;
            UserSecretTextBox.ReadOnly = false;
            UserSecretTextBox.Size = new Size(272, 39);
            UserSecretTextBox.TabIndex = 84;
            UserSecretTextBox.TextAlign = HorizontalAlignment.Left;
            UserSecretTextBox.Texts = "";
            UserSecretTextBox.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("FC Subject [Non-commercial] Reg", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(20, 79);
            label2.Name = "label2";
            label2.Size = new Size(92, 39);
            label2.TabIndex = 80;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(38, 38, 38);
            LogInButton.BackgroundColor = Color.FromArgb(38, 38, 38);
            LogInButton.BorderColor = Color.FromArgb(50, 190, 166);
            LogInButton.BorderRadius = 19;
            LogInButton.BorderSize = 1;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("FC Subject [Non-commercial] Reg", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(437, 682);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(463, 74);
            LogInButton.TabIndex = 85;
            LogInButton.Text = "Login";
            LogInButton.TextColor = Color.White;
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // UserInputPanel
            // 
            UserInputPanel.BackColor = Color.FromArgb(30, 30, 30);
            UserInputPanel.Controls.Add(UsersComboBox);
            UserInputPanel.Controls.Add(label10);
            UserInputPanel.Controls.Add(PasswordVisibilityButton);
            UserInputPanel.Controls.Add(label2);
            UserInputPanel.Controls.Add(UserSecretTextBox);
            UserInputPanel.Location = new Point(437, 512);
            UserInputPanel.Name = "UserInputPanel";
            UserInputPanel.Size = new Size(463, 146);
            UserInputPanel.TabIndex = 85;
            // 
            // UsersComboBox
            // 
            UsersComboBox.BackColor = Color.FromArgb(30, 30, 30);
            UsersComboBox.BorderColor = Color.DimGray;
            UsersComboBox.BorderSize = 0;
            UsersComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            UsersComboBox.Font = new Font("FC Subject [Non-commercial] Reg", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersComboBox.ForeColor = Color.Gainsboro;
            UsersComboBox.IconColor = Color.Gainsboro;
            UsersComboBox.ListBackColor = Color.FromArgb(38, 38, 38);
            UsersComboBox.ListTextColor = Color.Gainsboro;
            UsersComboBox.Location = new Point(118, 24);
            UsersComboBox.MinimumSize = new Size(200, 35);
            UsersComboBox.Name = "UsersComboBox";
            UsersComboBox.SelectedIndex = -1;
            UsersComboBox.SelectedItem = null;
            UsersComboBox.Size = new Size(317, 49);
            UsersComboBox.TabIndex = 83;
            UsersComboBox.Texts = "ผู้ใช้งาน";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MimyMart_Image;
            pictureBox1.Location = new Point(492, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            // 
            // UserLogInPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(UserInputPanel);
            Controls.Add(LogInButton);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "UserLogInPanel";
            Size = new Size(1421, 782);
            VisibleChanged += UserLogInPanel_VisibleChanged;
            UserInputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ModernUI.ModernButton PasswordVisibilityButton;
        private System.Windows.Forms.Label label10;
        private ModernUI.ModernTextBox UserSecretTextBox;
        private System.Windows.Forms.Label label2;
        private ModernUI.ModernButton LogInButton;
        private System.Windows.Forms.Panel UserInputPanel;
        private ModernUI.ModernComboBox UsersComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
