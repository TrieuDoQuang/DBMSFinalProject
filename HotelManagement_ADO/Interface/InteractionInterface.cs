﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HotelManagement_ADO.AdminForms;
using HotelManagement_ADO.EmployeeForms;

namespace HotelManagement_ADO.Interface
{
    public partial class InteractionInterface : Form
    {

        public string StoredUsername { get; set; }
        public int Role { get; set; }
        public string FullName { get; set; }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        private Form currentChildForm;

        public InteractionInterface()
        {
            InitializeComponent();
            AllocConsole();
            SetUserDetails(StoredUsername,Role, FullName);
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Users());
        }

        private void userDetailBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerDetail());
        }

        private void bookingDetailBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new BookingDetail());
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Booking());
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Room());
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Service());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Customers());
        }

        private void roomBookingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeBooking());
        }

        private void servicesBookingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeService());
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CheckOut());
        }
        public void SetUserDetails(string storedUsername, int role, string fullName)
        {
            lbUserID.Text = storedUsername;
            if(role == 1)
            {
                lbRole.Text = "Admin";
            }
            else if(role == 2)
            {
                lbRole.Text = "Employee";
            }
            lbName.Text = fullName;
        }
    }
}
