﻿
namespace MegaDesk_Speelman
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderDate = new System.Windows.Forms.Label();
            this.OrderTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaterialType = new System.Windows.Forms.Label();
            this.DrawerAmount = new System.Windows.Forms.Label();
            this.HeightAmount = new System.Windows.Forms.Label();
            this.WidthAmount = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Confimed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "By: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(271, 117);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(51, 17);
            this.OrderDate.TabIndex = 5;
            this.OrderDate.Text = "Placed";
            // 
            // OrderTotal
            // 
            this.OrderTotal.AutoSize = true;
            this.OrderTotal.Location = new System.Drawing.Point(271, 356);
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.Size = new System.Drawing.Size(40, 17);
            this.OrderTotal.TabIndex = 7;
            this.OrderTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Width:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Drawers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Material:";
            // 
            // MaterialType
            // 
            this.MaterialType.AutoSize = true;
            this.MaterialType.Location = new System.Drawing.Point(271, 293);
            this.MaterialType.Name = "MaterialType";
            this.MaterialType.Size = new System.Drawing.Size(62, 17);
            this.MaterialType.TabIndex = 16;
            this.MaterialType.Text = "Material:";
            // 
            // DrawerAmount
            // 
            this.DrawerAmount.AutoSize = true;
            this.DrawerAmount.Location = new System.Drawing.Point(271, 257);
            this.DrawerAmount.Name = "DrawerAmount";
            this.DrawerAmount.Size = new System.Drawing.Size(64, 17);
            this.DrawerAmount.TabIndex = 15;
            this.DrawerAmount.Text = "Drawers:";
            // 
            // HeightAmount
            // 
            this.HeightAmount.AutoSize = true;
            this.HeightAmount.Location = new System.Drawing.Point(271, 225);
            this.HeightAmount.Name = "HeightAmount";
            this.HeightAmount.Size = new System.Drawing.Size(53, 17);
            this.HeightAmount.TabIndex = 14;
            this.HeightAmount.Text = "Height:";
            // 
            // WidthAmount
            // 
            this.WidthAmount.AutoSize = true;
            this.WidthAmount.Location = new System.Drawing.Point(271, 194);
            this.WidthAmount.Name = "WidthAmount";
            this.WidthAmount.Size = new System.Drawing.Size(48, 17);
            this.WidthAmount.TabIndex = 13;
            this.WidthAmount.Text = "Width:";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(271, 154);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(32, 17);
            this.CustomerName.TabIndex = 12;
            this.CustomerName.Text = "By: ";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 495);
            this.Controls.Add(this.MaterialType);
            this.Controls.Add(this.DrawerAmount);
            this.Controls.Add(this.HeightAmount);
            this.Controls.Add(this.WidthAmount);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderTotal);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label OrderTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MaterialType;
        private System.Windows.Forms.Label DrawerAmount;
        private System.Windows.Forms.Label HeightAmount;
        private System.Windows.Forms.Label WidthAmount;
        private System.Windows.Forms.Label CustomerName;
    }
}