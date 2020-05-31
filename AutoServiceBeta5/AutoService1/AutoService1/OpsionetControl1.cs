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
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OpsionetControl1_Load(object sender, EventArgs e)
        {

        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * From autoservice.login where password = '" + textBox1.Text.Trim() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                int i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    //MessageBox.Show("Fjalekalimi gabim !!!");
                    gabimLbl.Text = "Fjalekalimi eshte gabim !!!";


                }
                else
                {
                    panel1.Show();
                    textBox1.Enabled = false;
                    okbtn.Enabled = false;
                    gabimLbl.Visible = false;
                }
                textBox1.Text = "";
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE login SET password ='" + textBox2.Text + "'WHERE LoginID=1";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MessageBox.Show("U ndryshua me Sukses");
                textBox2.Text = "";
                textBox3.Text = "";
                con.Close();

            }
            else
            {
                MessageBox.Show("Fjalekalimi ri nuk perputhet");
                textBox2.Focus();
                textBox3.Focus();
            }
        }
    }
}
