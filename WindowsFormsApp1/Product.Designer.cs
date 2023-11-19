namespace WindowsFormsApp1
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_code = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_harga = new System.Windows.Forms.Label();
            this.textBox_codeProduct = new System.Windows.Forms.TextBox();
            this.textBox_nameProduct = new System.Windows.Forms.TextBox();
            this.textBox_hargaProduct = new System.Windows.Forms.TextBox();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_pilihProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(47, 48);
            this.label_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(40, 16);
            this.label_code.TabIndex = 0;
            this.label_code.Text = "Code";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(47, 95);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(51, 145);
            this.label_harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(45, 16);
            this.label_harga.TabIndex = 2;
            this.label_harga.Text = "Harga";
            // 
            // textBox_codeProduct
            // 
            this.textBox_codeProduct.Location = new System.Drawing.Point(149, 48);
            this.textBox_codeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_codeProduct.Name = "textBox_codeProduct";
            this.textBox_codeProduct.Size = new System.Drawing.Size(217, 22);
            this.textBox_codeProduct.TabIndex = 3;
            // 
            // textBox_nameProduct
            // 
            this.textBox_nameProduct.Location = new System.Drawing.Point(149, 91);
            this.textBox_nameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nameProduct.Name = "textBox_nameProduct";
            this.textBox_nameProduct.Size = new System.Drawing.Size(217, 22);
            this.textBox_nameProduct.TabIndex = 4;
            // 
            // textBox_hargaProduct
            // 
            this.textBox_hargaProduct.Location = new System.Drawing.Point(149, 142);
            this.textBox_hargaProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hargaProduct.Name = "textBox_hargaProduct";
            this.textBox_hargaProduct.Size = new System.Drawing.Size(217, 22);
            this.textBox_hargaProduct.TabIndex = 5;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(19, 224);
            this.dataGridView_product.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersWidth = 51;
            this.dataGridView_product.Size = new System.Drawing.Size(977, 316);
            this.dataGridView_product.TabIndex = 6;
            // 
            // button_hapus
            // 
            this.button_hapus.Location = new System.Drawing.Point(261, 188);
            this.button_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(97, 28);
            this.button_hapus.TabIndex = 12;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Location = new System.Drawing.Point(156, 188);
            this.button_ubah.Margin = new System.Windows.Forms.Padding(4);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(97, 28);
            this.button_ubah.TabIndex = 11;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(51, 188);
            this.button_simpan.Margin = new System.Windows.Forms.Padding(4);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(97, 28);
            this.button_simpan.TabIndex = 10;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_pilihProduct
            // 
            this.button_pilihProduct.Location = new System.Drawing.Point(365, 187);
            this.button_pilihProduct.Name = "button_pilihProduct";
            this.button_pilihProduct.Size = new System.Drawing.Size(97, 29);
            this.button_pilihProduct.TabIndex = 13;
            this.button_pilihProduct.Text = "Pilih";
            this.button_pilihProduct.UseVisualStyleBackColor = true;
            this.button_pilihProduct.Click += new System.EventHandler(this.button_pilihProduct_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_pilihProduct);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_ubah);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.dataGridView_product);
            this.Controls.Add(this.textBox_hargaProduct);
            this.Controls.Add(this.textBox_nameProduct);
            this.Controls.Add(this.textBox_codeProduct);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_code);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.TextBox textBox_codeProduct;
        private System.Windows.Forms.TextBox textBox_nameProduct;
        private System.Windows.Forms.TextBox textBox_hargaProduct;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_pilihProduct;
    }
}