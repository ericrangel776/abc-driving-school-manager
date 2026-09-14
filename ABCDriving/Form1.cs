using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABCDriving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.clientTableAdapter.Fill(this.f25_285BDataSet.Client);
                this.classTableAdapter.Fill(this.f25_285BDataSet.Class);
                this.staffTableAdapter.Fill(this.f25_285BDataSet.Staff);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // Method to get the database connection string
        private string getConnectionString()
        {
            return "Data Source=YOUR_SERVER_NAME\\INSTANCE_NAME;Initial Catalog=F25_285B;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }

        // when either ID textbox field changes, reload the respective datagrid (either client or staff)
        // with the respective classes for that person (handles both inital load and any future changes)
        private void clientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            loadClassDataGrid("Client", clientIDTextBox.Text.ToString());
        }

        private void staffIDTextBox_TextChanged(object sender, EventArgs e)
        {
            loadClassDataGrid("Staff", staffIDTextBox.Text.ToString());
        }

        // method that loads the class datagrid for either staff or client
        // based on the selectedPerson parameter and the personID parameter
        // (which is either the staffID or clientID based on the call)
        private void loadClassDataGrid(string selectedPerson , string personID)
        {
            // get the connection string
            String strConn = getConnectionString();

            // set up necessary sql objects
            SqlConnection cnnGridView;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();
 
            String strSQL;

            // build the appropriate sql query based on whether staff or client is selected
            if (selectedPerson == "Staff")
            {
                // sql query to get all classes for the selected instructor
                strSQL = "SELECT [ClassDate] as [Date], [ClassTime] as [Time], [ClientName] as [Client Name] " +
                          " FROM Class INNER JOIN Client on Class.ClientID = Client.ClientID" +
                          " WHERE Class.InstructorID = " + personID + getDateFilter();
                /*Added above the date filter here*/

                try
                {
                    cnnGridView = new SqlConnection(strConn);
                    cnnGridView.Open();

                    cmdGetData = new SqlCommand();

                    cmdGetData.Connection = cnnGridView;
                    cmdGetData.CommandType = CommandType.Text;
                    cmdGetData.CommandText = strSQL;

                    tbl.Load(cmdGetData.ExecuteReader());
                    classStaffDataGridView.DataSource = tbl.DefaultView;

                    // styling the datagridview for better readability
                    classStaffDataGridView.Columns["Date"].DefaultCellStyle.Format = "D";                    
                    classStaffDataGridView.Columns["Date"].Width = 160;

                    classStaffDataGridView.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    classStaffDataGridView.Columns["Client Name"].Width = 150;

                    classStaffDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    classStaffDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (selectedPerson == "Client")
            {
                // sql query to get all classes for the selected client
                strSQL = "SELECT [ClassDate] as [Date], [ClassTime] as [Time], [StaffName] as [Instructor Name] " +
                              " FROM Class INNER JOIN Staff on Class.InstructorID = Staff.StaffID" +
                              " WHERE Class.ClientID = " + personID;

                try
                {

                    cnnGridView = new SqlConnection(strConn);
                    cnnGridView.Open();

                    cmdGetData = new SqlCommand();

                    cmdGetData.Connection = cnnGridView;
                    cmdGetData.CommandType = CommandType.Text;
                    cmdGetData.CommandText = strSQL;

                    // styling the datagridview for better readability
                    tbl.Load(cmdGetData.ExecuteReader());
                    classClientDataGridView.DataSource = tbl.DefaultView;

                    classClientDataGridView.Columns["Date"].DefaultCellStyle.Format = "D";
                    classClientDataGridView.Columns["Date"].Width = 160;

                    classClientDataGridView.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    classClientDataGridView.Columns["Instructor Name"].Width = 160;

                    classClientDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    classClientDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            // before doing anything, make sure the instructor and time slot are valid
            if (cboNewClassInstructor.SelectedValue == null || cboNewClassInstructor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid instructor.");
                return;
            }

            try
            {
                Convert.ToInt32(cboTimeSlot.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a valid time slot.");
                return;
            }

            // grab all the necessary class info from the form
            string clientID = clientIDTextBox.Text;
            string instructorID = cboNewClassInstructor.SelectedValue.ToString();
            DateTime classDate = dtpClassDate.Value.Date;
            int classTime = Convert.ToInt32(cboTimeSlot.Text);

            // perform basic date and time validations
            if (classDate < DateTime.Today)
            {
                MessageBox.Show("Class date cannot be in the past.");
                return;
            }
            if (classTime < 8 || classTime > 18)
            {
                MessageBox.Show("Class time must be between 8 and 18.");
                return;
            }

            // additional validation by checking if there is any time overlap
            // with the client or instructor (can't be in two places at once)
            if (!isClassAvailable(clientID, instructorID, classDate, classTime))
            {
                MessageBox.Show("The selected time slot is not available for the client and/or instructor.");
                return;
            }

            // If all validations pass, add the new class            
            addNewClass(clientID, instructorID, classDate, classTime);
        }

        // method that uses an sql query to see if any overlap is present
        // given a client, instructor, and time. If there is overlap or an
        // error occurs, returns false. If the class is available, returns true
        private bool isClassAvailable(string clientID, string instructorID, DateTime classDate, int classTime)
        {
            string strConn = getConnectionString();
            SqlConnection cnnClassTime;
            SqlCommand cmdClassTime;
            SqlDataReader rdrClassTime;

            // build the sql query to check for any existing classes
            // with the same time slot and either the same client or instructor
            String strSQL = "SELECT *" +
                             " FROM Class" +
                             " WHERE ClassTime = " + classTime +
                             " AND ClassDate = '" + classDate.ToString("yyyy-MM-dd") + "'" +
                             " AND (ClientID = " + clientID +
                             " OR InstructorID = " + instructorID + ")";

            try
            {
                cnnClassTime = new SqlConnection(strConn);
                cnnClassTime.Open();
                cmdClassTime = new SqlCommand(strSQL, cnnClassTime);
                rdrClassTime = cmdClassTime.ExecuteReader();

                // if there are any records with the same time slot and with
                // either the same client or instructor, return false
                if (rdrClassTime.HasRows)
                {
                    cnnClassTime.Close();
                    return false;
                }
                // otherwise, return true
                else
                {
                    cnnClassTime.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        // method that will use a sql insert statement to
        // add the newly picked class into the database using
        // all the relevent information provided on the form
        private void addNewClass(string clientID, string instructorID, DateTime classDate, int classTime)
        {
            string strConn = getConnectionString();
            SqlConnection cnnAddClass;
            SqlCommand cmdAddClass;
            String strSQL = "INSERT INTO Class (ClientID, InstructorID, ClassDate, ClassTime)" +
                             " VALUES (" + clientID + ", " + instructorID + ", " +
                             "'" + classDate.ToString("yyyy-MM-dd") + "', " + classTime + ")";
            //MessageBox.Show(strSQL);

            try
            {
                cnnAddClass = new SqlConnection(strConn);
                cnnAddClass.Open();

                cmdAddClass = new SqlCommand(strSQL, cnnAddClass);

                cmdAddClass.ExecuteNonQuery();

                // Refresh the class data so it'll appear instantly 
                this.classTableAdapter.Fill(this.f25_285BDataSet.Class);     
                
                MessageBox.Show("New class added successfully.");
                cnnAddClass.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new class: " + ex.Message);
            }
        }
        
        //---For the radio date radio buttons in the staff tab---

        //Refresh the datagrid
        public void refreshDateData() 
        {
            if (!string.IsNullOrWhiteSpace(staffIDTextBox.Text))
            {
                loadClassDataGrid("Staff", staffIDTextBox.Text);
            }
        }
        
        //Filters by dates based on radio button selection
        public string getDateFilter()
        {
            DateTime today = DateTime.Today;

            if (radBtnToday.Checked)
            {
                return " and ClassDate = '" + today.ToString("yyyy-MM-dd") + "'";
            }

            else if (radBtnWeek.Checked)
            {
                DateTime nextWeek = today.AddDays(7);
                return " and ClassDate >= '" + today.ToString("yyyy-MM-dd") + "'" +
                    " and ClassDate < '" + nextWeek.ToString("yyyy-MM-dd") + "'";
            }

            else if (radBtnMonth.Checked)
            {
                DateTime nextMonth = today.AddMonths(1);
                return " and ClassDate >= '" + today.ToString("yyyy-MM-dd") + "'" +
                    " and ClassDate < '" + nextMonth.ToString("yyyy-MM-dd") + "'";
            }

            return "";
        }


        private void radBtnToday_CheckedChanged(object sender, EventArgs e)
        {
            refreshDateData();
        }

        private void radBtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            refreshDateData();
        }

        private void radBtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            refreshDateData();
        }
    }
}
