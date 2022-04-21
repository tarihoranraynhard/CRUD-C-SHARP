/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 21/04/2022
 * Time: 15:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Toko
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = toko; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_toko";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"data_toko") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_toko";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void ResetData(){
			tbKode.Text="";
			tbNama.Text="";
			tbTersedia.Text="";
			tbHarga.Text="";
			tbMI.Text="";
			tbTK.Text="";
		}
		
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			ResetData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TbTersediaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnTambahClick(object sender, EventArgs e)
		{
			if(tbKode.Text.Trim() == "" || tbNama.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{			
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "INSERT INTO  data_toko VALUES ('"+tbKode.Text+"','"+tbNama.Text+"','"+tbTersedia.Text+"','"+tbHarga.Text+"','"+tbMI.Text+"','"+tbTK.Text+"')";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_toko")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_toko";
				}
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if(tbKode.Text.Trim() == "" || tbNama.Text.Trim() == ""|| tbTersedia.Text.Trim() == ""|| tbHarga.Text.Trim() == ""|| tbMI.Text.Trim() == ""|| tbTK.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "UPDATE data_toko SET kode='"+tbKode.Text+"',nama='"+tbNama.Text+"',barang_tersedia='"+tbTersedia.Text+"',harga='"+tbHarga.Text+"',made_in='"+tbMI.Text+"',tanggal_kadaluarsa='"+tbTK.Text+"' WHERE kode ='"+tbKode.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_toko")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_toko";
				}
				MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin ingin menghapus "+tbKode.Text+ "?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "DELETE FROM data_toko WHERE kode='"+tbKode.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_toko")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_toko";
				}
				MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			tbKode.Text = row.Cells["kode"].Value.ToString();
			tbNama.Text = row.Cells["nama"].Value.ToString();
			tbTersedia.Text = row.Cells["barang_tersedia"].Value.ToString();
			tbHarga.Text = row.Cells["harga"].Value.ToString();
			tbMI.Text = row.Cells["made_in"].Value.ToString();
			tbTK.Text = row.Cells["tanggal_kadaluarsa"].Value.ToString();
		}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
	}
}
