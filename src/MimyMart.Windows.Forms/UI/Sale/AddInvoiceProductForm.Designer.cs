﻿namespace MimyMart.Windows.Forms.UI.Sale
{
    partial class AddInvoiceProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvoiceProductForm));
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NoteTextBox = new ModernUI.ModernTextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.UnitPriceTextBox = new ModernUI.ModernTextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.DecreaseQuantityButton = new ModernUI.ModernButton();
            this.IncreaseQuantityButton = new ModernUI.ModernButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelUpdateProductButton = new ModernUI.ModernButton();
            this.AddProductButton = new ModernUI.ModernButton();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new ModernUI.ModernTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductCodeLabel.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProductCodeLabel.Location = new System.Drawing.Point(253, 63);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(310, 39);
            this.ProductCodeLabel.TabIndex = 24;
            this.ProductCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DescriptionLabel.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DescriptionLabel.Location = new System.Drawing.Point(253, 105);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(310, 39);
            this.DescriptionLabel.TabIndex = 25;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.NoteTextBox);
            this.panel2.Controls.Add(this.NoteLabel);
            this.panel2.Controls.Add(this.UnitPriceTextBox);
            this.panel2.Controls.Add(this.UnitPriceLabel);
            this.panel2.Controls.Add(this.DecreaseQuantityButton);
            this.panel2.Controls.Add(this.IncreaseQuantityButton);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.QuantityTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DescriptionLabel);
            this.panel2.Controls.Add(this.ProductCodeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 426);
            this.panel2.TabIndex = 30;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NoteTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.NoteTextBox.BorderSize = 1;
            this.NoteTextBox.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.NoteTextBox.Location = new System.Drawing.Point(253, 246);
            this.NoteTextBox.Multiline = false;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.NoteTextBox.PasswordChar = false;
            this.NoteTextBox.ReadOnly = false;
            this.NoteTextBox.Size = new System.Drawing.Size(310, 39);
            this.NoteTextBox.TabIndex = 55;
            this.NoteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NoteTextBox.Texts = "";
            this.NoteTextBox.UnderlinedStyle = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NoteLabel.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NoteLabel.Location = new System.Drawing.Point(107, 246);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(140, 39);
            this.NoteLabel.TabIndex = 54;
            this.NoteLabel.Text = "Note";
            this.NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UnitPriceTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.UnitPriceTextBox.BorderSize = 1;
            this.UnitPriceTextBox.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.UnitPriceTextBox.Location = new System.Drawing.Point(253, 201);
            this.UnitPriceTextBox.Multiline = false;
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.UnitPriceTextBox.PasswordChar = false;
            this.UnitPriceTextBox.ReadOnly = false;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(310, 39);
            this.UnitPriceTextBox.TabIndex = 53;
            this.UnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPriceTextBox.Texts = "";
            this.UnitPriceTextBox.UnderlinedStyle = true;
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UnitPriceLabel.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.UnitPriceLabel.Location = new System.Drawing.Point(107, 201);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(140, 39);
            this.UnitPriceLabel.TabIndex = 52;
            this.UnitPriceLabel.Text = "ราคาขาย ต่อหน่วย";
            this.UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DecreaseQuantityButton
            // 
            this.DecreaseQuantityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DecreaseQuantityButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DecreaseQuantityButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DecreaseQuantityButton.BorderRadius = 19;
            this.DecreaseQuantityButton.BorderSize = 1;
            this.DecreaseQuantityButton.FlatAppearance.BorderSize = 0;
            this.DecreaseQuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseQuantityButton.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseQuantityButton.ForeColor = System.Drawing.Color.White;
            this.DecreaseQuantityButton.Image = global::MimyMart.Windows.Forms.Properties.Resources.Minus_35;
            this.DecreaseQuantityButton.Location = new System.Drawing.Point(524, 148);
            this.DecreaseQuantityButton.Name = "DecreaseQuantityButton";
            this.DecreaseQuantityButton.Size = new System.Drawing.Size(39, 39);
            this.DecreaseQuantityButton.TabIndex = 39;
            this.DecreaseQuantityButton.TextColor = System.Drawing.Color.White;
            this.DecreaseQuantityButton.UseVisualStyleBackColor = false;
            this.DecreaseQuantityButton.Click += new System.EventHandler(this.DecreaseQuantityButton_Click);
            // 
            // IncreaseQuantityButton
            // 
            this.IncreaseQuantityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IncreaseQuantityButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IncreaseQuantityButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IncreaseQuantityButton.BorderRadius = 19;
            this.IncreaseQuantityButton.BorderSize = 1;
            this.IncreaseQuantityButton.FlatAppearance.BorderSize = 0;
            this.IncreaseQuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseQuantityButton.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseQuantityButton.ForeColor = System.Drawing.Color.White;
            this.IncreaseQuantityButton.Image = global::MimyMart.Windows.Forms.Properties.Resources.Plus_35;
            this.IncreaseQuantityButton.Location = new System.Drawing.Point(253, 148);
            this.IncreaseQuantityButton.Name = "IncreaseQuantityButton";
            this.IncreaseQuantityButton.Size = new System.Drawing.Size(39, 39);
            this.IncreaseQuantityButton.TabIndex = 38;
            this.IncreaseQuantityButton.TextColor = System.Drawing.Color.White;
            this.IncreaseQuantityButton.UseVisualStyleBackColor = false;
            this.IncreaseQuantityButton.Click += new System.EventHandler(this.IncreaseQuantityButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.CancelUpdateProductButton);
            this.panel1.Controls.Add(this.AddProductButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.MinimumSize = new System.Drawing.Size(39, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 96);
            this.panel1.TabIndex = 34;
            // 
            // CancelUpdateProductButton
            // 
            this.CancelUpdateProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CancelUpdateProductButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CancelUpdateProductButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.CancelUpdateProductButton.BorderRadius = 18;
            this.CancelUpdateProductButton.BorderSize = 1;
            this.CancelUpdateProductButton.FlatAppearance.BorderSize = 0;
            this.CancelUpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelUpdateProductButton.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelUpdateProductButton.ForeColor = System.Drawing.Color.White;
            this.CancelUpdateProductButton.Location = new System.Drawing.Point(479, 20);
            this.CancelUpdateProductButton.Name = "CancelUpdateProductButton";
            this.CancelUpdateProductButton.Size = new System.Drawing.Size(158, 53);
            this.CancelUpdateProductButton.TabIndex = 10;
            this.CancelUpdateProductButton.Text = "ยกเลิก";
            this.CancelUpdateProductButton.TextColor = System.Drawing.Color.White;
            this.CancelUpdateProductButton.UseVisualStyleBackColor = false;
            this.CancelUpdateProductButton.Click += new System.EventHandler(this.CancelUpdateProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddProductButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddProductButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.AddProductButton.BorderRadius = 19;
            this.AddProductButton.BorderSize = 1;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.Location = new System.Drawing.Point(18, 20);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(158, 53);
            this.AddProductButton.TabIndex = 9;
            this.AddProductButton.Text = "เพิ่มสินค้า";
            this.AddProductButton.TextColor = System.Drawing.Color.White;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "อัพเดทสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.QuantityTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.QuantityTextBox.BorderSize = 1;
            this.QuantityTextBox.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.QuantityTextBox.Location = new System.Drawing.Point(298, 148);
            this.QuantityTextBox.Multiline = false;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.QuantityTextBox.PasswordChar = false;
            this.QuantityTextBox.ReadOnly = false;
            this.QuantityTextBox.Size = new System.Drawing.Size(220, 39);
            this.QuantityTextBox.TabIndex = 35;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTextBox.Texts = "";
            this.QuantityTextBox.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(107, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "จำนวน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(107, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "คำอธิบาย";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("FC Subject [Non-commercial] Reg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(107, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "รหัสสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddInvoiceProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(660, 428);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInvoiceProductForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.Label ProductCodeLabel;
		private System.Windows.Forms.Label DescriptionLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private ModernUI.ModernTextBox QuantityTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
        private ModernUI.ModernButton AddProductButton;
        private ModernUI.ModernButton IncreaseQuantityButton;
        private ModernUI.ModernButton DecreaseQuantityButton;
        private ModernUI.ModernButton CancelUpdateProductButton;
        private ModernUI.ModernTextBox UnitPriceTextBox;
        private System.Windows.Forms.Label UnitPriceLabel;
        private ModernUI.ModernTextBox NoteTextBox;
        private System.Windows.Forms.Label NoteLabel;
    }
}