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
    public partial class ServiceControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='desktop_p3l';username=root;password=");

        public ServiceControl()
        {
            InitializeComponent();
        }

        private void ServiceControl_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from services";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetInt32(3).ToString());
                listView1.Items.Add(lv);
            }
            Reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textServiceID.Text = String.Empty;
            textServiceName.Text = String.Empty;
            textPrice.Text = String.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textServiceName.Text == "" || textPrice.Text == "")
            {
                MessageBox.Show("Please fill all the box, beside Service ID.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO `services` (`employee_id`, `service_name`, `service_price`, `CREATED_AT`, `UPDATE_AT`, `DELETED_AT`) VALUES('" + Form_Main.id + "', '" + textServiceName.Text + "', '" + float.Parse(textPrice.Text) + "', current_timestamp(), current_timestamp(), NULL)";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Service Added! Please refresh the list.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textServiceName.Text == "")
            {
                MessageBox.Show("Please fill the Service Name box.");
            }
            else
            {
                con.Open();
                string sql = "SELECT * FROM `services` WHERE `services`.`service_name` ='" + textServiceName.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                if (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetInt32(3).ToString());
                    listView1.Items.Add(lv);
                }
                else
                {
                    MessageBox.Show("Service not found!");
                }

                Reader.Close();
                cmd.Dispose();
                con.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textServiceID.Text == "")
            {
                MessageBox.Show("Please click the service that you want to update on the list.");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE `services` SET `employee_id` = '" + Form_Main.id + "' , `service_name` = '" + textServiceName.Text + "', `service_price`= '" + float.Parse(textPrice.Text) + "', `UPDATE_AT`= current_timestamp(), `DELETED_AT` = NULL WHERE `service_id`= '" + textServiceID.Text + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Service Updated! Please refresh the list.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textServiceID.Text == "")
            {
                MessageBox.Show("Please click the service that you want to delete on the list.");
            }
            else
            {
                if (MessageBox.Show("Are you Sure?", "Delete Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM `services` WHERE `services`.`service_id` ='" + textServiceID.Text + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Service Deleted! Please refresh the list.");

                    textServiceID.Text = String.Empty;
                    textServiceName.Text = String.Empty;
                    textPrice.Text = String.Empty;
                }
            }
        }

        private void textProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textServiceID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textServiceName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
