using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Speelman
{
    class DeskQuote
    {

        static public List<DeskQuote> deskQuotes = new List<DeskQuote>();

        public Desk desk;
        public string firstName;
        public string lastName;
        public ProductionTimes proTime;
        public DateTime orderDate;
        public decimal QuotePrice;



    static public DeskQuote FromCsv(string csv)
    {
        try 
        {
                string[] values = csv.Split(',');

                string vfirstName = values[0];
                string vlastName = values[1];
                ProductionTimes vproTime = (ProductionTimes)Enum.Parse(typeof(ProductionTimes),values[2]);
                DateTime vorderDate = DateTime.Parse(values[3]);



                string vwidth = values[5];
                string vheight = values[6];
                string vdrawers = values[7];
                Materials mat = (Materials)Enum.Parse(typeof(Materials), values[8]);
                

                return new DeskQuote(vfirstName, vlastName, vproTime, vorderDate, 
                                     vwidth, vheight, vdrawers, mat); //width, depth, drawers, material, rushDays, customerName
            }
        catch
        {
                return null;
        }
        

        
        }

        public DeskQuote(string vfirstName, string vlastName, ProductionTimes productionTimes, DateTime quoteDate, 
                         string width, string height, string drawers, Materials mat)
        {
            firstName = vfirstName;
            lastName = vlastName;
            proTime = productionTimes;
            orderDate = quoteDate;

            desk = new Desk(width, height, drawers, mat);

            QuotePrice = CalculateQuotePrice();
        }


        public decimal CalculateQuotePrice()
    {
        decimal basePrice = 200;
        decimal surfaceArea = desk.width * desk.height;
        decimal drawerCost = desk.drawers * 50;
        decimal surfaceMaterialCost = GetSurfaceMaterialCost();
        decimal shippingCost = GetShippingCost();

        decimal quotePrice = basePrice + surfaceArea + drawerCost + surfaceMaterialCost + shippingCost;

        return quotePrice;
    }

        public override string ToString()
        {
            string output = $"Customer Name: {firstName} {lastName}\n" +
                            $"Quote Date: {orderDate}\n" +
                            $"Desk Material: {desk.material}\n" +
                            $"Desk Width: {desk.width}\"\n" +
                            $"Desk Depth: {desk.height}\"\n" +
                            $"Number of Drawers: {desk.drawers}\n" +
                            $"Rush Order: {proTime}\n" +
                            $"Total Cost: ${QuotePrice}\n";
            return output;
        }





        private decimal GetSurfaceMaterialCost()
    {
        decimal cost = 0;

        switch (desk.material)
        {
            case Materials.laminate:
                cost = 100;
                break;
            case Materials.oak:
                cost = 200;
                break;
            case Materials.rosewood:
                cost = 300;
                break;
            case Materials.veneer:
                cost = 125;
                break;
            case Materials.pine:
                cost = 50;
                break;
            default:
                break;
        }

        return cost;
    }

        // Method to get cost of desk shipping
    private decimal GetShippingCost()
        {
            decimal[,] shippingCosts = new decimal[3, 3]
            {
        { 60M, 70M, 80M },
        { 40M, 50M, 60M },
        { 30M, 35M, 40M }
            };

            decimal surfaceArea = desk.width * desk.height;

            int sizeIndex = 0;
            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                sizeIndex = 1;
            }
            else if (surfaceArea > 2000)
            {
                sizeIndex = 2;
            }

            int shippingIndex = (int)proTime;
            if(shippingIndex == 3)
            {
                return 0;
            }
            else
            {
                return shippingCosts[sizeIndex, shippingIndex];
            }
        }

    }
}


public enum ProductionTimes
{
    three,
    five,
    seven,
    fourteen
}