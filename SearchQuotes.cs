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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            comboMaterial.DataSource = Enum.GetNames(typeof(Materials));
            Materials selectedMaterial = (Materials)comboMaterial.SelectedIndex;
            listBox1.Items.Clear();

            foreach (DeskQuote quote in DeskQuote.deskQuotes)
            {
                if (quote.desk.material == selectedMaterial)
                {
                    listBox1.Items.Add(quote.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void comboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materials selectedMaterial = (Materials)comboMaterial.SelectedIndex;
            listBox1.Items.Clear();

            foreach (DeskQuote quote in DeskQuote.deskQuotes)
            {
                if (quote.desk.material == selectedMaterial)
                {
                    listBox1.Items.Add(quote.ToString());
                }
            }
        }
    }
}
