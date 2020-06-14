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
    public partial class HistorikuControl : UserControl
    {
        string connectionString = @"server=localhost;Uid=root;database=autoservice;port=3306;password=qweqwe1234";

        public HistorikuControl()
        {
            InitializeComponent();
            GridFill();
        }


        private void HistorikuControl_Load(object sender, EventArgs e)
        {

        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT ServisiID,Klienti,telefoni,vetura,Pershkrimi,Pjeset FROM servisi INNER JOIN cars on servisi.KlientiID = cars.KlientiID;", mysqlCon);

                DataTable dtblCars = new DataTable();
                sqlDa.Fill(dtblCars);
                datagrid.DataSource = dtblCars;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {

                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT ServisiID,Klienti,telefoni,vetura,Pershkrimi,Pjeset FROM servisi INNER JOIN cars on servisi.KlientiID = cars.KlientiID WHERE cars.Klienti LIKE'" + txtSearch.Text + "%'", conn);
                    DataTable dtblCars = new DataTable();
                    sqlDa.Fill(dtblCars);
                    datagrid.DataSource = dtblCars;
                    //datagrid.Columns[0].Visible = false;
                    /*
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
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                shikopanel.Visible = true;

                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];
                lblEmri.Text = row.Cells["Klienti"].Value.ToString();



            }
        }

        private void kthehubtn_Click(object sender, EventArgs e)
        {
            shikopanel.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}

