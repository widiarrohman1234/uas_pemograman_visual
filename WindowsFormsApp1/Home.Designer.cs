namespace WindowsFormsApp1
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_menuUser = new System.Windows.Forms.Button();
            this.button_menuProduct = new System.Windows.Forms.Button();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.label_listUser = new System.Windows.Forms.Label();
            this.label_listProduct = new System.Windows.Forms.Label();
            this.comboBox_listUser = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_uasDataSet1 = new WindowsFormsApp1.project_uasDataSet1();
            this.comboBox_listProduct = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_uasDataSet2 = new WindowsFormsApp1.project_uasDataSet2();
            this.project_uasDataSet = new WindowsFormsApp1.project_uasDataSet();
            this.projectuasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectuasDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1.project_uasDataSet1TableAdapters.userTableAdapter();
            this.productTableAdapter = new WindowsFormsApp1.project_uasDataSet2TableAdapters.productTableAdapter();
            this.button_pilihProduct = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.dateTimePicker_dateTransx = new System.Windows.Forms.DateTimePicker();
            this.label_dateTransx = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.projectuasDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new WindowsFormsApp1.project_uasDataSet2TableAdapters.TableAdapterManager();
            this.productTableAdapter1 = new WindowsFormsApp1.project_uasDataSet2TableAdapters.productTableAdapter();
            this.project_uasDataSet21 = new WindowsFormsApp1.project_uasDataSet2();
            this.project_uasDataSet11 = new WindowsFormsApp1.project_uasDataSet1();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // button_menuUser
            // 
            this.button_menuUser.Location = new System.Drawing.Point(108, 42);
            this.button_menuUser.Margin = new System.Windows.Forms.Padding(4);
            this.button_menuUser.Name = "button_menuUser";
            this.button_menuUser.Size = new System.Drawing.Size(131, 28);
            this.button_menuUser.TabIndex = 3;
            this.button_menuUser.Text = "Menu User";
            this.button_menuUser.UseVisualStyleBackColor = true;
            this.button_menuUser.Click += new System.EventHandler(this.button_menuUser_Click);
            // 
            // button_menuProduct
            // 
            this.button_menuProduct.Location = new System.Drawing.Point(108, 87);
            this.button_menuProduct.Margin = new System.Windows.Forms.Padding(4);
            this.button_menuProduct.Name = "button_menuProduct";
            this.button_menuProduct.Size = new System.Drawing.Size(131, 28);
            this.button_menuProduct.TabIndex = 4;
            this.button_menuProduct.Text = "Menu Product";
            this.button_menuProduct.UseVisualStyleBackColor = true;
            this.button_menuProduct.Click += new System.EventHandler(this.button_menuProduct_Click);
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(33, 167);
            this.dataGridView_transaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.RowHeadersWidth = 51;
            this.dataGridView_transaksi.Size = new System.Drawing.Size(973, 365);
            this.dataGridView_transaksi.TabIndex = 5;
            // 
            // label_listUser
            // 
            this.label_listUser.AutoSize = true;
            this.label_listUser.Location = new System.Drawing.Point(331, 22);
            this.label_listUser.Name = "label_listUser";
            this.label_listUser.Size = new System.Drawing.Size(59, 16);
            this.label_listUser.TabIndex = 6;
            this.label_listUser.Text = "List User";
            // 
            // label_listProduct
            // 
            this.label_listProduct.AutoSize = true;
            this.label_listProduct.Location = new System.Drawing.Point(552, 22);
            this.label_listProduct.Name = "label_listProduct";
            this.label_listProduct.Size = new System.Drawing.Size(76, 16);
            this.label_listProduct.TabIndex = 7;
            this.label_listProduct.Text = "List Product";
            // 
            // comboBox_listUser
            // 
            this.comboBox_listUser.DataSource = this.userBindingSource2;
            this.comboBox_listUser.DisplayMember = "name";
            this.comboBox_listUser.FormattingEnabled = true;
            this.comboBox_listUser.Location = new System.Drawing.Point(334, 45);
            this.comboBox_listUser.Name = "comboBox_listUser";
            this.comboBox_listUser.Size = new System.Drawing.Size(202, 24);
            this.comboBox_listUser.TabIndex = 8;
            this.comboBox_listUser.ValueMember = "id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.project_uasDataSet1;
            // 
            // project_uasDataSet1
            // 
            this.project_uasDataSet1.DataSetName = "project_uasDataSet1";
            this.project_uasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_listProduct
            // 
            this.comboBox_listProduct.DataSource = this.productBindingSource1;
            this.comboBox_listProduct.DisplayMember = "code";
            this.comboBox_listProduct.FormattingEnabled = true;
            this.comboBox_listProduct.Location = new System.Drawing.Point(544, 45);
            this.comboBox_listProduct.Name = "comboBox_listProduct";
            this.comboBox_listProduct.Size = new System.Drawing.Size(201, 24);
            this.comboBox_listProduct.TabIndex = 9;
            this.comboBox_listProduct.ValueMember = "id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.project_uasDataSet2;
            // 
            // project_uasDataSet2
            // 
            this.project_uasDataSet2.DataSetName = "project_uasDataSet2";
            this.project_uasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_uasDataSet
            // 
            this.project_uasDataSet.DataSetName = "project_uasDataSet";
            this.project_uasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectuasDataSetBindingSource
            // 
            this.projectuasDataSetBindingSource.DataSource = this.project_uasDataSet;
            this.projectuasDataSetBindingSource.Position = 0;
            // 
            // projectuasDataSetBindingSource1
            // 
            this.projectuasDataSetBindingSource1.DataSource = this.project_uasDataSet;
            this.projectuasDataSetBindingSource1.Position = 0;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button_pilihProduct
            // 
            this.button_pilihProduct.Location = new System.Drawing.Point(648, 87);
            this.button_pilihProduct.Name = "button_pilihProduct";
            this.button_pilihProduct.Size = new System.Drawing.Size(97, 29);
            this.button_pilihProduct.TabIndex = 17;
            this.button_pilihProduct.Text = "Pilih";
            this.button_pilihProduct.UseVisualStyleBackColor = true;
            this.button_pilihProduct.Click += new System.EventHandler(this.button_pilihProduct_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.Location = new System.Drawing.Point(544, 88);
            this.button_hapus.Margin = new System.Windows.Forms.Padding(4);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(97, 28);
            this.button_hapus.TabIndex = 16;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Location = new System.Drawing.Point(439, 88);
            this.button_ubah.Margin = new System.Windows.Forms.Padding(4);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(97, 28);
            this.button_ubah.TabIndex = 15;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(334, 88);
            this.button_simpan.Margin = new System.Windows.Forms.Padding(4);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(97, 28);
            this.button_simpan.TabIndex = 14;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // dateTimePicker_dateTransx
            // 
            this.dateTimePicker_dateTransx.Location = new System.Drawing.Point(751, 45);
            this.dateTimePicker_dateTransx.Name = "dateTimePicker_dateTransx";
            this.dateTimePicker_dateTransx.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker_dateTransx.TabIndex = 18;
            // 
            // label_dateTransx
            // 
            this.label_dateTransx.AutoSize = true;
            this.label_dateTransx.Location = new System.Drawing.Point(748, 22);
            this.label_dateTransx.Name = "label_dateTransx";
            this.label_dateTransx.Size = new System.Drawing.Size(74, 16);
            this.label_dateTransx.TabIndex = 19;
            this.label_dateTransx.Text = "Date transx";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh.Location = new System.Drawing.Point(751, 87);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(97, 29);
            this.button_refresh.TabIndex = 20;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // projectuasDataSet1BindingSource
            // 
            this.projectuasDataSet1BindingSource.DataSource = this.project_uasDataSet1;
            this.projectuasDataSet1BindingSource.Position = 0;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.projectuasDataSet1BindingSource;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.project_uasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // project_uasDataSet21
            // 
            this.project_uasDataSet21.DataSetName = "project_uasDataSet2";
            this.project_uasDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_uasDataSet11
            // 
            this.project_uasDataSet11.DataSetName = "project_uasDataSet1";
            this.project_uasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "user";
            this.userBindingSource2.DataSource = this.project_uasDataSet1;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "product";
            this.productBindingSource1.DataSource = this.project_uasDataSet2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 581);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_dateTransx);
            this.Controls.Add(this.dateTimePicker_dateTransx);
            this.Controls.Add(this.button_pilihProduct);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_ubah);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.comboBox_listProduct);
            this.Controls.Add(this.comboBox_listUser);
            this.Controls.Add(this.label_listProduct);
            this.Controls.Add(this.label_listUser);
            this.Controls.Add(this.dataGridView_transaksi);
            this.Controls.Add(this.button_menuProduct);
            this.Controls.Add(this.button_menuUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectuasDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_uasDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_menuUser;
        private System.Windows.Forms.Button button_menuProduct;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.Label label_listUser;
        private System.Windows.Forms.Label label_listProduct;
        private System.Windows.Forms.ComboBox comboBox_listUser;
        private System.Windows.Forms.ComboBox comboBox_listProduct;
        private System.Windows.Forms.BindingSource projectuasDataSetBindingSource;
        private project_uasDataSet project_uasDataSet;
        private System.Windows.Forms.BindingSource projectuasDataSetBindingSource1;
        private project_uasDataSet1 project_uasDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private project_uasDataSet1TableAdapters.userTableAdapter userTableAdapter;
        private project_uasDataSet2 project_uasDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private project_uasDataSet2TableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Button button_pilihProduct;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateTransx;
        private System.Windows.Forms.Label label_dateTransx;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource projectuasDataSet1BindingSource;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private project_uasDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private project_uasDataSet2TableAdapters.productTableAdapter productTableAdapter1;
        private project_uasDataSet2 project_uasDataSet21;
        private project_uasDataSet1 project_uasDataSet11;
    }
}