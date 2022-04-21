/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 21/04/2022
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Toko
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.tbKode = new System.Windows.Forms.TextBox();
			this.tbNama = new System.Windows.Forms.TextBox();
			this.tbTersedia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbTK = new System.Windows.Forms.TextBox();
			this.tbMI = new System.Windows.Forms.TextBox();
			this.tbHarga = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(371, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "TOKO SERBA ADA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbKode
			// 
			this.tbKode.Location = new System.Drawing.Point(192, 91);
			this.tbKode.Name = "tbKode";
			this.tbKode.Size = new System.Drawing.Size(170, 22);
			this.tbKode.TabIndex = 1;
			// 
			// tbNama
			// 
			this.tbNama.Location = new System.Drawing.Point(192, 141);
			this.tbNama.Name = "tbNama";
			this.tbNama.Size = new System.Drawing.Size(170, 22);
			this.tbNama.TabIndex = 2;
			// 
			// tbTersedia
			// 
			this.tbTersedia.Location = new System.Drawing.Point(192, 197);
			this.tbTersedia.Name = "tbTersedia";
			this.tbTersedia.Size = new System.Drawing.Size(170, 22);
			this.tbTersedia.TabIndex = 3;
			this.tbTersedia.TextChanged += new System.EventHandler(this.TbTersediaTextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kode Barang";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(550, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(179, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tanggal Kadaluarsa";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(550, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Made In";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(550, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Harga Barang";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 197);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Barang Tersedia";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(27, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 23);
			this.label9.TabIndex = 11;
			this.label9.Text = "Nama Barang";
			// 
			// tbTK
			// 
			this.tbTK.Location = new System.Drawing.Point(771, 197);
			this.tbTK.Name = "tbTK";
			this.tbTK.Size = new System.Drawing.Size(170, 22);
			this.tbTK.TabIndex = 12;
			// 
			// tbMI
			// 
			this.tbMI.Location = new System.Drawing.Point(771, 141);
			this.tbMI.Name = "tbMI";
			this.tbMI.Size = new System.Drawing.Size(170, 22);
			this.tbMI.TabIndex = 13;
			// 
			// tbHarga
			// 
			this.tbHarga.Location = new System.Drawing.Point(771, 91);
			this.tbHarga.Name = "tbHarga";
			this.tbHarga.Size = new System.Drawing.Size(170, 22);
			this.tbHarga.TabIndex = 14;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 307);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(942, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(208, 252);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(105, 36);
			this.btnTambah.TabIndex = 16;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.BtnTambahClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(392, 252);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(96, 36);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(550, 252);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 36);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(784, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(157, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "*Tahun - Bulan - Tanggal";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 464);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tbHarga);
			this.Controls.Add(this.tbMI);
			this.Controls.Add(this.tbTK);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbTersedia);
			this.Controls.Add(this.tbNama);
			this.Controls.Add(this.tbKode);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Toko";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tbHarga;
		private System.Windows.Forms.TextBox tbMI;
		private System.Windows.Forms.TextBox tbTK;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTersedia;
		private System.Windows.Forms.TextBox tbNama;
		private System.Windows.Forms.TextBox tbKode;
		private System.Windows.Forms.Label label1;
	}
}
