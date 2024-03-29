﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders2._0
{
    internal class Tank : Main // player
    {
        public void CreateTank(Form f) // Creó tanque
        {
            tank.Size = new Size(80, 60);// diemenciones del picture
            tank.SizeMode = PictureBoxSizeMode.StretchImage; // ajusto la imagen 
            tank.Image = Properties.Resources.tank; // obtengo la imagen
            tank.Location = new Point(470, 520);
            tank.Name = "Invaders";

            f.Controls.Add(base.tank); // agrego el picture a la instancia PictureBox del main
                                       // (base accedo a la clase padre)

        }

        public void MovementBullet(Form f) // Mover Bala
        {

            foreach (Control x in f.Controls) // asigno propiedades a x
            {

                if (x is PictureBox && (string)x.Tag == "BulletTank") // Bala del tanque
                {
                    x.Top -= 12; // Movimiento de la bala

                }
            }

        }

    }
}
