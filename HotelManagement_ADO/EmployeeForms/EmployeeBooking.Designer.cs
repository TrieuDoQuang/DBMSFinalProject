﻿namespace HotelManagement_ADO.EmployeeForms
{
    partial class EmployeeBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dtpCheckOutTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckInTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBookedRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dtpCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvAvaiRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentityNum = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaiRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderColor = System.Drawing.Color.White;
            this.cancelBtn.BorderRadius = 15;
            this.cancelBtn.BorderThickness = 1;
            this.cancelBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.cancelBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelBtn.FillColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(1203, 774);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(166, 65);
            this.cancelBtn.TabIndex = 87;
            this.cancelBtn.Text = "Cancel";
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Checked = true;
            this.dtpCheckOutTime.CustomFormat = "HH:mm tt";
            this.dtpCheckOutTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(1090, 230);
            this.dtpCheckOutTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.ShowUpDown = true;
            this.dtpCheckOutTime.Size = new System.Drawing.Size(265, 43);
            this.dtpCheckOutTime.TabIndex = 86;
            this.dtpCheckOutTime.Value = new System.DateTime(2023, 5, 10, 13, 43, 54, 292);
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Checked = true;
            this.dtpCheckInTime.CustomFormat = "HH:mm tt";
            this.dtpCheckInTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckInTime.Location = new System.Drawing.Point(1090, 108);
            this.dtpCheckInTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.ShowUpDown = true;
            this.dtpCheckInTime.Size = new System.Drawing.Size(265, 43);
            this.dtpCheckInTime.TabIndex = 85;
            this.dtpCheckInTime.Value = new System.DateTime(2023, 5, 10, 13, 43, 54, 292);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(1086, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 23);
            this.label13.TabIndex = 84;
            this.label13.Text = "Check Out Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(1086, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 23);
            this.label14.TabIndex = 83;
            this.label14.Text = "Check In Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1050, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 23);
            this.label12.TabIndex = 82;
            this.label12.Text = "Booked Room";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(458, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 81;
            this.label11.Text = "Room";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(36, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 23);
            this.label10.TabIndex = 80;
            this.label10.Text = "Customer Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(458, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "Available Room";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(66, 122);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(316, 43);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 78;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(66, 465);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(316, 43);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 77;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(66, 350);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(316, 43);
            this.txtPhoneNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPhoneNumber.TabIndex = 76;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthday.Location = new System.Drawing.Point(66, 686);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(316, 43);
            this.dtpBirthday.TabIndex = 74;
            this.dtpBirthday.Value = new System.DateTime(2023, 5, 10, 13, 43, 54, 292);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(62, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 73;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(62, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 72;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Phone Number";
            // 
            // dgvBookedRoom
            // 
            this.dgvBookedRoom.AllowUserToAddRows = false;
            this.dgvBookedRoom.AllowUserToDeleteRows = false;
            this.dgvBookedRoom.AllowUserToResizeColumns = false;
            this.dgvBookedRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvBookedRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBookedRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookedRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBookedRoom.ColumnHeadersHeight = 4;
            this.dgvBookedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookedRoom.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBookedRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookedRoom.Location = new System.Drawing.Point(1057, 350);
            this.dgvBookedRoom.Name = "dgvBookedRoom";
            this.dgvBookedRoom.ReadOnly = true;
            this.dgvBookedRoom.RowHeadersVisible = false;
            this.dgvBookedRoom.RowHeadersWidth = 51;
            this.dgvBookedRoom.RowTemplate.Height = 24;
            this.dgvBookedRoom.Size = new System.Drawing.Size(538, 352);
            this.dgvBookedRoom.TabIndex = 70;
            this.dgvBookedRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookedRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBookedRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookedRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookedRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookedRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookedRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBookedRoom.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBookedRoom.ThemeStyle.ReadOnly = true;
            this.dgvBookedRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookedRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookedRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookedRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBookedRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBookedRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookedRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderColor = System.Drawing.Color.White;
            this.saveBtn.BorderRadius = 15;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.saveBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(1411, 774);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(166, 65);
            this.saveBtn.TabIndex = 69;
            this.saveBtn.Text = "Save";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Checked = true;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(462, 235);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(330, 43);
            this.dtpCheckOutDate.TabIndex = 68;
            this.dtpCheckOutDate.Value = new System.DateTime(2023, 5, 10, 13, 43, 54, 292);
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Checked = true;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckInDate.Location = new System.Drawing.Point(462, 113);
            this.dtpCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(330, 43);
            this.dtpCheckInDate.TabIndex = 67;
            this.dtpCheckInDate.Value = new System.DateTime(2023, 5, 10, 13, 43, 54, 292);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbGender.ForeColor = System.Drawing.Color.White;
            this.cbGender.HoverState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbGender.ItemHeight = 30;
            this.cbGender.Items.AddRange(new object[] {
            "Masculine",
            "Feminine"});
            this.cbGender.ItemsAppearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ItemsAppearance.SelectedFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.Location = new System.Drawing.Point(66, 588);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(316, 36);
            this.cbGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbGender.TabIndex = 66;
            // 
            // dgvAvaiRoom
            // 
            this.dgvAvaiRoom.AllowUserToAddRows = false;
            this.dgvAvaiRoom.AllowUserToDeleteRows = false;
            this.dgvAvaiRoom.AllowUserToResizeColumns = false;
            this.dgvAvaiRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvAvaiRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAvaiRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvaiRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAvaiRoom.ColumnHeadersHeight = 4;
            this.dgvAvaiRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvaiRoom.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAvaiRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvaiRoom.Location = new System.Drawing.Point(462, 350);
            this.dgvAvaiRoom.Name = "dgvAvaiRoom";
            this.dgvAvaiRoom.ReadOnly = true;
            this.dgvAvaiRoom.RowHeadersVisible = false;
            this.dgvAvaiRoom.RowHeadersWidth = 51;
            this.dgvAvaiRoom.RowTemplate.Height = 24;
            this.dgvAvaiRoom.Size = new System.Drawing.Size(538, 352);
            this.dgvAvaiRoom.TabIndex = 65;
            this.dgvAvaiRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvaiRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAvaiRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAvaiRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAvaiRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAvaiRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvaiRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAvaiRoom.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvAvaiRoom.ThemeStyle.ReadOnly = true;
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAvaiRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(62, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(458, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Check Out Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(458, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Check In Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Identity Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Name";
            // 
            // txtIdentityNum
            // 
            this.txtIdentityNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentityNum.DefaultText = "";
            this.txtIdentityNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdentityNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdentityNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentityNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdentityNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtIdentityNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentityNum.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdentityNum.Location = new System.Drawing.Point(66, 235);
            this.txtIdentityNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIdentityNum.Name = "txtIdentityNum";
            this.txtIdentityNum.PasswordChar = '\0';
            this.txtIdentityNum.PlaceholderText = "";
            this.txtIdentityNum.SelectedText = "";
            this.txtIdentityNum.Size = new System.Drawing.Size(316, 43);
            this.txtIdentityNum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtIdentityNum.TabIndex = 75;
            // 
            // EmployeeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1596, 1000);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dtpCheckOutTime);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBookedRoom);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dtpCheckOutDate);
            this.Controls.Add(this.dtpCheckInDate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dgvAvaiRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentityNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeBooking";
            this.Text = "EmployeeBooking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookedRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaiRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOutTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBookedRoom;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOutDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckInDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAvaiRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdentityNum;
    }
}