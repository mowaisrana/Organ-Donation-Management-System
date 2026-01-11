using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrganDonationApplication_1._0
{
    public partial class UpDonate : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-7EEN2GJ\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=true");

        public UpDonate()
        {
            InitializeComponent();
            displayRequestData();
        }

        public void displayRequestData()
        {
            try
            {
                connect.Open();
                string query = "select RequestID, RequestType, OrganName, BloodGroup, Status, CreatedAt from Requests;";
                SqlDataAdapter sda = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                up_dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void up_press_btn_Click(object sender, EventArgs e)
        {
            if (up_bloodgroup_cb.Text == "" || up_organname_cb.Text == "" || up_type_cb.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                

                try
                {
                    string insertdata = "INSERT INTO Requests (BloodGroup, OrganName, RequestType) " +
                                        "VALUES (@Bloodgroup, @Organname, @Requesttype)";

                    using (SqlCommand cmd2 = new SqlCommand(insertdata, connect))
                    {
                        cmd2.Parameters.AddWithValue("@Organname", up_organname_cb.Text);
                        cmd2.Parameters.AddWithValue("@Bloodgroup", up_bloodgroup_cb.Text);
                        cmd2.Parameters.AddWithValue("@Requesttype", up_type_cb.Text);

                        // Log the SQL command and parameters for debugging
                        Console.WriteLine("Executing SQL: " + insertdata);
                        Console.WriteLine("Parameters:");
                        Console.WriteLine("@Organname: " + up_organname_cb.Text);
                        Console.WriteLine("@Bloodgroup: " + up_bloodgroup_cb.Text);
                        Console.WriteLine("@Requesttype: " + up_type_cb.Text);

                        cmd2.ExecuteNonQuery();

                        displayRequestData();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayRequestData(); // Refresh the grid view with the latest data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
