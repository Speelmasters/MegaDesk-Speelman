using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Speelman
{
    public partial class DisplayQuote : Form
    {
        DeskQuote currentQuote;
        public DisplayQuote()
        {
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            currentQuote = DeskQuote.deskQuotes.Last();
            OrderDate.Text = currentQuote.orderDate.ToString();
            CustomerName.Text = currentQuote.firstName + " " + currentQuote.lastName;
            WidthAmount.Text = currentQuote.desk.width.ToString();
            HeightAmount.Text = currentQuote.desk.height.ToString();
            DrawerAmount.Text = currentQuote.desk.drawers.ToString();
            MaterialType.Text = currentQuote.desk.material.ToString();
            OrderTotal.Text = currentQuote.QuotePrice.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
