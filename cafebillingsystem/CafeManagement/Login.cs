using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Login : Form
    {
        private string usrName, pasWord;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//login button
            if(textBox1.Text == this.usrName && textBox2.Text == this.pasWord)
            {
                MessageBox.Show("Login Succesfull !!");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//Modify Price Button

            if (textBox1.Text == this.usrName && textBox2.Text == this.pasWord)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login !!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {//Login Button

            this.usrName = "root";
            this.pasWord = "toor";
            //insert_value();
        }

        //private void insert_value()
        //{
        //    Database_Handler dh = new Database_Handler();
        //    dh.add_data("lat", 120);
        //    dh.add_data("chkmilk", 50);
        //    dh.add_data("espr", 120);
        //    dh.add_data("orshk", 70);
        //    dh.add_data("cappu", 80);
        //    dh.add_data("cldcffe", 70);
        //    dh.add_data("mTea", 30);
        //    dh.add_data("gTea", 30);
        //    dh.add_data("cCake", 100);
        //    dh.add_data("rValvet", 120);
        //    dh.add_data("bFor", 120);
        //    dh.add_data("vpiza", 200);
        //    dh.add_data("ff", 70);
        //    dh.add_data("grlsan", 80);
        //    dh.add_data("mslmgi", 50);
        //    dh.add_data("vbur", 60);
        //}
    }
}
