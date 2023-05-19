﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using HotelManagement_ADO.BS_Layer;
using HotelManagement_ADO.DB_Layer;

namespace HotelManagement_ADO.EmployeeForms
{
    public partial class EmployeeBooking : Form
    {
        DBMain db = new DBMain();
        DateTime datecheck = DateTime.Now;
        DateTime dtIN = new DateTime();
        DateTime dtOUT = new DateTime();
        TimeSpan tIN = new TimeSpan();
        TimeSpan tOUT = new TimeSpan();
        //
        string dateIN;
        string dateOUT;

        string name;
        string id;
        int customer_ID;
        int book_ID, roomID;

        int rAvai;
        int rBookedRoom;
        int Unit;

        bool existAdd;
        bool nonexistAdd;
        string err;
        public EmployeeBooking()
        {
            InitializeComponent();
        }

        void LoadAvaiRoom()
        {
            dateIN = dtIN.Date.Year.ToString() + "-" + dtIN.Date.Month.ToString() + "-" + dtIN.Day.ToString() + " " + tIN.ToString();
            dateOUT = dtOUT.Date.Year.ToString() + "-" + dtOUT.Date.Month.ToString() + "-" + dtOUT.Day.ToString() + " " + tOUT.ToString();
            string fun = $"select * from fn_GetAvailableRooms('{DateTime.Parse(dateIN)}','{DateTime.Parse(dateOUT)}')";
            DataSet dataSet = db.ExecuteQueryDataSet(fun, CommandType.Text);
            DataTable dataTable = dataSet.Tables[0];
            dgvAvaiRoom.DataSource = dataTable;
            dgvAvaiRoom.AutoGenerateColumns = true;
            dgvAvaiRoom.ColumnHeadersHeight = 30;
            dgvAvaiRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void LoadBookedRoom()
        {
            dateIN = dtIN.Date.Year.ToString() + "-" + dtIN.Date.Month.ToString() + "-" + dtIN.Day.ToString() + " " + tIN.ToString();
            dateOUT = dtOUT.Date.Year.ToString() + "-" + dtOUT.Date.Month.ToString() + "-" + dtOUT.Day.ToString() + " " + tOUT.ToString();

            if (dtpCheckInDate.Value != datecheck || dtpCheckOutDate.Value != datecheck || !string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(id))
            {
                string fun = $"select * from fn_GetBookedRooms('{DateTime.Parse(dateIN)}','{DateTime.Parse(dateOUT)}')";
                DataSet dataSet = db.ExecuteQueryDataSet(fun, CommandType.Text);
                DataTable dataTable = dataSet.Tables[0];
                dgvBookedRoom.DataSource = dataTable;
            }

            //Calculate the interval of stay-in days
            TimeSpan interval = DateTime.Parse(dateOUT) - DateTime.Parse(dateIN);
            double daysDiff = interval.TotalDays;
            Unit = (int)daysDiff;

            //Get name/ ID card of existed customers
            name = txtName.Text.Trim();
            id = txtIdentityNum.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                string pro = $"EXEC SP_FindCustomerByName N'{name}'";
                using (DataSet dataSet = db.ExecuteQueryDataSet(pro, CommandType.Text))
                {
                    DataTable dataTable = dataSet.Tables[0];
                    dgvBookedRoom.DataSource = dataTable;
                }
            }
            else if (!string.IsNullOrEmpty(id))
            {
                string pro = $"EXEC SP_FindCustomerByIDC '{id}'";
                using (DataSet dataSet = db.ExecuteQueryDataSet(pro, CommandType.Text))
                {
                    DataTable dataTable = dataSet.Tables[0];
                    dgvBookedRoom.DataSource = dataTable;
                }
            }
            dgvBookedRoom.AutoGenerateColumns = true;
            dgvBookedRoom.ColumnHeadersHeight = 30;
            dgvBookedRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name) && dgvBookedRoom.Rows.Count > 0)
            {
                //Existed customers 
                if (!string.IsNullOrEmpty(id) && dgvBookedRoom.Rows.Count > 0)
                {
                    ReturnCustomerID(name, id);
                    BLBooking blB = new BLBooking();
                    if (blB.AddBooking(
                        1,
                        1,
                        customer_ID,
                        DateTime.Parse(dateIN),
                        DateTime.Parse(dateOUT), ref err))
                        MessageBox.Show("Add Booking successfully");
                    Refresh();
                    LoadAvaiRoom();
                    LoadBookedRoom();
                    // Kich hoạt biến Them
                    existAdd = true;
                    ReturnBookID(DateTime.Parse(dateIN), DateTime.Parse(dateOUT));
                    ReturnRoomID(book_ID);
                }
                else if (!string.IsNullOrEmpty(id) && dgvBookedRoom.Rows.Count == 0)
                {
                    BLCustomer blCUS = new BLCustomer();
                    bool gen = false;
                    if (cbGender.Text == "Male")
                        gen = true;
                    if (blCUS.AddCustomers(
                        txtName.Text,
                        dtpBirthday.Value.Date,
                        gen,
                        txtPhoneNumber.Text,
                        txtAddress.Text,
                        txtIdentityNum.Text, ref err))
                        MessageBox.Show("Add Customer successfully");
                    Refresh();
                    LoadAvaiRoom();
                    LoadBookedRoom();
                    // Kich hoạt biến Them
                    nonexistAdd = true;

                    #region AddBooking for new Customers
                    ReturnCustomerID(name, id);
                    BLBooking blB = new BLBooking();
                    if (blB.AddBooking(
                        1,
                        1, //dang tu nhap staff
                        customer_ID,
                        DateTime.Parse(dateIN),
                        DateTime.Parse(dateOUT), ref err))
                        MessageBox.Show("Add Booking successfully");
                    Refresh();
                    LoadAvaiRoom();
                    LoadBookedRoom();
                    #endregion

                    ReturnBookID(DateTime.Parse(dateIN), DateTime.Parse(dateOUT));
                    ReturnRoomID(book_ID);
                }
            }
            else if (!string.IsNullOrEmpty(name) && dgvBookedRoom.Rows.Count == 0)
            {
                BLCustomer blCUS = new BLCustomer();
                bool gen = false;
                if (cbGender.Text == "Male")
                    gen = true;
                if (blCUS.AddCustomers(
                    txtName.Text,
                    dtpBirthday.Value.Date,
                    gen,
                    txtPhoneNumber.Text,
                    txtAddress.Text,
                    txtIdentityNum.Text, ref err))
                    MessageBox.Show("Add Customer successfully");
                Refresh();
                LoadAvaiRoom();
                LoadBookedRoom();
                // Kich hoạt biến Them
                nonexistAdd = true;

                #region AddBooking for new Customers
                ReturnCustomerID(name, id);
                BLBooking blB = new BLBooking();
                if (blB.AddBooking(
                    1,
                    1, //dang tu nhap staff
                    customer_ID,
                    DateTime.Parse(dateIN),
                    DateTime.Parse(dateOUT), ref err))
                    MessageBox.Show("Add Booking successfully");
                Refresh();
                LoadAvaiRoom();
                LoadBookedRoom();
                #endregion

                ReturnBookID(DateTime.Parse(dateIN), DateTime.Parse(dateOUT));
                ReturnRoomID(book_ID);
            }
            addExistCustomer(existAdd);
            addNonExistCustomer(nonexistAdd);
        }
        void addExistCustomer(bool existAdd)
        {
            // Open connection
            // Adding data
            if (existAdd)
            {
                //Add data into table Booking Detail
                BLBookingDetail blBD = new BLBookingDetail();
                if (blBD.AddBookingDetail(
                    book_ID,
                    Convert.ToInt32(dgvAvaiRoom.Rows[rAvai].Cells[0].Value.ToString()),
                    Convert.ToInt32(dgvAvaiRoom.Rows[rAvai].Cells[4].Value.ToString()),
                    Unit, ref err))
                    MessageBox.Show("Add Booking Detail successfully");

                //Add data into table Customer Detail
                BLCustomerDetail blCD = new BLCustomerDetail();
                if (blCD.AddCustomerDetail(
                    book_ID,
                    roomID,
                    customer_ID, ref err))
                    MessageBox.Show("Add Customer Detail successfully");

                LoadAvaiRoom();
                LoadBookedRoom();
            }
            // Close connection
        }
        void addNonExistCustomer(bool nonexistAdd)
        {
            // Open connection
            // Adding data
            if (nonexistAdd)
            {
                //Add data into table Booking Detail
                BLBookingDetail blBD = new BLBookingDetail();
                if (blBD.AddBookingDetail(
                    book_ID,
                    Convert.ToInt32(dgvAvaiRoom.Rows[rAvai].Cells[0].Value.ToString()),
                    Convert.ToInt32(dgvAvaiRoom.Rows[rAvai].Cells[4].Value.ToString()),
                    Unit, ref err))
                    MessageBox.Show("Add Booking Detail successfully");

                //Add data into table Customer Detail
                BLCustomerDetail blCD = new BLCustomerDetail();
                if (blCD.AddCustomerDetail(
                    book_ID,
                    roomID,
                    customer_ID, ref err))
                    MessageBox.Show("Add Customer Detail successfully");

                LoadAvaiRoom();
                LoadBookedRoom();
            }
            // Close connection
        }

        //Get ID from database
        void ReturnCustomerID(string name, string id)
        {
            string query = "SELECT cID FROM Customers WHERE Fullname = @Name AND IDCARD = @ID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@ID", id);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    customer_ID = reader.GetInt32(0);
                }
            }
        }
        void ReturnBookID(DateTime indate, DateTime outdate)
        {
            string query = "SELECT bookID FROM Bookings WHERE Check_In = @CheckIn AND Check_Out = @CheckOut";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@CheckIn", indate);
            command.Parameters.AddWithValue("@CheckOut", outdate);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    book_ID = reader.GetInt32(0);
                }
            }
        }
        void ReturnRoomID(int gotbookID)
        {
            string query = "SELECT room_ID FROM BookingDetails WHERE book_ID = @BookID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@BookID", gotbookID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    roomID = reader.GetInt32(0);
                }
            }
        }

        //Check changes of common controls
        private void dgvAvaiRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rAvai = dgvAvaiRoom.CurrentCell.RowIndex;
        }
        private void dgvBookedRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rBookedRoom = dgvBookedRoom.CurrentCell.RowIndex;
        }
        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtIN = this.dtpCheckInDate.Value.Date;
            LoadAvaiRoom();
            LoadBookedRoom();
        }
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            dtOUT = this.dtpCheckOutDate.Value.Date;
            LoadAvaiRoom();
            LoadBookedRoom();
        }
        private void dtpCheckInTime_ValueChanged(object sender, EventArgs e)
        {
            tIN = this.dtpCheckInTime.Value.TimeOfDay;
            LoadAvaiRoom();
            LoadBookedRoom();
        }
        private void dtpCheckOutTime_ValueChanged(object sender, EventArgs e)
        {
            tOUT = this.dtpCheckOutTime.Value.TimeOfDay;
            LoadAvaiRoom();
            LoadBookedRoom();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            LoadBookedRoom();
        }
        private void txtIdentityNum_TextChanged(object sender, EventArgs e)
        {
            LoadBookedRoom();

        }

    }
}
