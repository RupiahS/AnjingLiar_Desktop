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
    public partial class CustomerControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='desktop_p3l';username=root;password=");

        public CustomerControl()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textCustomerID.Text = String.Empty;
            textCustomerName.Text = String.Empty;
            textAddress.Text = String.Empty;
            textPhoneNumber.Text = String.Empty;
            textBirth.Text = String.Empty;
            textMembership.Text = String.Empty;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from customers";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetInt32(4).ToString());
                lv.SubItems.Add(Reader.GetDateTime(5).ToString(@"yyyy-MM-dd"));
                lv.SubItems.Add(Reader.GetString(6));
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (textCustomerName.Text == "" || textAddress.Text == "" || textPhoneNumber.Text == "" || textBirth.Text == "" || textMembership.Text == "")
            {
                MessageBox.Show("Please fill all the box, beside Customer ID.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `customers` (`employee_id`, `customer_name`, `customer_address`, `customer_phoneno`, `customer_birth`, `customer_membership`, `CREATED_AT`, `UPDATE_AT`, `DELETED_AT`) VALUES('" + Form_Main.id + "', '" + textCustomerName.Text + "', '" + textAddress.Text + "', '" + Convert.ToInt32(textPhoneNumber.Text) + "', '" + textBirth.Text + "', '" + textMembership.Text + "', current_timestamp(), current_timestamp(), NULL)";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Employee Added! Please refresh the list.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textCustomerID.Text == "")
            {
                MessageBox.Show("Please click the customer that you want to update on the list.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE `customers` SET `customer_id` = '" + textCustomerID.Text + "',  `customer_name` = '" + textCustomerName.Text + "', `customer_address`= '" + textAddress.Text + "', `customer_phoneno`= '" + Convert.ToInt32(textPhoneNumber.Text) + "', `customer_birth`= '" + textBirth.Text + "', `customer_membership`= '" + textMembership.Text + "', `UPDATE_AT`= current_timestamp() WHERE `customer_id`= '" + textCustomerID.Text + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Service Updated! Please refresh the list.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textCustomerName.Text == "")
            {
                MessageBox.Show("Please fill the Customer Name box.");
            }
            else
            {
                con.Open();
                string sql = "SELECT * FROM `customers` WHERE `customers`.`customer_name` ='" + textCustomerName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                if (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    lv.SubItems.Add(Reader.GetInt32(4).ToString());
                    lv.SubItems.Add(Reader.GetDateTime(5).ToString(@"yyyy-MM-dd"));
                    lv.SubItems.Add(Reader.GetString(6));
                    listView1.Items.Add(lv);
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }

                Reader.Close();
                cmd.Dispose();
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textCustomerID.Text == "")
            {
                MessageBox.Show("Please click the customer that you want to delete on the list.");
            }
            else
            {
                if (MessageBox.Show("Are you Sure?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM `customers` WHERE `customers`.`customer_id` ='" + textCustomerID.Text + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Customer Deleted! Please refresh the list.");

                    textCustomerID.Text = String.Empty;
                    textCustomerName.Text = String.Empty;
                    textPhoneNumber.Text = String.Empty;
                    textBirth.Text = String.Empty;
                    textMembership.Text = String.Empty;
                }
            }
            //////////////////KALAU MAU BIKIN LOG, SEBELUM QUERY DI SAVE 'DELETED_AT' KE LOG
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textCustomerID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textCustomerName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textAddress.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textPhoneNumber.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBirth.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textMembership.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
