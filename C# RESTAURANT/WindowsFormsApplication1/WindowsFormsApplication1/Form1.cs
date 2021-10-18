using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const double Price_Chicken_Sandwitch = 50;
        const double Price_Cheese_Sandwitch = 40;
        const double Price_Vege_Patties = 30;
        const double Price_Burger = 90;
        const double Price_Fries = 85;
        const double Price_Chicken_Salad = 100;
        const double Price_Tea = 50;
        const double Price_Coffee = 45;
        const double Price_Orange = 60;
        const double Price_Bottle_Water = 60;
        const double Price_Choco_Milk_Shake = 120;
        const double Price_Vanila_Shake = 100;
        const double Price_Choco_Muffin = 130;
        const double Price_Ice_Cream = 80;
        const double Price_Pudding = 70;
        const double Price_Fruit_Salad = 80;
        const double Price_Apple_Cake = 40;
        const double Price_Pineapple_Sticks = 35;
        const double Tax_Rate = 4;

        double iTax, iSubTotal, iTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iEXIT;

            iEXIT = MessageBox.Show("Are you sure? Do you want to EXIT?", "C# RESTAURANT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iEXIT == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //=======================================ResetTextBoxes======================================================

        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }

        //==================================ResetCheckBoxes===============================================

        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //======================================EnableTextBoxes===================================================

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Payment_Method.Items.Add(" ");
            cmb_Payment_Method.Items.Add("Cash");
            cmb_Payment_Method.Items.Add("Master Card");
            cmb_Payment_Method.Items.Add("Visa Card");
            cmb_Payment_Method.Items.Add("Debit Card");

            EnableTextBoxes();
        }

        private void ch_Chicken_Sandwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Chicken_Sandwitch.Checked == true)
            {
                txt_Chicken_Sandwitch.Enabled = true;
                txt_Chicken_Sandwitch.Text = "";
                txt_Chicken_Sandwitch.Focus();
            }
            else
            {
                txt_Chicken_Sandwitch.Enabled = false;
                txt_Chicken_Sandwitch.Text = "0";
            }
        }

        private void ch_Cheese_Sandwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Cheese_Sandwitch.Checked == true)
            {
                txt_Cheese_Sandwitch.Enabled = true;
                txt_Cheese_Sandwitch.Text = "";
                txt_Cheese_Sandwitch.Focus();
            }
            else
            {
                txt_Cheese_Sandwitch.Enabled = false;
                txt_Cheese_Sandwitch.Text = "0";
            }
        }

        private void ch_Vege_Patties_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Vege_Patties.Checked == true)
            {
                txt_Vege_Patties.Enabled = true;
                txt_Vege_Patties.Text = "";
                txt_Vege_Patties.Focus();
            }
            else
            {
                txt_Vege_Patties.Enabled = false;
                txt_Vege_Patties.Text = "0";
            }
        }

        private void ch_Burger_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Burger.Checked == true)
            {
                txt_Burger.Enabled = true;
                txt_Burger.Text = "";
                txt_Burger.Focus();
            }
            else
            {
                txt_Burger.Enabled = false;
                txt_Burger.Text = "0";
            }
        }

        private void ch_Fries_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Fries.Checked == true)
            {
                txt_Fries.Enabled = true;
                txt_Fries.Text = "";
                txt_Fries.Focus();
            }
            else
            {
                txt_Fries.Enabled = false;
                txt_Fries.Text = "0";
            }
        }

        private void ch_Chicken_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Chicken_Salad.Checked == true)
            {
                txt_Chicken_Salad.Enabled = true;
                txt_Chicken_Salad.Text = "";
                txt_Chicken_Salad.Focus();
            }
            else
            {
                txt_Chicken_Salad.Enabled = false;
                txt_Chicken_Salad.Text = "0";
            }
        }

        private void ch_Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Tea.Checked == true)
            {
                txt_Tea.Enabled = true;
                txt_Tea.Text = "";
                txt_Tea.Focus();
            }
            else
            {
                txt_Tea.Enabled = false;
                txt_Tea.Text = "0";
            }
        }

        private void ch_Coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Coffee.Checked == true)
            {
                txt_Coffee.Enabled = true;
                txt_Coffee.Text = "";
                txt_Coffee.Focus();
            }
            else
            {
                txt_Coffee.Enabled = false;
                txt_Coffee.Text = "0";
            }
        }

        private void ch_Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Orange.Checked == true)
            {
                txt_Orange.Enabled = true;
                txt_Orange.Text = "";
                txt_Orange.Focus();
            }
            else
            {
                txt_Orange.Enabled = false;
                txt_Orange.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_Bottle_Water.Enabled = true;
                txt_Bottle_Water.Text = "";
                txt_Bottle_Water.Focus();
            }
            else
            {
                txt_Bottle_Water.Enabled = false;
                txt_Bottle_Water.Text = "0";
            }
        }

        private void ch_Choco_Milk_Shake_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Choco_Milk_Shake.Checked == true)
            {
                txt_Choco_Milk_Shake.Enabled = true;
                txt_Choco_Milk_Shake.Text = "";
                txt_Choco_Milk_Shake.Focus();
            }
            else
            {
                txt_Choco_Milk_Shake.Enabled = false;
                txt_Choco_Milk_Shake.Text = "0";
            }
        }

        private void ch_Vanila_Shake_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Vanila_Shake.Checked == true)
            {
                txt_Vanila_Shake.Enabled = true;
                txt_Vanila_Shake.Text = "";
                txt_Vanila_Shake.Focus();
            }
            else
            {
                txt_Vanila_Shake.Enabled = false;
                txt_Vanila_Shake.Text = "0";
            }
        }

        private void ch_Choco_Muffin_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Choco_Muffin.Checked == true)
            {
                txt_Choco_Muffin.Enabled = true;
                txt_Choco_Muffin.Text = "";
                txt_Choco_Muffin.Focus();
            }
            else
            {
                txt_Choco_Muffin.Enabled = false;
                txt_Choco_Muffin.Text = "0";
            }
        }

        private void ch_Ice_Cream_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Ice_Cream.Checked == true)
            {
                txt_Ice_Cream.Enabled = true;
                txt_Ice_Cream.Text = "";
                txt_Ice_Cream.Focus();
            }
            else
            {
                txt_Ice_Cream.Enabled = false;
                txt_Ice_Cream.Text = "0";
            }
        }

        private void ch_Pudding_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Pudding.Checked == true)
            {
                txt_Pudding.Enabled = true;
                txt_Pudding.Text = "";
                txt_Pudding.Focus();
            }
            else
            {
                txt_Pudding.Enabled = false;
                txt_Pudding.Text = "0";
            }
        }

        private void ch_Fruit_Salad_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Fruit_Salad.Checked == true)
            {
                txt_Fruit_Salad.Enabled = true;
                txt_Fruit_Salad.Text = "";
                txt_Fruit_Salad.Focus();
            }
            else
            {
                txt_Fruit_Salad.Enabled = false;
                txt_Fruit_Salad.Text = "0";
            }
        }

        private void cmb_Payment_Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Payment_Method.Text == "Cash")
            {
                txt_Cash.Enabled = true;
                txt_Cash.Text = "";
                txt_Cash.Focus();
            }
            else
            {
                txt_Cash.Enabled = false;
                txt_Cash.Text = "0";
            }
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            double[] Item_Cost = new double[18];
            Item_Cost[0] = Convert.ToDouble(txt_Chicken_Sandwitch.Text) * Price_Chicken_Sandwitch;
            Item_Cost[1] = Convert.ToDouble(txt_Cheese_Sandwitch.Text) * Price_Cheese_Sandwitch;
            Item_Cost[2] = Convert.ToDouble(txt_Vege_Patties.Text) * Price_Vege_Patties;
            Item_Cost[3] = Convert.ToDouble(txt_Burger.Text) * Price_Burger;
            Item_Cost[4] = Convert.ToDouble(txt_Fries.Text) * Price_Fries;
            Item_Cost[5] = Convert.ToDouble(txt_Chicken_Salad.Text) * Price_Chicken_Salad;
            Item_Cost[6] = Convert.ToDouble(txt_Tea.Text) * Price_Tea;
            Item_Cost[7] = Convert.ToDouble(txt_Coffee.Text) * Price_Coffee;
            Item_Cost[8] = Convert.ToDouble(txt_Orange.Text) * Price_Orange;
            Item_Cost[9] = Convert.ToDouble(txt_Bottle_Water.Text) * Price_Bottle_Water;
            Item_Cost[10] = Convert.ToDouble(txt_Vanila_Shake.Text) * Price_Vanila_Shake;
            Item_Cost[11] = Convert.ToDouble(txt_Choco_Muffin.Text) * Price_Choco_Muffin;
            Item_Cost[12] = Convert.ToDouble(txt_Ice_Cream.Text) * Price_Ice_Cream;
            Item_Cost[13] = Convert.ToDouble(txt_Pudding.Text) * Price_Pudding;
            Item_Cost[14] = Convert.ToDouble(txt_Fruit_Salad.Text) * Price_Fruit_Salad;
            Item_Cost[15] = Convert.ToDouble(txt_Apple_Cake.Text) * Price_Apple_Cake;
            Item_Cost[16] = Convert.ToDouble(txt_Pineapple_Sticks.Text) * Price_Pineapple_Sticks;
            Item_Cost[17] = Convert.ToDouble(txt_Choco_Milk_Shake.Text) * Price_Choco_Milk_Shake;

            double cost, iChange;

            if (cmb_Payment_Method.Text == "Cash")
            {
                iSubTotal = Item_Cost[0] + Item_Cost[1] + Item_Cost[2] + Item_Cost[3] + Item_Cost[4] + Item_Cost[5] +
                    Item_Cost[6] + Item_Cost[7] + Item_Cost[8] + Item_Cost[9] + Item_Cost[10] + Item_Cost[11] + 
                    Item_Cost[12] + Item_Cost[13] + Item_Cost[14] + Item_Cost[15] + Item_Cost[16]+Item_Cost[17];

                lbl_Sub_Total.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate)/100;
                lbl_Tax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lbl_Total.Text = Convert.ToString(iTotal);

                iChange = Convert.ToDouble(txt_Cash.Text);
                cost = iChange-(iTax + iSubTotal);
                lbl_Change.Text = Convert.ToString(cost);

                lbl_Change.Text = string.Format("{0:C}", cost);
                lbl_Tax.Text = string.Format("{0:C}", iTax);
                lbl_Sub_Total.Text = string.Format("{0:C}", iSubTotal);
                lbl_Total.Text = string.Format("{0:C}", iTotal);
            }

            else
            {
                iSubTotal = Item_Cost[0] + Item_Cost[1] + Item_Cost[2] + Item_Cost[3] + Item_Cost[4] + Item_Cost[5] +
                    Item_Cost[6] + Item_Cost[7] + Item_Cost[8] + Item_Cost[9] + Item_Cost[10] + Item_Cost[11] +
                    Item_Cost[12] + Item_Cost[13] + Item_Cost[14] + Item_Cost[15] + Item_Cost[16] + Item_Cost[17];

                lbl_Sub_Total.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                lbl_Tax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                lbl_Total.Text = Convert.ToString(iTotal);

                lbl_Tax.Text = string.Format("{0:C}", iTax);
                lbl_Sub_Total.Text = string.Format("{0:C}", iSubTotal);
                lbl_Total.Text = string.Format("{0:C}", iTotal);
            }

        }

        private void txt_Bottle_Water_TextChanged(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            

         
        }

        private void ch_Apple_Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Apple_Cake.Checked == true)
            {
                txt_Apple_Cake.Enabled = true;
                txt_Apple_Cake.Text = "";
                txt_Apple_Cake.Focus();
            }
            else
            {
                txt_Apple_Cake.Enabled = false;
                txt_Apple_Cake.Text = "0";
            }
        }

        private void ch_Pineapple_Sticks_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Pineapple_Sticks.Checked == true)
            {
                txt_Pineapple_Sticks.Enabled = true;
                txt_Pineapple_Sticks.Text = "";
                txt_Pineapple_Sticks.Focus();
            }
            else
            {
                txt_Pineapple_Sticks.Enabled = false;
                txt_Pineapple_Sticks.Text = "0";
            }
        }
    }
}
