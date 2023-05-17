﻿namespace HotelManagement_ADO.Interface
{
    partial class InteractionInterface
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.serviceBtn = new FontAwesome.Sharp.IconButton();
            this.roomBtn = new FontAwesome.Sharp.IconButton();
            this.bookingBtn = new FontAwesome.Sharp.IconButton();
            this.bookingDetailBtn = new FontAwesome.Sharp.IconButton();
            this.userDetailBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkOutBtn = new FontAwesome.Sharp.IconButton();
            this.servicesBookingBtn = new FontAwesome.Sharp.IconButton();
            this.roomBookingBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customersBtn = new FontAwesome.Sharp.IconButton();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1642, 1000);
            this.mainPanel.TabIndex = 7;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.leftPanel.Controls.Add(this.customersBtn);
            this.leftPanel.Controls.Add(this.productBtn);
            this.leftPanel.Controls.Add(this.serviceBtn);
            this.leftPanel.Controls.Add(this.roomBtn);
            this.leftPanel.Controls.Add(this.bookingBtn);
            this.leftPanel.Controls.Add(this.bookingDetailBtn);
            this.leftPanel.Controls.Add(this.userDetailBtn);
            this.leftPanel.Controls.Add(this.userBtn);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 1000);
            this.leftPanel.TabIndex = 5;
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.productBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(0, 792);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(300, 98);
            this.productBtn.TabIndex = 13;
            this.productBtn.Text = "Products";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productBtn.UseVisualStyleBackColor = true;
            // 
            // serviceBtn
            // 
            this.serviceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.serviceBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.serviceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serviceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.Location = new System.Drawing.Point(0, 694);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.serviceBtn.Size = new System.Drawing.Size(300, 98);
            this.serviceBtn.TabIndex = 12;
            this.serviceBtn.Text = "Services";
            this.serviceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceBtn.UseVisualStyleBackColor = true;
            // 
            // roomBtn
            // 
            this.roomBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomBtn.FlatAppearance.BorderSize = 0;
            this.roomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.roomBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.roomBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.Location = new System.Drawing.Point(0, 596);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.roomBtn.Size = new System.Drawing.Size(300, 98);
            this.roomBtn.TabIndex = 10;
            this.roomBtn.Text = "Rooms";
            this.roomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomBtn.UseVisualStyleBackColor = true;
            // 
            // bookingBtn
            // 
            this.bookingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingBtn.FlatAppearance.BorderSize = 0;
            this.bookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.bookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.Location = new System.Drawing.Point(0, 498);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bookingBtn.Size = new System.Drawing.Size(300, 98);
            this.bookingBtn.TabIndex = 15;
            this.bookingBtn.Text = "Booking";
            this.bookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingBtn.UseVisualStyleBackColor = true;
            // 
            // bookingDetailBtn
            // 
            this.bookingDetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingDetailBtn.FlatAppearance.BorderSize = 0;
            this.bookingDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingDetailBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.bookingDetailBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.bookingDetailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingDetailBtn.Location = new System.Drawing.Point(0, 400);
            this.bookingDetailBtn.Name = "bookingDetailBtn";
            this.bookingDetailBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bookingDetailBtn.Size = new System.Drawing.Size(300, 98);
            this.bookingDetailBtn.TabIndex = 11;
            this.bookingDetailBtn.Text = "Booking Detail";
            this.bookingDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingDetailBtn.UseVisualStyleBackColor = true;
            // 
            // userDetailBtn
            // 
            this.userDetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userDetailBtn.FlatAppearance.BorderSize = 0;
            this.userDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDetailBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.userDetailBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userDetailBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.Location = new System.Drawing.Point(0, 302);
            this.userDetailBtn.Name = "userDetailBtn";
            this.userDetailBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.userDetailBtn.Size = new System.Drawing.Size(300, 98);
            this.userDetailBtn.TabIndex = 14;
            this.userDetailBtn.Text = "User Detail";
            this.userDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userDetailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userDetailBtn.UseVisualStyleBackColor = true;
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.userBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.Location = new System.Drawing.Point(0, 204);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(300, 98);
            this.userBtn.TabIndex = 9;
            this.userBtn.Text = "Users List";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 204);
            this.panel3.TabIndex = 8;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1642, 129);
            this.topPanel.TabIndex = 6;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.checkOutBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.checkOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.Location = new System.Drawing.Point(992, 0);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.checkOutBtn.Size = new System.Drawing.Size(270, 127);
            this.checkOutBtn.TabIndex = 14;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutBtn.UseVisualStyleBackColor = true;
            // 
            // servicesBookingBtn
            // 
            this.servicesBookingBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.servicesBookingBtn.FlatAppearance.BorderSize = 0;
            this.servicesBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesBookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.servicesBookingBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.servicesBookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.servicesBookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.servicesBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBookingBtn.Location = new System.Drawing.Point(772, 0);
            this.servicesBookingBtn.Name = "servicesBookingBtn";
            this.servicesBookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.servicesBookingBtn.Size = new System.Drawing.Size(220, 127);
            this.servicesBookingBtn.TabIndex = 13;
            this.servicesBookingBtn.Text = "Services";
            this.servicesBookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicesBookingBtn.UseVisualStyleBackColor = true;
            // 
            // roomBookingBtn
            // 
            this.roomBookingBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomBookingBtn.FlatAppearance.BorderSize = 0;
            this.roomBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomBookingBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.roomBookingBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.roomBookingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.roomBookingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomBookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBookingBtn.Location = new System.Drawing.Point(502, 0);
            this.roomBookingBtn.Name = "roomBookingBtn";
            this.roomBookingBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.roomBookingBtn.Size = new System.Drawing.Size(270, 127);
            this.roomBookingBtn.TabIndex = 12;
            this.roomBookingBtn.Text = "Booking Room";
            this.roomBookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomBookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomBookingBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.checkOutBtn);
            this.panel2.Controls.Add(this.servicesBookingBtn);
            this.panel2.Controls.Add(this.roomBookingBtn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1642, 127);
            this.panel2.TabIndex = 8;
            // 
            // customersBtn
            // 
            this.customersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersBtn.FlatAppearance.BorderSize = 0;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.customersBtn.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.customersBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.customersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.Location = new System.Drawing.Point(0, 890);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.customersBtn.Size = new System.Drawing.Size(300, 98);
            this.customersBtn.TabIndex = 16;
            this.customersBtn.Text = "Customers";
            this.customersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customersBtn.UseVisualStyleBackColor = true;
            // 
            // InteractionInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1000);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InteractionInterface";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton serviceBtn;
        private FontAwesome.Sharp.IconButton roomBtn;
        private FontAwesome.Sharp.IconButton bookingBtn;
        private FontAwesome.Sharp.IconButton bookingDetailBtn;
        private FontAwesome.Sharp.IconButton userDetailBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton checkOutBtn;
        private FontAwesome.Sharp.IconButton servicesBookingBtn;
        private FontAwesome.Sharp.IconButton roomBookingBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton customersBtn;
    }
}