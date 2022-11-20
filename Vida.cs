using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders2._0
{
    internal class Vida:Main
    {
        public void VidaTank(Form p)
        {
            vida.Size = new Size(200, 15);
            vida.Location = new Point(800, 21);
            vida.Minimum = 0;
            vida.Maximum = 100;
            vida.Value = vida.Maximum;

            p.Controls.Add(vida);

            
        }
    }
}
