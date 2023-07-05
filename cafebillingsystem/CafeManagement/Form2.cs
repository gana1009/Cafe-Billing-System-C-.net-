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
    public partial class Form2 : Form
    {
        List<int> ls;
        Database_Handler dh = new Database_Handler();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //dt = dh.show_data();
            //dataGridView1.DataSource = dt;

            ls = dh.fetch_data();

            txtLatte.Text = ls[0].ToString();
            txtEspresso.Text = ls[1].ToString();
            txtChocolateMilk.Text = ls[2].ToString();
            txtOreoShake.Text = ls[3].ToString();
            txtCappu.Text = ls[4].ToString();
            txtColdCoffee.Text = ls[5].ToString();
            txtMilkTea.Text = ls[6].ToString();
            txtGreenTea.Text = ls[7].ToString();
            txtCoffeCake.Text = ls[8].ToString();
            txtRedValvetCake.Text = ls[9].ToString();
            txtBlackForestCake.Text = ls[10].ToString();
            txtVegPizza.Text = ls[11].ToString();
            txtFrenchFries.Text = ls[12].ToString();
            txtGrillSandwich.Text = ls[13].ToString();
            txtMasalaMaggi.Text = ls[14].ToString();
            txtVegBurger.Text = ls[15].ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ls.Clear();
            ls = dh.fetch_data();

            //DataTable dt = new DataTable();
            //dt = dh.show_data();
            //dataGridView1.DataSource = dt;


            txtLatte.Text = ls[0].ToString();
            txtEspresso.Text = ls[1].ToString();
            txtChocolateMilk.Text = ls[2].ToString();
            txtOreoShake.Text = ls[3].ToString();
            txtCappu.Text = ls[4].ToString();
            txtColdCoffee.Text = ls[5].ToString();
            txtMilkTea.Text = ls[6].ToString();
            txtGreenTea.Text = ls[7].ToString();
            txtCoffeCake.Text = ls[8].ToString();
            txtRedValvetCake.Text = ls[9].ToString();
            txtBlackForestCake.Text = ls[10].ToString();
            txtVegPizza.Text = ls[11].ToString();
            txtFrenchFries.Text = ls[12].ToString();
            txtGrillSandwich.Text = ls[13].ToString();
            txtMasalaMaggi.Text = ls[14].ToString();
            txtVegBurger.Text = ls[15].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt = dh.show_data();
            //dataGridView1.DataSource = dt;

            if (txtLatte.Text != "") dh.update_data("lat", Convert.ToInt32(txtLatte.Text));
            if (txtEspresso.Text != "") dh.update_data("chkmilk", Convert.ToInt32(txtEspresso.Text));
            if (txtChocolateMilk.Text != "") dh.update_data("espr", Convert.ToInt32(txtChocolateMilk.Text));
            if (txtOreoShake.Text != "") dh.update_data("orshk", Convert.ToInt32(txtOreoShake.Text));
            if (txtCappu.Text != "") dh.update_data("cappu", Convert.ToInt32(txtCappu.Text));
            if (txtColdCoffee.Text != "") dh.update_data("cldcffe", Convert.ToInt32(txtColdCoffee.Text));
            if (txtMilkTea.Text != "") dh.update_data("mTea", Convert.ToInt32(txtMilkTea.Text));
            if (txtGreenTea.Text != "") dh.update_data("gTea", Convert.ToInt32(txtGreenTea.Text));
            if (txtCoffeCake.Text != "") dh.update_data("cCake", Convert.ToInt32(txtCoffeCake.Text));
            if (txtRedValvetCake.Text != "") dh.update_data("rValvet", Convert.ToInt32(txtRedValvetCake.Text));
            if (txtBlackForestCake.Text != "") dh.update_data("bFor", Convert.ToInt32(txtBlackForestCake.Text));
            if (txtVegPizza.Text != "") dh.update_data("vpiza", Convert.ToInt32(txtVegPizza.Text));
            if (txtFrenchFries.Text != "") dh.update_data("ff", Convert.ToInt32(txtFrenchFries.Text));
            if (txtGrillSandwich.Text != "") dh.update_data("grlsan", Convert.ToInt32(txtGrillSandwich.Text));
            if (txtMasalaMaggi.Text != "") dh.update_data("mslmgi", Convert.ToInt32(txtMasalaMaggi.Text));
            if (txtVegBurger.Text != "") dh.update_data("vbur", Convert.ToInt32(txtVegBurger.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {//billing button

            new Form1().Show();
            this.Hide();
            
        }
    }
}
