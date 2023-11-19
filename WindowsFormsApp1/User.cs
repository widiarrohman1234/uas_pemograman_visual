using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            display_data();
        }

        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=ASUS416EA;Initial Catalog=project_uas;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }

        public void display_data()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id as ID ,name as Name,email as Email ,gender as Gender " +
                "FROM [user]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_user.DataSource = dt;
            conn.Close();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO [user] (name, email, gender) VALUES('" +
               textBox_name.Text + "','" +
               textBox_email.Text + "','" +
               (radioButton_male.Checked ? "Male" : "Female") + "')";

            cmd.ExecuteNonQuery();
            conn.Close();

            textBox_name.Text = "";
            textBox_email.Text = "";
            radioButton_male.Text = "";
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            // Optionally, you can set the Text property to an empty string as well
            radioButton_male.Text = "Male";
            radioButton_female.Text = "Female";


            display_data();
            MessageBox.Show("Simpan data berhasil!!");
        }
        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (dataGridView_user.SelectedRows.Count > 0) // Pastikan ada baris yang dipilih
            {
                int selectedRowIndex = dataGridView_user.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView_user.Rows[selectedRowIndex].Cells[0].Value);

                SqlConnection conn = koneksi();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE [user] SET "
                    + "name='" + textBox_name.Text
                    + "', email='" + textBox_email.Text
                    + "', gender='" + (radioButton_male.Checked ? "Male" : "Female")
                    + "'WHERE id=" + selectedId;
                cmd.ExecuteNonQuery();
                conn.Close();

                textBox_name.Text = "";
                textBox_email.Text = "";
                radioButton_male.Text = "";
                radioButton_male.Checked = false;
                radioButton_female.Checked = false;
                // Optionally, you can set the Text property to an empty string as well
                radioButton_male.Text = "Male";
                radioButton_female.Text = "Female";

                display_data();
                MessageBox.Show("Update data berhasil!!");
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (dataGridView_user.SelectedRows.Count > 0) // Pastikan ada baris yang dipilih
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                { 
                    int selectedRowIndex = dataGridView_user.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView_user.Rows[selectedRowIndex].Cells[0].Value);

                SqlConnection conn = koneksi();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM [user] WHERE id= "+ selectedId;
                cmd.ExecuteNonQuery();
                conn.Close();
                display_data();
                MessageBox.Show("Hapus data berhasil!!");
                }
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
                
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menampilkan form induk saat form User ditutup
            this.Owner.Show();
        }

        private void button_pilih_Click(object sender, EventArgs e)
        {
         
            if (dataGridView_user.SelectedRows.Count > 0) // Check if a row is selected
            {
                int selectedRowIndex = dataGridView_user.SelectedRows[0].Index;

                // Retrieve data from the selected row
                string name = dataGridView_user.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
                string email = dataGridView_user.Rows[selectedRowIndex].Cells["Email"].Value.ToString();
                string gender = dataGridView_user.Rows[selectedRowIndex].Cells["Gender"].Value.ToString();

                // Display data in the textboxes and radio buttons
                textBox_name.Text = name;
                textBox_email.Text = email;
                if (gender == "Male")
                    radioButton_male.Checked = true;
                else
                    radioButton_female.Checked = true;

                // Show selectedRowIndex in a MessageBox
                MessageBox.Show($"Pilih index ke-{selectedRowIndex}");
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
        }


        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
