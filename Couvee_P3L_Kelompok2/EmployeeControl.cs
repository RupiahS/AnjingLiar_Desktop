using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Couvee_P3L_Kelompok2
{
    public partial class EmployeeControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='desktop_p3l';username=root;password=");

        public EmployeeControl()
        {
            InitializeComponent();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEmployeeID.Text = String.Empty;
            textRoleID.Text = String.Empty;
            textEmployeeName.Text = String.Empty;
            textAddress.Text = String.Empty;
            textPhoneNumber.Text = String.Empty;
            textBirth.Text = String.Empty;
            textUsername.Text = String.Empty;
            textPassword.Text = String.Empty;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from employees";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetInt32(1).ToString());
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetInt32(4).ToString());
                lv.SubItems.Add(Reader.GetDateTime(5).ToString(@"yyyy-MM-dd"));
                lv.SubItems.Add(Reader.GetString(6));
                lv.SubItems.Add(Reader.GetString(7));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textRoleID.Text=="" || textEmployeeName.Text == "" || textAddress.Text == "" || textPhoneNumber.Text == "" || textBirth.Text == "" || textUsername.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("Please fill all the box, beside Employee ID.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `employees` (`role_id`, `employee_name`, `employee_address`, `employee_phoneno`, `employee_birth`, `username`, `password` , `CREATED_AT`, `UPDATED_AT`, `DELETED_AT`) VALUES('" + Convert.ToInt32(textRoleID.Text) + "', '" + textEmployeeName.Text + "', '" + textAddress.Text + "', '" + Convert.ToInt32(textPhoneNumber.Text) + "', '" + textBirth.Text + "', '" + textUsername.Text + "', '" + textPassword.Text + "', current_timestamp(), current_timestamp(), NULL)";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Employee Added! Please refresh the list.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textEmployeeName.Text == "")
            {
                MessageBox.Show("Please fill the Employee Name box.");
            }
            else
            {

                con.Open();
                string sql = "SELECT * FROM `employees` WHERE `employees`.`employee_name` ='" + textEmployeeName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                if (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                    lv.SubItems.Add(Reader.GetInt32(1).ToString());
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    lv.SubItems.Add(Reader.GetInt32(4).ToString());
                    lv.SubItems.Add(Reader.GetDateTime(5).ToString(@"yyyy-MM-dd"));
                    lv.SubItems.Add(Reader.GetString(6));
                    lv.SubItems.Add(Reader.GetString(7));
                    listView1.Items.Add(lv);
                }
                else
                {
                    MessageBox.Show("Employee not found!");
                }

                Reader.Close();
                cmd.Dispose();
                con.Close();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            if (textEmployeeID.Text=="")
            {
                MessageBox.Show("Please click the employee that you want to update on the list.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE `employees` SET `employee_id` = '" + Form_Main.id + "',`role_id` = '" + Convert.ToInt32(textRoleID.Text) + "',  `employee_name` = '" + textEmployeeName.Text + "', `employee_address`= '" + textAddress.Text + "', `employee_phoneno`= '" + Convert.ToInt32(textPhoneNumber.Text) + "', `employee_birth`= '" + textBirth.Text + "', `username`= '" + textUsername.Text + "', `password`= '" + textPassword.Text + "',`UPDATE_AT`= current_timestamp(), `DELETED_AT` = NULL WHERE `employee_id`= '" + textEmployeeID.Text + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Service Updated! Please refresh the list.");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textEmployeeID.Text == "")
            {
                MessageBox.Show("Please click the employee that you want to delete on the list.");
            }
            else
            {
                if (MessageBox.Show("Are you Sure?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM `employees` WHERE `employees`.`employee_id` ='" + textEmployeeID.Text + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Employee Deleted! Please refresh the list.");

                    textEmployeeID.Text = String.Empty;
                    textRoleID.Text = String.Empty;
                    textEmployeeName.Text = String.Empty;
                    textAddress.Text = String.Empty;
                    textPhoneNumber.Text = String.Empty;
                    textBirth.Text = String.Empty;
                    textUsername.Text = String.Empty;
                    textPassword.Text = String.Empty;
                }
            }
            //////////////////KALAU MAU BIKIN LOG, SEBELUM QUERY DI SAVE 'DELETED_AT' KE LOG
        }

        private void textEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textEmployeeID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textRoleID.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEmployeeName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textPhoneNumber.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBirth.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textUsername.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textPassword.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }
    }
}
