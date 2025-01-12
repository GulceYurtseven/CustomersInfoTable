
namespace customers
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox2 = new System.Windows.Forms.TextBox();
            this.birthTextBox3 = new System.Windows.Forms.TextBox();
            this.distTextBox4 = new System.Windows.Forms.TextBox();
            this.genderTextBox5 = new System.Windows.Forms.TextBox();
            this.ageTextBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.YabanciradioButton2 = new System.Windows.Forms.RadioButton();
            this.TRradioButton1 = new System.Windows.Forms.RadioButton();
            this.tabloyuGosterButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.yeniKisiEkleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTOMERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISTRICTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTUMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSet = new customers.denemeDataSet();
            this.cOSTUMERSTableAdapter = new customers.denemeDataSetTableAdapters.COSTUMERSTableAdapter();
            this.temizleButton = new System.Windows.Forms.Button();
            this.istatislikButton = new System.Windows.Forms.Button();
            this.SehirGrafikButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTUMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIRTHDATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DISTRICT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "NATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(15, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "AGE";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(186, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 7;
            // 
            // cityTextBox2
            // 
            this.cityTextBox2.Location = new System.Drawing.Point(186, 89);
            this.cityTextBox2.Name = "cityTextBox2";
            this.cityTextBox2.Size = new System.Drawing.Size(200, 26);
            this.cityTextBox2.TabIndex = 8;
            // 
            // birthTextBox3
            // 
            this.birthTextBox3.Location = new System.Drawing.Point(186, 125);
            this.birthTextBox3.Name = "birthTextBox3";
            this.birthTextBox3.Size = new System.Drawing.Size(200, 26);
            this.birthTextBox3.TabIndex = 9;
            // 
            // distTextBox4
            // 
            this.distTextBox4.Location = new System.Drawing.Point(186, 160);
            this.distTextBox4.Name = "distTextBox4";
            this.distTextBox4.Size = new System.Drawing.Size(200, 26);
            this.distTextBox4.TabIndex = 10;
            // 
            // genderTextBox5
            // 
            this.genderTextBox5.Location = new System.Drawing.Point(186, 196);
            this.genderTextBox5.Name = "genderTextBox5";
            this.genderTextBox5.Size = new System.Drawing.Size(200, 26);
            this.genderTextBox5.TabIndex = 11;
            // 
            // ageTextBox7
            // 
            this.ageTextBox7.Location = new System.Drawing.Point(186, 265);
            this.ageTextBox7.Name = "ageTextBox7";
            this.ageTextBox7.Size = new System.Drawing.Size(200, 26);
            this.ageTextBox7.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.IDlabel);
            this.groupBox1.Controls.Add(this.YabanciradioButton2);
            this.groupBox1.Controls.Add(this.TRradioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageTextBox7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genderTextBox5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.distTextBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.birthTextBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cityTextBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 306);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(19, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Snow;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDlabel.Location = new System.Drawing.Point(190, 19);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(23, 25);
            this.IDlabel.TabIndex = 20;
            this.IDlabel.Text = "0";
            // 
            // YabanciradioButton2
            // 
            this.YabanciradioButton2.AutoSize = true;
            this.YabanciradioButton2.Location = new System.Drawing.Point(256, 232);
            this.YabanciradioButton2.Name = "YabanciradioButton2";
            this.YabanciradioButton2.Size = new System.Drawing.Size(92, 24);
            this.YabanciradioButton2.TabIndex = 15;
            this.YabanciradioButton2.TabStop = true;
            this.YabanciradioButton2.Text = "Yabancı";
            this.YabanciradioButton2.UseVisualStyleBackColor = true;
            // 
            // TRradioButton1
            // 
            this.TRradioButton1.AutoSize = true;
            this.TRradioButton1.Location = new System.Drawing.Point(186, 232);
            this.TRradioButton1.Name = "TRradioButton1";
            this.TRradioButton1.Size = new System.Drawing.Size(55, 24);
            this.TRradioButton1.TabIndex = 14;
            this.TRradioButton1.TabStop = true;
            this.TRradioButton1.Text = "TR";
            this.TRradioButton1.UseVisualStyleBackColor = true;
            // 
            // tabloyuGosterButton
            // 
            this.tabloyuGosterButton.Location = new System.Drawing.Point(19, 3);
            this.tabloyuGosterButton.Name = "tabloyuGosterButton";
            this.tabloyuGosterButton.Size = new System.Drawing.Size(200, 45);
            this.tabloyuGosterButton.TabIndex = 15;
            this.tabloyuGosterButton.Text = "Tabloyu Göster";
            this.tabloyuGosterButton.UseVisualStyleBackColor = true;
            this.tabloyuGosterButton.Click += new System.EventHandler(this.tabloyuGosterButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(19, 106);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(200, 45);
            this.guncelleButton.TabIndex = 16;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click_1);
            // 
            // yeniKisiEkleButton
            // 
            this.yeniKisiEkleButton.Location = new System.Drawing.Point(19, 55);
            this.yeniKisiEkleButton.Name = "yeniKisiEkleButton";
            this.yeniKisiEkleButton.Size = new System.Drawing.Size(200, 45);
            this.yeniKisiEkleButton.TabIndex = 17;
            this.yeniKisiEkleButton.Text = "Yeni Kişi Ekle";
            this.yeniKisiEkleButton.UseVisualStyleBackColor = true;
            this.yeniKisiEkleButton.Click += new System.EventHandler(this.yeniKisiEkleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(19, 160);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(200, 45);
            this.silButton.TabIndex = 18;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.cOSTOMERNAMEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn,
            this.dISTRICTDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.nATIONDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOSTUMERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(928, 290);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 62;
            // 
            // cOSTOMERNAMEDataGridViewTextBoxColumn
            // 
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "COSTOMERNAME";
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "COSTOMERNAME";
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.Name = "cOSTOMERNAMEDataGridViewTextBoxColumn";
            this.cOSTOMERNAMEDataGridViewTextBoxColumn.Width = 182;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.Width = 81;
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            this.bIRTHDATEDataGridViewTextBoxColumn.Width = 137;
            // 
            // dISTRICTDataGridViewTextBoxColumn
            // 
            this.dISTRICTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dISTRICTDataGridViewTextBoxColumn.DataPropertyName = "DISTRICT";
            this.dISTRICTDataGridViewTextBoxColumn.HeaderText = "DISTRICT";
            this.dISTRICTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dISTRICTDataGridViewTextBoxColumn.Name = "dISTRICTDataGridViewTextBoxColumn";
            this.dISTRICTDataGridViewTextBoxColumn.Width = 119;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.Width = 115;
            // 
            // nATIONDataGridViewTextBoxColumn
            // 
            this.nATIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nATIONDataGridViewTextBoxColumn.DataPropertyName = "NATION";
            this.nATIONDataGridViewTextBoxColumn.HeaderText = "NATION";
            this.nATIONDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nATIONDataGridViewTextBoxColumn.Name = "nATIONDataGridViewTextBoxColumn";
            this.nATIONDataGridViewTextBoxColumn.Width = 104;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.Width = 80;
            // 
            // cOSTUMERSBindingSource
            // 
            this.cOSTUMERSBindingSource.DataMember = "COSTUMERS";
            this.cOSTUMERSBindingSource.DataSource = this.denemeDataSetBindingSource;
            // 
            // denemeDataSetBindingSource
            // 
            this.denemeDataSetBindingSource.DataSource = this.denemeDataSet;
            this.denemeDataSetBindingSource.Position = 0;
            // 
            // denemeDataSet
            // 
            this.denemeDataSet.DataSetName = "denemeDataSet";
            this.denemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOSTUMERSTableAdapter
            // 
            this.cOSTUMERSTableAdapter.ClearBeforeFill = true;
            // 
            // temizleButton
            // 
            this.temizleButton.Location = new System.Drawing.Point(19, 211);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(200, 45);
            this.temizleButton.TabIndex = 20;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // istatislikButton
            // 
            this.istatislikButton.Location = new System.Drawing.Point(19, 261);
            this.istatislikButton.Name = "istatislikButton";
            this.istatislikButton.Size = new System.Drawing.Size(200, 45);
            this.istatislikButton.TabIndex = 21;
            this.istatislikButton.Text = "İstatislik";
            this.istatislikButton.UseVisualStyleBackColor = true;
            this.istatislikButton.Click += new System.EventHandler(this.istatislikButton_Click);
            // 
            // SehirGrafikButton
            // 
            this.SehirGrafikButton.Location = new System.Drawing.Point(238, 3);
            this.SehirGrafikButton.Name = "SehirGrafikButton";
            this.SehirGrafikButton.Size = new System.Drawing.Size(200, 45);
            this.SehirGrafikButton.TabIndex = 22;
            this.SehirGrafikButton.Text = "Şehir Grafiği";
            this.SehirGrafikButton.UseVisualStyleBackColor = true;
            this.SehirGrafikButton.Click += new System.EventHandler(this.SehirGrafikButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(673, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 26);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(234, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "ARAMA:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.SehirGrafikButton);
            this.groupBox2.Controls.Add(this.istatislikButton);
            this.groupBox2.Controls.Add(this.temizleButton);
            this.groupBox2.Controls.Add(this.tabloyuGosterButton);
            this.groupBox2.Controls.Add(this.yeniKisiEkleButton);
            this.groupBox2.Controls.Add(this.silButton);
            this.groupBox2.Controls.Add(this.guncelleButton);
            this.groupBox2.Location = new System.Drawing.Point(435, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 306);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(949, 623);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTUMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cityTextBox2;
        private System.Windows.Forms.TextBox birthTextBox3;
        private System.Windows.Forms.TextBox distTextBox4;
        private System.Windows.Forms.TextBox genderTextBox5;
        private System.Windows.Forms.TextBox ageTextBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tabloyuGosterButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button yeniKisiEkleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource denemeDataSetBindingSource;
        private denemeDataSet denemeDataSet;
        private System.Windows.Forms.BindingSource cOSTUMERSBindingSource;
        private denemeDataSetTableAdapters.COSTUMERSTableAdapter cOSTUMERSTableAdapter;
        private System.Windows.Forms.RadioButton YabanciradioButton2;
        private System.Windows.Forms.RadioButton TRradioButton1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTOMERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTRICTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button istatislikButton;
        private System.Windows.Forms.Button SehirGrafikButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

