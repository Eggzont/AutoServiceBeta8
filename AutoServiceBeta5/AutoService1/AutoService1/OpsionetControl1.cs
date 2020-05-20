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
    public partial class OpsionetControl1 : UserControl
    {
        //Inicializimi i DB
        MySqlConnection con = new MySqlConnection(@"server=localhost;Uid=root;database=autoservice;port=3306;password=qweqwe1234");

        public OpsionetControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OpsionetControl1_Load(object sender, EventArgs e)
        {
            
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * FROM autoservice.login";
            MySqlDataReader myReader;

            try
            {
                con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    label4.Text = myReader[1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
