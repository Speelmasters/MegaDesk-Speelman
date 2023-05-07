using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Speelman
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            LoadFile();
        }

        public void LoadFile()
        {
            if (File.Exists("example.txt"))
            {
                StreamReader reader = new StreamReader("DeskQuotes.txt");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    DeskQuote deskQuote = DeskQuote.FromCsv(line);
                    DeskQuote.deskQuotes.Add(deskQuote);
                }
                reader.Close();
            }
            else
            {
                // File does not exist, create it
                StreamWriter reader = File.CreateText("DeskQuotes.txt");
            }
            
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();

        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            Hide();
        }

        private void btnSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        private void SaveQuotes()
        {
            using (StreamWriter writer = new StreamWriter("DeskQuotes.txt"))
            {
                // Loop through the array and write each object to a new line in the file
                foreach (DeskQuote quote in DeskQuote.deskQuotes)
                {
                    writer.WriteLine($"{quote.firstName},{quote.lastName},{quote.orderDate},{quote.proTime},{quote.QuotePrice}," +
                                     $"{quote.desk.width},{quote.desk.height},{quote.desk.drawers},{quote.desk.material}");
                }
            }

        }
    }
}
