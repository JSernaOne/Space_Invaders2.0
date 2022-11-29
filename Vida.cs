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
            vidatank.Size = new Size(200, 15);
            vidatank.Location = new Point(800, 21);
            vidatank.Minimum = 0;
            vidatank.Maximum = 90;
            vidatank.Value = vidatank.Maximum;
            p.Controls.Add(vidatank);
            
        }

        public void VidaBoss(Form p)
        {
            vidaBoss.Size = new Size(200, 15);
            vidaBoss.Location = new Point(500, 21);
            vidaBoss.Minimum = 0;
            vidaBoss.Maximum = 120;
            vidaBoss.Value = vidaBoss.Maximum;

            p.Controls.Add(vidaBoss);

        }
    }
}
