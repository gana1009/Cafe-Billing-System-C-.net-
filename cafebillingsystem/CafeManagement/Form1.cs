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
    public partial class Form1 : Form
    {
        List<int> priceList;

        double lat, chkmilk, espr, orshk, cappu, cldcffe, mTea, gTea;//bevarage prices
        double cCake, rValvet, bFor, vpiza, ff, grlsan, mslmgi, vbur;//snacks prices
        double tax;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        { //btnReset
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtChocolateMilk.Text = "0";
            txtOreoShake.Text = "0";
            txtCappu.Text = "0";
            txtColdCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtGreenTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtVegPizza.Text = "0";
            txtFrenchFries.Text = "0";
            txtGrillSandwich.Text = "0";
            txtMasalaMaggi.Text = "0";
            txtVegBurger.Text = "0";
            lblSnackCost.Text = "0";
            lblDrinkCost.Text = "0"; 
            lblSvcCharge.Text = "5.0";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkChocolateMilk.Checked = false;
            chkOreoShake.Checked = false;
            chkCappucino.Checked = false;
            chkColdCoffee.Checked = false;
            chkMilkTea.Checked = false;
            chkGreenTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkVegPizza.Checked = false;
            chkFrenchFries.Checked = false;
            chkGrillSandwich.Checked = false;
            chkMasalaMaggi.Checked = false;
            chkVegBurger.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btnReceipt
            rtfReceipt.Clear();

           // rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Cafe RIT" + Environment.NewLine);
            rtfReceipt.AppendText("\t     " + "Sakhrale, Ishwarpur" + Environment.NewLine + Environment.NewLine);
            rtfReceipt.AppendText("--------------------TAX INVOICE--------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t\t" + lblDate.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Items \t\t\tQty" + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            if (chkLatte.Checked) rtfReceipt.AppendText("Latte \t\t\t" + txtLatte.Text + Environment.NewLine);
            if (chkEspresso.Checked) rtfReceipt.AppendText("Espresso \t\t" + txtEspresso.Text + Environment.NewLine);
            if (chkChocolateMilk.Checked) rtfReceipt.AppendText("Chocolate Milk \t\t" + txtChocolateMilk.Text + Environment.NewLine);
            if (chkOreoShake.Checked) rtfReceipt.AppendText("Oreo Shake \t\t" + txtOreoShake.Text + Environment.NewLine);
            if (chkCappucino.Checked) rtfReceipt.AppendText("Capuucino \t\t" + txtCappu.Text + Environment.NewLine);
            if (chkColdCoffee.Checked) rtfReceipt.AppendText("Cold Coffee \t\t" + txtColdCoffee.Text + Environment.NewLine);
            if (chkMilkTea.Checked) rtfReceipt.AppendText("Milk Tea \t\t" + txtMilkTea.Text + Environment.NewLine);
            if (chkGreenTea.Checked) rtfReceipt.AppendText("Green Tea \t\t" + txtGreenTea.Text + Environment.NewLine);
            if (chkCoffe.Checked) rtfReceipt.AppendText("Coffee Cake \t\t" + txtCoffeCake.Text + Environment.NewLine);
            if (chkRedValvet.Checked) rtfReceipt.AppendText("Red Valvet Cake \t" + txtRedValvetCake.Text + Environment.NewLine);
            if (chkBlackForest.Checked) rtfReceipt.AppendText("Black Forest Cake \t" + txtBlackForestCake.Text + Environment.NewLine);
            if (chkVegPizza.Checked) rtfReceipt.AppendText("Veg Pizza \t\t" + txtVegPizza.Text + Environment.NewLine);
            if (chkFrenchFries.Checked) rtfReceipt.AppendText("Frnch Fries \t\t" + txtFrenchFries.Text + Environment.NewLine);
            if (chkGrillSandwich.Checked) rtfReceipt.AppendText("Grill Sandwich \t\t" + txtGrillSandwich.Text + Environment.NewLine);
            if (chkMasalaMaggi.Checked) rtfReceipt.AppendText("Masala Maggi \t\t" + txtMasalaMaggi.Text + Environment.NewLine);
            if (chkVegBurger.Checked) rtfReceipt.AppendText("Veg Burger \t\t" + txtVegBurger.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charge \t" + lblSvcCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total Cost \t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("---------------------THANK YOU---------------------" + Environment.NewLine);
            

        }

        private void button1_Click(object sender, EventArgs e)
        { //btnTotal
            //Bevarage
            int latteeCof = Convert.ToInt32(txtLatte.Text);
            int chocolateMlk = Convert.ToInt32(txtChocolateMilk.Text);
            int espressoCof = Convert.ToInt32(txtEspresso.Text);
            int oreoShk = Convert.ToInt32(txtOreoShake.Text);
            int cappCof = Convert.ToInt32(txtCappu.Text);
            int coldCof = Convert.ToInt32(txtColdCoffee.Text);
            int miTea = Convert.ToInt32(txtMilkTea.Text);
            int greenTea = Convert.ToInt32(txtGreenTea.Text);
            //Snacks
            int cofCake = Convert.ToInt32(txtCoffeCake.Text);
            int redValvet = Convert.ToInt32(txtRedValvetCake.Text);
            int bForest = Convert.ToInt32(txtBlackForestCake.Text);
            int vegPizza = Convert.ToInt32(txtVegPizza.Text);
            int frnFries = Convert.ToInt32(txtFrenchFries.Text);
            int grlSand = Convert.ToInt32(txtGrillSandwich.Text);
            int msalMaggi = Convert.ToInt32(txtMasalaMaggi.Text);
            int vegBurgr = Convert.ToInt32(txtVegBurger.Text);

            /*Cafe eat_in_cafe = new Cafe(latteeCof, chocolateMlk, espressoCof, oreoShk, cappCof, coldCof, miTea, greenTea,
                cofCake, redValvet, bForest, vegPizza, frnFries, grlSand, msalMaggi, vegBurgr);*/

            double drinkCosts = (latteeCof * lat) + (chocolateMlk * chkmilk) + (espressoCof * espr) + (oreoShk * orshk) + (cappCof * cappu) + (coldCof * cldcffe) + (miTea * mTea) + (greenTea * gTea);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double snackCost = (cofCake * cCake) + (redValvet * rValvet) + (bForest * bFor) + (vegPizza * vpiza) + (frnFries * ff) + (grlSand * grlsan) + (msalMaggi * mslmgi) + (vegBurgr * vbur);
            lblSnackCost.Text = Convert.ToString(snackCost);

            double svcCharge = (drinkCosts+snackCost) * Convert.ToDouble(lblSvcCharge.Text)/100;

            lblSubTotal.Text = Convert.ToString(snackCost + drinkCosts + svcCharge);
            lblTax.Text = Convert.ToString(((snackCost + drinkCosts + svcCharge) * tax) / 100);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(snackCost + drinkCosts + svcCharge + totalAftTax);

            lblDrinkCost.Text = String.Format("{0:C}", drinkCosts);
            lblSnackCost.Text = String.Format("{0:C}", snackCost);
            lblSvcCharge.Text = String.Format("{0:C}", svcCharge);
            lblSubTotal.Text = String.Format("{0:C}", (snackCost + drinkCosts + svcCharge));
            lblTax.Text = String.Format("{0:C}", totalAftTax);
            lblTotal.Text = String.Format("{0:C}", (snackCost + drinkCosts + svcCharge + totalAftTax));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            double latteeCof = Convert.ToDouble(txtLatte.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

            Database_Handler dh = new Database_Handler();
            priceList = dh.fetch_data();

            //Fetching prices
            lat = priceList[0]; chkmilk = priceList[1]; espr = priceList[2]; orshk = priceList[3]; cappu = priceList[4]; cldcffe = priceList[5]; mTea = priceList[6]; gTea = priceList[7]; //bevarage pries
            cCake = priceList[8]; rValvet = priceList[9]; bFor = priceList[10]; vpiza = priceList[11]; ff = priceList[12]; grlsan = priceList[13]; mslmgi = priceList[14]; vbur = priceList[15]; //snacks prices
            tax = 18;

            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtChocolateMilk.Text = "0";
            txtOreoShake.Text = "0";
            txtCappu.Text = "0";
            txtColdCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtGreenTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtVegPizza.Text = "0";
            txtFrenchFries.Text = "0";
            txtGrillSandwich.Text = "0";
            txtMasalaMaggi.Text = "0";
            txtVegBurger.Text = "0";
            lblSnackCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "5.0";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            //initializing Pricing 
            label6.Text = "Rs. " + priceList[0].ToString();
            label7.Text = "Rs. " + priceList[1].ToString();
            label8.Text = "Rs. " + priceList[2].ToString();
            label12.Text = "Rs. " + priceList[3].ToString();
            label13.Text = "Rs. " + priceList[4].ToString();
            label14.Text = "Rs. " + priceList[5].ToString();
            label15.Text = "Rs. " + priceList[6].ToString();
            label16.Text = "Rs. " + priceList[7].ToString();
            label24.Text = "Rs. " + priceList[8].ToString();
            label23.Text = "Rs. " + priceList[9].ToString();
            label22.Text = "Rs. " + priceList[10].ToString();
            label21.Text = "Rs. " + priceList[11].ToString();
            label20.Text = "Rs. " + priceList[12].ToString();
            label19.Text = "Rs. " + priceList[13].ToString();
            label18.Text = "Rs. " + priceList[14].ToString();
            label17.Text = "Rs. " + priceList[15].ToString();

            txtLatte.Enabled = false;
            txtEspresso.Enabled = false; ;
            txtChocolateMilk.Enabled = false;
            txtOreoShake.Enabled = false;
            txtCappu.Enabled = false;
            txtColdCoffee.Enabled = false;
            txtMilkTea.Enabled = false;
            txtGreenTea.Enabled = false;
            txtCoffeCake.Enabled = false;
            txtRedValvetCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtVegPizza.Enabled = false;
            txtFrenchFries.Enabled = false;
            txtGrillSandwich.Enabled = false;
            txtMasalaMaggi.Enabled = false;
            txtVegBurger.Enabled = false;

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkChocolateMilk.Checked = false;
            chkOreoShake.Checked = false;
            chkCappucino.Checked = false;
            chkColdCoffee.Checked = false;
            chkMilkTea.Checked = false;
            chkGreenTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkVegPizza.Checked = false;
            chkFrenchFries.Checked = false;
            chkGrillSandwich.Checked = false;
            chkMasalaMaggi.Checked = false;
            chkVegBurger.Checked = false;

            rtfReceipt.Clear();

        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked==true)
            {
                txtLatte.Enabled = true;
            }
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }    

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
               txtEspresso.Enabled = true;
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolateMilk.Checked == true)
            {
                txtChocolateMilk.Enabled = true;
            }
            else
            {
                txtChocolateMilk.Enabled = false;
                txtChocolateMilk.Text = "0";
            }
        }

        private void txtMocha_Click(object sender, EventArgs e)
        {
            txtChocolateMilk.Text = "";
            txtChocolateMilk.Focus();
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOreoShake.Checked == true)
            {
                txtOreoShake.Enabled = true;
            }
            else
            {
                txtOreoShake.Enabled = false;
                txtOreoShake.Text = "0";
            }
        }

        private void txtValeCoffee_Click(object sender, EventArgs e)
        {
            txtOreoShake.Text = "";
            txtOreoShake.Focus();
        }

        private void chkCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappucino.Checked == true)
            {
                txtCappu.Enabled = true;
            }
            else
            {
                txtCappu.Enabled = false;
                txtCappu.Text = "0";
            }
        }

        private void txtCappu_Click(object sender, EventArgs e)
        {
            txtCappu.Text = "";
            txtCappu.Focus();
        }

        private void chkAfricanCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColdCoffee.Checked == true)
            {
                txtColdCoffee.Enabled = true;
            }
            else
            {
                txtColdCoffee.Enabled = false;
                txtColdCoffee.Text = "0";
            }
        }

           private void txtAfricanCoffee_Click(object sender, EventArgs e)
        {
            txtColdCoffee.Text = "";
            txtColdCoffee.Focus();
        }

        private void chkMilkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMilkTea.Checked == true)
            {
                txtMilkTea.Enabled = true;
            }
            else
            {
                txtMilkTea.Enabled = false;
                txtMilkTea.Text = "0";
            }
        }

        private void txtMilkTea_Click(object sender, EventArgs e)
        {
            txtMilkTea.Text = "";
            txtMilkTea.Focus();
        }

        private void chkChineseTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenTea.Checked == true)
            {
                txtGreenTea.Enabled = true;
            }
            else
            {
                txtGreenTea.Enabled = false;
                txtGreenTea.Text = "0";
            }
        }

        private void txtChineseTea_Click(object sender, EventArgs e)
        {
            txtGreenTea.Text = "";
            txtGreenTea.Focus();
        }

        private void chkCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffe.Checked == true)
            {
                txtCoffeCake.Enabled = true;
            }
            else
            {
                txtCoffeCake.Enabled = false;
                txtCoffeCake.Text = "0";
            }
        }

        private void txtCoffeCake_Click(object sender, EventArgs e)
        {
            txtCoffeCake.Text = "";
            txtCoffeCake.Focus();
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRedValvetCake.Enabled = true;
            }
            else
            {
                txtRedValvetCake.Enabled = false;
                txtRedValvetCake.Text = "0";
            }
        }

        private void txtRedValvetCake_Click(object sender, EventArgs e)
        {
            txtRedValvetCake.Text = "";
            txtRedValvetCake.Focus();
        }


        private void chkBlackForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForest.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
            }
            else
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text = "0";
            }
        }

        private void txtBlackForestCake_Click(object sender, EventArgs e)
        {
            txtBlackForestCake.Text = "";
            txtBlackForestCake.Focus();
        }

        private void chkBostonCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVegPizza.Checked == true)
            {
                txtVegPizza.Enabled = true;
            }
            else
            {
                txtVegPizza.Enabled = false;
                txtVegPizza.Text = "0";
            }
        }

        private void txtBostonCream_Click(object sender, EventArgs e)
        {
            txtVegPizza.Text = "";
            txtVegPizza.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrenchFries.Checked == true)
            {
               txtFrenchFries.Enabled = true;
            }
            else
            {
                txtFrenchFries.Enabled = false;
                txtFrenchFries.Text = "0";
            }
        }

        private void txtLagosChoco_Click(object sender, EventArgs e)
        {
            txtFrenchFries.Text = "";
            txtFrenchFries.Focus();
        }

        private void chkKilburnChoco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrillSandwich.Checked == true)
            {
                txtGrillSandwich.Enabled = true;
            }
            else
            {
                txtGrillSandwich.Enabled = false;
                txtGrillSandwich.Text = "0";
            }
        }


        private void txtKillburnChoco_Click(object sender, EventArgs e)
        {
            txtGrillSandwich.Text = "";
            txtGrillSandwich.Focus();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasalaMaggi.Checked == true)
            {
                txtMasalaMaggi.Enabled = true;
            }
            else
            {
                txtMasalaMaggi.Enabled = false;
                txtMasalaMaggi.Text = "0";
            }
        }


        private void txtCheeseCake_Click(object sender, EventArgs e)
        {
            txtMasalaMaggi.Text = "";
            txtMasalaMaggi.Focus();
        }

        private void chkRainbowCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVegBurger.Checked == true)
            {
               txtVegBurger.Enabled = true;
            }
            else
            {
                txtVegBurger.Enabled = false;
                txtVegBurger.Text = "0";
            }
        }

        private void txtRainbowCake_Click(object sender, EventArgs e)
        {
            txtVegBurger.Text = "";
            txtVegBurger.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = DateTime.Now.ToString() + "_bill";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            
            
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
