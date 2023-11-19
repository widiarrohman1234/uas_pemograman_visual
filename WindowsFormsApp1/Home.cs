using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            display_data();
            // RefreshProductComboBox();
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

            cmd.CommandText = "SELECT t.id as ID, u.name AS Username, u.email AS Email, " +
                 "p.name AS Product_Name, p.code AS Product_Code, " +
                 "p.harga AS Harga, t.date_trx AS Date_Transaksi " +
                 "FROM [tranx] AS t " +
                 "INNER JOIN product AS p ON t.id_product = p.id " +
                 "INNER JOIN [user] AS u ON t.id_user = u.id";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_transaksi.DataSource = dt;
            conn.Close();
        }

        private void button_menuProduct_Click(object sender, EventArgs e)
        {
            Product productPage = new Product();
            productPage.Owner = this;

            // Menyembunyikan form saat ini
            this.Hide();

            // Membuka form User sebagai dialog
            DialogResult result = productPage.ShowDialog();

            // Menampilkan kembali form saat ini setelah form User ditutup
            this.Show();
        }

        private void button_menuUser_Click(object sender, EventArgs e)
        {
            // Membuat objek form User dan menetapkan form induk
            User userPage = new User();
            userPage.Owner = this;

            // Menyembunyikan form saat ini
            this.Hide();

            // Membuka form User sebagai dialog
            DialogResult result = userPage.ShowDialog();

            // Menampilkan kembali form saat ini setelah form User ditutup
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_uasDataSet2.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.project_uasDataSet2.product);
            // TODO: This line of code loads data into the 'project_uasDataSet1.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.project_uasDataSet1.user);

            // Subscribe to the ProductDataChanged event
            // Product productPage = new Product();
            // productPage.ProductDataChanged += ProductPage_ProductDataChanged;
        }
       /* private void ProductPage_ProductDataChanged(object sender, EventArgs e)
        {
            // Refresh data in comboBox_listProduct
            // RefreshProductComboBox();
        }*/
        private DataTable GetDataForProductComboBox()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = koneksi())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id, code FROM Product", conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (logging, showing error messages, etc.)
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        /*private void RefreshProductComboBox()
        {
            // Assuming GetDataForProductComboBox returns a DataTable with columns "ProductId" and "ProductName"
            DataTable productData = GetDataForProductComboBox();

            // Bind the DataTable to the comboBox_listProduct
            comboBox_listProduct.DataSource = productData;
            comboBox_listProduct.DisplayMember = "Code";  // Change to your actual display member column
            comboBox_listProduct.ValueMember = "Id";      // Change to your actual value member column
        }*/
        private void button_simpan_Click(object sender, EventArgs e)
        {

            // Check if both user and product are selected
            if (comboBox_listUser.SelectedItem != null && comboBox_listProduct.SelectedItem != null)
            {
                // Get the selected id_user and id_product
                int idUser = (int)comboBox_listUser.SelectedValue;
                int idProduct = (int)comboBox_listProduct.SelectedValue;
                // Get the selected date from dateTimePicker_dateTransx
                DateTime dateTransx = dateTimePicker_dateTransx.Value;

                // Now, you can use these ids in your INSERT query
                SqlConnection conn = koneksi();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "INSERT INTO tranx (id_user, id_product, date_trx) VALUES(@idUser, @idProduct, @dateTransx)";
                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@idProduct", idProduct);
                cmd.Parameters.AddWithValue("@dateTransx", dateTransx);
                cmd.ExecuteNonQuery();
                conn.Close();
                display_data();
                MessageBox.Show("Simpan data berhasil!!");
            }
            else
            {
                MessageBox.Show("Please select both user and product before saving.");
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            // Check if both user and product are selected
            if (comboBox_listUser.SelectedItem != null && comboBox_listProduct.SelectedItem != null)
            {
                // Get the selected id_user and id_product
                int idUser = (int)comboBox_listUser.SelectedValue;
                int idProduct = (int)comboBox_listProduct.SelectedValue;

                // Check if a row is selected in the dataGridView_transaksi
                if (dataGridView_transaksi.SelectedRows.Count > 0)
                {
                    // Get the selected row index
                    int selectedRowIndex = dataGridView_transaksi.SelectedRows[0].Index;

                    // Get the value of the "Date_Transaksi" column for the selected row
                    string idTransaksi = dataGridView_transaksi.Rows[selectedRowIndex].Cells["Id"].Value.ToString();

                    // Now, you can use these values in your UPDATE query
                    SqlConnection conn = koneksi();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = $"UPDATE tranx SET id_user = {idUser}, id_product = {idProduct} WHERE id = '{idTransaksi}'";

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    display_data();
                    MessageBox.Show("Update data berhasil!!");
                }
                else
                {
                    MessageBox.Show("Please select a row in the transaction data grid before updating.");
                }
            }
            else
            {
                MessageBox.Show("Please select both user and product before updating.");
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the dataGridView_transaksi
            if (dataGridView_transaksi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Check if the user clicked "Yes"
                if (result == DialogResult.Yes)
                {
                    // Get the selected row index
                    int selectedRowIndex = dataGridView_transaksi.SelectedRows[0].Index;

                    // Get the value of the "Id" column for the selected row
                    string idTransaksi = dataGridView_transaksi.Rows[selectedRowIndex].Cells["Id"].Value.ToString();
                    // Now, you can use this value in your DELETE query
                    SqlConnection conn = koneksi();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = $"DELETE FROM tranx WHERE id = '{idTransaksi}'";

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    display_data();
                    MessageBox.Show("Hapus data berhasil!!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the transaction data grid before deleting.");
            }
        }

        private void button_pilihProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_transaksi.SelectedRows.Count > 0) // Check if a row is selected
            {
                int selectedRowIndex = dataGridView_transaksi.SelectedRows[0].Index;

                // Get values from the selected row
                string username = dataGridView_transaksi.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
                string productName = dataGridView_transaksi.Rows[selectedRowIndex].Cells["Product_Name"].Value.ToString();
                DateTime dateTransaksi = Convert.ToDateTime(dataGridView_transaksi.Rows[selectedRowIndex].Cells["Date_Transaksi"].Value);

                // Set values in the controls
                comboBox_listUser.Text = username;
                comboBox_listProduct.Text = productName;
                dateTimePicker_dateTransx.Value = dateTransaksi;


                // Show selectedRowIndex in a MessageBox
                MessageBox.Show($"Pilih index ke-{selectedRowIndex}");
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            // Refresh data for comboBox_listUser
            this.userTableAdapter.Fill(this.project_uasDataSet1.user);

            // Refresh data for comboBox_listProduct
            this.productTableAdapter.Fill(this.project_uasDataSet2.product);

        }

    }
}
