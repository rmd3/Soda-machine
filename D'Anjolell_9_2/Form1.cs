using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_9_2
{
    public partial class Form1 : Form
    {
        //Declares structure named VendingMachine
        struct VendingMachine
        {
            public string drinkName;
            public double beverageCost;
            public int numOfDrinks;
        }
        //Declares global variables
        public double totalSales = 0.00;
        public string[,] sodaInfo = new string[,]
        {
            {"Cola", "1.00", "20"},
            {"Root Beer", "1.00", "20"},
            {"Lemon Lime Soda", "1.00", "20"},
            {"Grape Soda", "1.50", "20"},
            {"Cream Soda", "1.50", "20"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the window
            this.Close();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare variable
            int colaAmt;

            //Declaring a struct array and having it equal to data in sodaInfo
            VendingMachine[] sodaList = new VendingMachine[5];
            for (int i = 0; i < sodaList.Length; i++)
            {
                sodaList[i].drinkName = sodaInfo[i, 0];
                sodaList[i].beverageCost = double.Parse(sodaInfo[i, 1]);
                sodaList[i].numOfDrinks = int.Parse(sodaInfo[i, 2]);
            }

            //Have the amount of soda in the vending machine decrease
            colaAmt = sodaList[0].numOfDrinks - 1;
            sodaInfo[0, 2] = colaAmt.ToString();

            //If statement in case soda is sold out
            if (sodaList[0].numOfDrinks > 0)
            {
                txtColaAmt.Text = colaAmt.ToString();
                totalSales += sodaList[0].beverageCost;
                txtTotalSales.Text = "$" + totalSales.ToString("0.00");
            }
            else
            {
                string outOfStock = "The drink " + sodaList[0].drinkName + " is sold out.";
                string windowTitle = "Sold Out";
                MessageBox.Show(outOfStock, windowTitle);
            }
        }

        private void btnRtBr_Click(object sender, EventArgs e)
        {
            //Declare variable
            int rtbrAmt;

            //Declaring a struct array and having it equal to data in sodaInfo
            VendingMachine[] sodaList = new VendingMachine[5];
            for (int i = 0; i < sodaList.Length; i++)
            {
                sodaList[i].drinkName = sodaInfo[i, 0];
                sodaList[i].beverageCost = double.Parse(sodaInfo[i, 1]);
                sodaList[i].numOfDrinks = int.Parse(sodaInfo[i, 2]);
            }

            //Have the amount of soda in the vending machine decrease
            rtbrAmt = sodaList[1].numOfDrinks - 1;
            sodaInfo[1, 2] = rtbrAmt.ToString();

            //If statement in case soda is sold out
            if (sodaList[1].numOfDrinks > 0)
            {
                txtRtBrAmt.Text = rtbrAmt.ToString();
                totalSales += sodaList[1].beverageCost;
                txtTotalSales.Text = "$" + totalSales.ToString("0.00");
            }
            else
            {
                string outOfStock = "The drink " + sodaList[1].drinkName + " is sold out.";
                string windowTitle = "Sold Out";
                MessageBox.Show(outOfStock, windowTitle);
            }
        }

        private void btnLemLim_Click(object sender, EventArgs e)
        {
            //Declare variable
            int LemLimAmt;

            //Declaring a struct array and having it equal to data in sodaInfo
            VendingMachine[] sodaList = new VendingMachine[5];
            for (int i = 0; i < sodaList.Length; i++)
            {
                sodaList[i].drinkName = sodaInfo[i, 0];
                sodaList[i].beverageCost = double.Parse(sodaInfo[i, 1]);
                sodaList[i].numOfDrinks = int.Parse(sodaInfo[i, 2]);
            }

            //Have the amount of soda in the vending machine decrease
            LemLimAmt = sodaList[2].numOfDrinks - 1;
            sodaInfo[2, 2] = LemLimAmt.ToString();

            //If statement in case soda is sold out
            if (sodaList[2].numOfDrinks > 0)
            {
                txtLemLimAmt.Text = LemLimAmt.ToString();
                totalSales += sodaList[2].beverageCost;
                txtTotalSales.Text = "$" + totalSales.ToString("0.00");
            }
            else
            {
                string outOfStock = "The drink " + sodaList[2].drinkName + " is sold out.";
                string windowTitle = "Sold Out";
                MessageBox.Show(outOfStock, windowTitle);
            }
        }

        private void btnGrape_Click(object sender, EventArgs e)
        {
            //Declare variable
            int GrapeAmt;

            //Declaring a struct array and having it equal to data in sodaInfo
            VendingMachine[] sodaList = new VendingMachine[5];
            for (int i = 0; i < sodaList.Length; i++)
            {
                sodaList[i].drinkName = sodaInfo[i, 0];
                sodaList[i].beverageCost = double.Parse(sodaInfo[i, 1]);
                sodaList[i].numOfDrinks = int.Parse(sodaInfo[i, 2]);
            }

            //Have the amount of soda in the vending machine decrease
            GrapeAmt = sodaList[3].numOfDrinks - 1;
            sodaInfo[3, 2] = GrapeAmt.ToString();

            //If statement in case soda is sold out
            if (sodaList[3].numOfDrinks > 0)
            {
                txtGrapeAmt.Text = GrapeAmt.ToString();
                totalSales += sodaList[3].beverageCost;
                txtTotalSales.Text = "$" + totalSales.ToString("0.00");
            }
            else
            {
                string outOfStock = "The drink " + sodaList[3].drinkName + " is sold out.";
                string windowTitle = "Sold Out";
                MessageBox.Show(outOfStock, windowTitle);
            }
        }

        private void btnCream_Click(object sender, EventArgs e)
        {
            //Declare variable
            int CreamAmt;

            //Declaring a struct array and having it equal to data in sodaInfo
            VendingMachine[] sodaList = new VendingMachine[5];
            for (int i = 0; i < sodaList.Length; i++)
            {
                sodaList[i].drinkName = sodaInfo[i, 0];
                sodaList[i].beverageCost = double.Parse(sodaInfo[i, 1]);
                sodaList[i].numOfDrinks = int.Parse(sodaInfo[i, 2]);
            }

            //Have the amount of soda in the vending machine decrease
            CreamAmt = sodaList[4].numOfDrinks - 1;
            sodaInfo[4, 2] = CreamAmt.ToString();

            //If statement in case soda is sold out
            if (sodaList[4].numOfDrinks > 0)
            {
                txtCreamAmt.Text = CreamAmt.ToString();
                totalSales += sodaList[4].beverageCost;
                txtTotalSales.Text = "$" + totalSales.ToString("0.00");
            }
            else
            {
                string outOfStock = "The drink " + sodaList[4].drinkName + " is sold out.";
                string windowTitle = "Sold Out";
                MessageBox.Show(outOfStock, windowTitle);
            }
        }
    }
}
