namespace Stok_Takip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.txtMusteriIDAra = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboUcret = new System.Windows.Forms.ComboBox();
            this.comboTeslimDurumu = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxtAcıklama = new System.Windows.Forms.RichTextBox();
            this.txtTelefonSifresi = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.TxtArıza = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stokTakipDataSet = new Stok_Takip.StokTakipDataSet();
            this.karmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karmaTableAdapter = new Stok_Takip.StokTakipDataSetTableAdapters.karmaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1507, 843);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1497, 100);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.txtMusteriIDAra);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtAdSoyadAra);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1489, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arama";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(1237, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 65);
            this.button7.TabIndex = 30;
            this.button7.Text = "Müşteriyi Ara";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtMusteriIDAra
            // 
            this.txtMusteriIDAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriIDAra.Location = new System.Drawing.Point(1097, 25);
            this.txtMusteriIDAra.Name = "txtMusteriIDAra";
            this.txtMusteriIDAra.Size = new System.Drawing.Size(132, 30);
            this.txtMusteriIDAra.TabIndex = 29;
            this.txtMusteriIDAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Edildi",
            "Edilmedi"});
            this.comboBox2.Location = new System.Drawing.Point(557, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(979, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Müşteri ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(368, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 28);
            this.label13.TabIndex = 27;
            this.label13.Text = "Teslim Durumu:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alındı",
            "Alınmadı"});
            this.comboBox1.Location = new System.Drawing.Point(199, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 33);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(708, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 28);
            this.label12.TabIndex = 25;
            this.label12.Text = "Ad Soyad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(21, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "Ücret Durumu:";
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyadAra.Location = new System.Drawing.Point(834, 25);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(133, 30);
            this.txtAdSoyadAra.TabIndex = 3;
            this.txtAdSoyadAra.TextChanged += new System.EventHandler(this.txtAdSoyadAra_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtMusteriID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.comboUcret);
            this.groupBox1.Controls.Add(this.comboTeslimDurumu);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rtxtAcıklama);
            this.groupBox1.Controls.Add(this.txtTelefonSifresi);
            this.groupBox1.Controls.Add(this.txtIMEI);
            this.groupBox1.Controls.Add(this.txtMusteriTel);
            this.groupBox1.Controls.Add(this.TxtArıza);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1515, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 843);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cihaz Bilgisi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 393);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 30);
            this.button6.TabIndex = 29;
            this.button6.Text = "$";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(173, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 30);
            this.button5.TabIndex = 28;
            this.button5.Text = "₺";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Enabled = false;
            this.txtMusteriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(173, 27);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(132, 26);
            this.txtMusteriID.TabIndex = 27;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(8, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Müşteri ID:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(300, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 48);
            this.button4.TabIndex = 25;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboUcret
            // 
            this.comboUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboUcret.FormattingEnabled = true;
            this.comboUcret.Items.AddRange(new object[] {
            "Alındı",
            "Alınmadı"});
            this.comboUcret.Location = new System.Drawing.Point(239, 361);
            this.comboUcret.Name = "comboUcret";
            this.comboUcret.Size = new System.Drawing.Size(96, 28);
            this.comboUcret.TabIndex = 24;
            // 
            // comboTeslimDurumu
            // 
            this.comboTeslimDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTeslimDurumu.FormattingEnabled = true;
            this.comboTeslimDurumu.Items.AddRange(new object[] {
            "Edildi",
            "Edilmedi"});
            this.comboTeslimDurumu.Location = new System.Drawing.Point(173, 572);
            this.comboTeslimDurumu.Name = "comboTeslimDurumu";
            this.comboTeslimDurumu.Size = new System.Drawing.Size(121, 28);
            this.comboTeslimDurumu.TabIndex = 23;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(173, 76);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 26);
            this.txtModel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modeli:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(173, 361);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(60, 26);
            this.txtUcret.TabIndex = 22;
            this.txtUcret.Text = "0₺";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 221);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(6, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(379, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxtAcıklama
            // 
            this.rtxtAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtAcıklama.Location = new System.Drawing.Point(141, 449);
            this.rtxtAcıklama.Name = "rtxtAcıklama";
            this.rtxtAcıklama.Size = new System.Drawing.Size(253, 107);
            this.rtxtAcıklama.TabIndex = 3;
            this.rtxtAcıklama.Text = "";
            this.rtxtAcıklama.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtTelefonSifresi
            // 
            this.txtTelefonSifresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonSifresi.Location = new System.Drawing.Point(173, 311);
            this.txtTelefonSifresi.Name = "txtTelefonSifresi";
            this.txtTelefonSifresi.Size = new System.Drawing.Size(132, 26);
            this.txtTelefonSifresi.TabIndex = 18;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIMEI.Location = new System.Drawing.Point(173, 268);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(132, 26);
            this.txtIMEI.TabIndex = 16;
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTel.Location = new System.Drawing.Point(173, 219);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(132, 26);
            this.txtMusteriTel.TabIndex = 15;
            this.txtMusteriTel.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TxtArıza
            // 
            this.TxtArıza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtArıza.Location = new System.Drawing.Point(173, 170);
            this.TxtArıza.Name = "TxtArıza";
            this.TxtArıza.Size = new System.Drawing.Size(132, 26);
            this.TxtArıza.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(173, 123);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(132, 26);
            this.txtAdSoyad.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Teslim Durumu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Açıklaması:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ücreti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon Şifresi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "İMEİ NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri tel:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arızası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // stokTakipDataSet
            // 
            this.stokTakipDataSet.DataSetName = "StokTakipDataSet";
            this.stokTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karmaBindingSource
            // 
            this.karmaBindingSource.DataMember = "karma";
            this.karmaBindingSource.DataSource = this.stokTakipDataSet;
            // 
            // karmaTableAdapter
            // 
            this.karmaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1515, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1004);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox TxtArıza;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonSifresi;
        private System.Windows.Forms.RichTextBox rtxtAcıklama;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboUcret;
        private System.Windows.Forms.ComboBox comboTeslimDurumu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private StokTakipDataSet stokTakipDataSet;
        private System.Windows.Forms.BindingSource karmaBindingSource;
        private StokTakipDataSetTableAdapters.karmaTableAdapter karmaTableAdapter;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMusteriIDAra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

