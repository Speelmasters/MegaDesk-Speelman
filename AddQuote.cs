using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Speelman
{
    public partial class AddQuote : Form
    {
        MainMenu viewMainMenu;
        public AddQuote()
        {
            InitializeComponent();
            viewMainMenu = (MainMenu)Tag;
            comboMaterial.DataSource = Enum.GetNames(typeof(Materials));
            comboProduction.DataSource = Enum.GetNames(typeof(ProductionTimes));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            viewMainMenu.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidateForms())
            {
                DeskQuote quote = new DeskQuote(textbFirstName.Text, textbLastName.Text, (ProductionTimes)comboProduction.SelectedIndex, DateTime.Now,
                                                textbWidth.Text, textbHeight.Text, textbDrawers.Text, (Materials)comboMaterial.SelectedIndex);
                DeskQuote.deskQuotes.Add(quote);

                DisplayQuote viewDisplayQuote = new DisplayQuote();
                viewDisplayQuote.Tag = this.Tag;
                viewDisplayQuote.Show((MainMenu)this.Tag);
                Hide();
            }
        }

        private bool ValidateForms()
        {
            //Reset colors
            textbFirstName.BackColor = Color.White;
            textbLastName.BackColor = Color.White;
            textbWidth.BackColor = Color.White;
            textbHeight.BackColor = Color.White;
            textbDrawers.BackColor = Color.White;


            if (textbFirstName.Text.Length < 1)
            {
                textbFirstName.BackColor = Color.Red;
                return false;
            }
            else if (textbLastName.Text.Length < 1)
            {
                textbLastName.BackColor = Color.Red;
                return false;
            }
            else if (textbWidth.Text.Length < 2)
            {
                textbWidth.BackColor = Color.Red;
                return false;
            }
            else if (textbHeight.Text.Length < 1)
            {
                textbHeight.BackColor = Color.Red;
                return false;
            }
            else if (textbDrawers.Text.Length < 1)
            {
                textbDrawers.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        private void textbFirstName_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            textbFirstName.Text = rgx.Replace(textbFirstName.Text, "");
        }


        private void textbLastName_TextChanged(object sender, EventArgs e)
        {

            Regex rgx = new Regex("[^a-zA-Z]");
            textbLastName.Text = rgx.Replace(textbLastName.Text, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            textbWidth.Text = rgx.Replace(textbWidth.Text, "");

        }

        private void textbWidth_Leave(object sender, EventArgs e)
        {
            int tempWidth;
            try
            {
                tempWidth = Int32.Parse(textbWidth.Text);
                if (tempWidth < 24 || tempWidth > 96)
                {
                    textbWidth.Text = "24";
                }
            }

            catch
            {
                textbWidth.Text = "24";
            }
        }



        private void textbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            int value;
            if (int.TryParse(textbHeight.Text + e.KeyChar, out value))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textbHeight_Leave(object sender, EventArgs e)
        {
            int tempWidth;
            try
            {
                tempWidth = Int32.Parse(textbHeight.Text);
                if (tempWidth < 12 || tempWidth > 36)
                {
                    textbHeight.Text = "12";
                }
            }

            catch
            {
                textbHeight.Text = "12";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            int tempWidth;
            try
            {
                tempWidth = Int32.Parse(textbDrawers.Text);
                if (tempWidth < 0 || tempWidth > 7)
                {
                    textbDrawers.Text = "0";
                }
            }

            catch
            {
                textbDrawers.Text = "0";
            }
        }

        private void textbDrawers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            int value;
            if (int.TryParse(textbDrawers.Text + e.KeyChar, out value))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboProduction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
