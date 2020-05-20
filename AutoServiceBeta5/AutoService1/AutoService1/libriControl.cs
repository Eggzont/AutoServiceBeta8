using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoService1
{
    public partial class libriControl : UserControl
    {
        string connectionString = @"server=localhost;Uid=root;database=autoservice;port=3306;password=qweqwe1234";
        public libriControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            selectPanel.Visible = true;
            GridFill();


        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("CarsViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblCars = new DataTable();
                sqlDa.Fill(dtblCars);
                datagrid.DataSource = dtblCars;
                datagrid.Columns[0].Visible = false;
                datagrid.Columns[4].Visible = false;
                datagrid.Columns[5].Visible = false;
                //datagrid.Columns[6].Visible = false;

            }
        }

        private void libriControl_Load(object sender, EventArgs e)
        {

            
            lblData.Text = DateTime.Now.ToString("yyyy-MM-dd");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {
              
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM cars WHERE Klienti LIKE'" + txtSearch.Text + "%'", conn);
                    DataTable dtblCars = new DataTable();
                    sqlDa.Fill(dtblCars);
                    datagrid.DataSource = dtblCars;
                    /* datagrid.Columns[0].Visible = false;
                    datagrid.Columns[4].Visible = false;
                    datagrid.Columns[5].Visible = false;
                    datagrid.Columns[6].Visible = false;
                    */
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ndodhi nje gabim : " + ex.Message);
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    txtKM.Enabled = true;
                    txtPershkrimi.Enabled = true;
                    txtPjeset.Enabled = true;
                    SaveBtn.Enabled = true;
                    anuloBtn.Enabled = true;


                    DataGridViewRow row = this.datagrid.Rows[e.RowIndex];

                    hlbl.Text = row.Cells["KlientiID"].Value.ToString();
                   lblEmri.Text = row.Cells["Klienti"].Value.ToString();
                   lblVetura.Text = row.Cells["Vetura"].Value.ToString();
                    lblMotori.Text = row.Cells["Motori"].Value.ToString();

                    selectPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }
        void Clear()
        {
            txtKM.Text = txtPershkrimi.Text = txtPjeset.Text = "";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand comm = mysqlCon.CreateCommand();
                comm.CommandText = "INSERT INTO servisi(data,pershkrimi,pjeset,km,klientiID)VALUES(@data,@pershkrimi, @pjeset, @km, @klientiID)";

                comm.Parameters.AddWithValue("@data", lblData.Text);
                comm.Parameters.AddWithValue("@pershkrimi", txtPershkrimi.Text);
                comm.Parameters.AddWithValue("@pjeset", txtPjeset.Text);
                comm.Parameters.AddWithValue("@km", txtKM.Text);
                comm.Parameters.AddWithValue("@klientiID", hlbl.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("U Regjistrua me Sukses");
                Clear();
               
                mysqlCon.Close();
            }
        }

        private void anuloBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}