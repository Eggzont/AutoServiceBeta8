using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoService1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void movePanel(Control btn)
        {
            slidePanel.Width = btn.Width;
            slidePanel.Left = btn.Left;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movePanel(button1);
            klientiControl11.Hide();
            opsionetControl11.Hide();
            historikuControl1.Hide();
            libriControl1.Hide();
            dash1.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            movePanel(button2);
            klientiControl11.Show();
            opsionetControl11.Hide();
            libriControl1.Hide();
            historikuControl1.Hide();
            dash1.Hide();





        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            movePanel(button3);
            klientiControl11.Hide();
            opsionetControl11.Hide();
            libriControl1.Show();
            historikuControl1.Hide();
            dash1.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            movePanel(button4);
            klientiControl11.Hide();
            opsionetControl11.Hide();
            libriControl1.Hide();
            historikuControl1.Show();
            dash1.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            movePanel(button5);
            opsionetControl11.Show();
            klientiControl11.Hide();
            libriControl1.Hide();
            historikuControl1.Hide();
            dash1.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            klientiControl11.Hide();
            opsionetControl11.Hide();
            libriControl1.Hide();
            historikuControl1.Hide();
            dash1.Show();


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

       
        private void btnPerdoruesi_Click(object sender, EventArgs e)
        {
            opsionetControl11.Show();
        }

      

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            opsionetControl11.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
