using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Speelman
{
    class Desk
    {
        public int width;
        public int height;
        public int drawers;
        public Materials material;

        public Desk(string vwidth, string vheight, string vdrawers, Materials mat)
        {
            try
            {
                width = int.Parse(vwidth);
                height = int.Parse(vheight);
                drawers = int.Parse(vdrawers);
                material = mat;
            }
            catch
            {

            }
        }

    }


    
    
}

public enum Materials
{
    laminate = 100,
    oak = 200,
    rosewood = 300,
    veneer = 125,
    pine = 50
}

