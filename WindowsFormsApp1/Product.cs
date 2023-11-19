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
    public partial class Product : Form
    {
        // public event EventHandler ProductDataChanged;

        public Product()
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
            cmd.CommandText = "SELECT id as ID ,name as Name,code as Code ,harga as Harga FROM product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_product.DataSource = dt;
            conn.Close();
        }
        private void button_simpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO product (code, name, harga) VALUES('" +
               textBox_codeProduct.Text + "','" +
               textBox_nameProduct.Text + "','" +
               textBox_hargaProduct.Text+ "')";

            cmd.ExecuteNonQuery();
            conn.Close();

            // Clear the textboxes after inserting data
            textBox_codeProduct.Text = "";
            textBox_nameProduct.Text = "";
            textBox_hargaProduct.Text = "";

            display_data();
            MessageBox.Show("Simpan data berhasil!!");

            // Trigger the event to notify subscribers (e.g., Home form)
            // ProductDataChanged?.Invoke(this, EventArgs.Empty);
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedRows.Count > 0) // Pastikan ada baris yang dipilih
            {
                int selectedRowIndex = dataGridView_product.SelectedRows[0].Index;
                int selectedId = Convert.ToInt32(dataGridView_product.Rows[selectedRowIndex].Cells[0].Value);

                SqlConnection conn = koneksi();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE product SET "
                    + "code='" + textBox_codeProduct.Text
                    + "', name='" + textBox_nameProduct.Text
                    + "', harga='" + textBox_hargaProduct.Text
                    + "'WHERE id=" + selectedId;
                cmd.ExecuteNonQuery();
                conn.Close();

                // Clear the textboxes after inserting data
                textBox_codeProduct.Text = "";
                textBox_nameProduct.Text = "";
                textBox_hargaProduct.Text = "";

                display_data();
                MessageBox.Show("Update data berhasil!!");
                // Trigger the event to notify subscribers (e.g., Home form)
                //ProductDataChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedRows.Count > 0) // Pastikan ada baris yang dipilih
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView_product.SelectedRows[0].Index;
                    int selectedId = Convert.ToInt32(dataGridView_product.Rows[selectedRowIndex].Cells[0].Value);

                    SqlConnection conn = koneksi();
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM product WHERE id= " + selectedId;
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
        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menampilkan form induk saat form User ditutup
            this.Owner.Show();
        }

        private void button_pilihProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedRows.Count > 0) // Check if a row is selected
            {
                int selectedRowIndex = dataGridView_product.SelectedRows[0].Index;

                // Retrieve data from the selected row
                string code = dataGridView_product.Rows[selectedRowIndex].Cells["Code"].Value.ToString();
                string name = dataGridView_product.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
                string harga = dataGridView_product.Rows[selectedRowIndex].Cells["Harga"].Value.ToString();

                // Display data in the textboxes and radio buttons
                textBox_codeProduct.Text = code;
                textBox_nameProduct.Text = name;
                textBox_hargaProduct.Text = harga;

                // Show selectedRowIndex in a MessageBox
                MessageBox.Show($"Pilih index ke-{selectedRowIndex}");
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu!");
            }
        }
    }
}
