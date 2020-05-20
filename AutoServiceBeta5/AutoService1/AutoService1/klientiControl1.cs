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
using System.Linq.Expressions;

namespace AutoService1
{
    public partial class klientiControl1 : UserControl
    {

        //Inicializimi i DB
        string connectionString = @"server=localhost;Uid=root;database=autoservice;port=3306;password=qweqwe1234";
        int KlientiID = 0;
        public klientiControl1()
        {
            InitializeComponent();
        }



        private void klientiControl1_Load(object sender, EventArgs e)
        {
            GridFill();
            Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {


            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                if (KlientiID == 0)
                {
                    mysqlCon.Open();
                    MySqlCommand comm = mysqlCon.CreateCommand();
                    comm.CommandText = "INSERT INTO cars(Klienti,Telefoni,Vetura,Motori,Shasia)VALUES(@Klienti, @Telefoni, @Vetura, @Motori, @Shasia)";

                    comm.Parameters.AddWithValue("@Klienti", txtKlienti.Text);
                    comm.Parameters.AddWithValue("@Telefoni", txtTelefoni.Text);
                    comm.Parameters.AddWithValue("@Vetura", txtVetura.Text);
                    comm.Parameters.AddWithValue("@Motori", txtMotori.Text);
                    comm.Parameters.AddWithValue("@Shasia", txtShasia.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("U Regjistrua me Sukses");
                    Clear();
                    GridFill();
                    mysqlCon.Close();


                }
                else
                {
                    mysqlCon.Open();
                    MySqlCommand cmd = mysqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE cars SET Klienti=@Klienti,Telefoni=@Telefoni, Vetura =@Vetura, Motori=@Motori,Shasia=@Shasia WHERE KlientiID=@KlientiID";

                    cmd.Parameters.AddWithValue("@Klienti", txtKlienti.Text);
                    cmd.Parameters.AddWithValue("@Telefoni", txtTelefoni.Text);
                    cmd.Parameters.AddWithValue("@Vetura", txtVetura.Text);
                    cmd.Parameters.AddWithValue("@Motori", txtMotori.Text);
                    cmd.Parameters.AddWithValue("@Shasia", txtShasia.Text);
                    cmd.Parameters.AddWithValue("@KlientiID", KlientiID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("U Ndryshua  me Sukses");
                    Clear();
                    GridFill();
                    mysqlCon.Close();
                }

            }
        }


        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {

                    if (MessageBox.Show("A Deshironi te fshini perfundimisht", "FSHIJE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        mysqlCon.Open();
                        MySqlCommand cmd = mysqlCon.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM cars WHERE KlientiID=@KlientiID";
                        cmd.Parameters.AddWithValue("@KlientiID", KlientiID);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("A Deshironi ta fshini", " ", MessageBoxButtons.YesNo);
                        // MessageBox.Show("U Fshi me Sukses");
                        Clear();
                        GridFill();
                    }
                    else 
                    {
                        MessageBox.Show("Nuk u fshi", "Fshije Tani", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ndodhi nje gabim , Ky Person permban te dhena tek servisi\n"+ex.Message);

            }
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

            }
        }
        void Clear()
        {
            txtVetura.Text = txtKlienti.Text =txtShasia.Text = txtSearch.Text = txtTelefoni.Text = txtMotori.Text = "";
            KlientiID = 0;
            SaveBtn.Text = "Ruaj";
            DeleteBtn.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Clear();

        }

        private void datagrid_DoubleClick(object sender, EventArgs e)
        {
            if (datagrid.CurrentRow.Index != -1)
            {
                txtKlienti.Text = datagrid.CurrentRow.Cells[1].Value.ToString();
                txtTelefoni.Text = datagrid.CurrentRow.Cells[2].Value.ToString();
                txtVetura.Text = datagrid.CurrentRow.Cells[3].Value.ToString();
                txtMotori.Text = datagrid.CurrentRow.Cells[4].Value.ToString();
                txtShasia.Text = datagrid.CurrentRow.Cells[5].Value.ToString();
                KlientiID = Convert.ToInt32(datagrid.CurrentRow.Cells[0].Value.ToString());
                SaveBtn.Text = "Ndrysho";
                DeleteBtn.Enabled = Enabled;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("CarsSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblCars = new DataTable();
                sqlDa.Fill(dtblCars);
                datagrid.DataSource = dtblCars;
                datagrid.Columns[0].Visible = false;


            }
        }
    }
}
