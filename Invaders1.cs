using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders2._0
{
    internal class Invaders1 : Main // manipulación de los enemigos
    {
        public Invaders1(int speedInvaders) : base(speedInvaders) // inicia los valores para los niveles 
        {
        }

        private bool MovBoss = true;
        public void Create(Control x) // Creación de Aliens
        {
            for (int i = 0; i <= invaders.GetUpperBound(0); i++) // GetUpper devuleve el último indice
                                                                 // de la primera dimención del array y
                                                                 // GetLower el primer indice del array
            {
                invaders[i] = new PictureBox(); // Creo el picture
                invaders[i].Size = new Size(80, 60);// diemenciones del picture
                invaders[i].SizeMode = PictureBoxSizeMode.StretchImage; // ajusto la imagen 

                // Primera Fila
                if (i <= 11) // si recorro la pocision de 0 a 11
                {
                    invaders[i].Image = Properties.Resources.inavders; // obtengo la imagen
                    invaders[i].Left = Left; // pocisión inicial
                    invaders[i].Top = 50; // margen superior
                    invaders[i].Tag = "invaders";

                    x.Controls.Add(base.invaders[i]); // agregando invaders a la lista
                    Left += 80; // avanzo de pocisión de los invaders
                }

                // Segunda fila
                if (i >= 11 && i <= 22) //recorro la pocision de 11 a 22
                {
                    invaders[i].Image = Properties.Resources.inavaders2; // obtengo la imagen
                    invaders[i].Left = Left - 960; // pocisión inicial
                    invaders[i].Top = Top + 50; // margen superior
                    invaders[i].Tag = "invaders";   // se puede utilizar para llamar a la lista como string

                    x.Controls.Add(base.invaders[i]); // agregando invaders a la lista
                    Left += 80; // avanzo de pocisión de los invaders
                }
                // Tercera Fila
                if (i >= 22) // de 22 hasta el maximo 
                {
                    invaders[i].Size = new Size(80, 55);// diemenciones del picture

                    invaders[i].Image = Properties.Resources.invaders3; // obtengo la imagen
                    invaders[i].Left = Left - 1920; // pocisión inicial
                    invaders[i].Top = Top + 120; // margen superior
                    invaders[i].Tag = "invaders";   // se puede utilizar para llamar a la lista como string

                    x.Controls.Add(base.invaders[i]); // agregando invaders a la lista
                    Left += 80; // avanzo de pocisión de los invaders
                }
            }

        }

        public void Boss(Form f) // Creación del jefe final
        {
            boss.Size = new Size(120, 80);// diemenciones del picture
            boss.SizeMode = PictureBoxSizeMode.StretchImage; // ajusto la imagen 
            boss.Image = Properties.Resources.Boss; // obtengo la imagen
            boss.Location = new Point(500, 50);
            boss.Tag = "Boss";

            f.Controls.Add(base.boss); // agrego el picture a la instancia PictureBox del main
                                       // (base accedo a la clase padre)


            for (int i = 0; i <= invaders.GetUpperBound(0); i++) // GetUpper devuleve el último indice
                                                                 // de la primera dimención del array y
                                                                 // GetLower el primer indice del array
            {
                f.Controls.Remove(base.invaders[i]);
            }
        }
        public void Movement(Form f) // Movimietno invaders
        {
            int width = f.Width; // tamaño(ancho) del form

            // Invaders
            for (int i = 0; i <= invaders.GetUpperBound(0); i++) // Recorrer la matriz
            {
                int x = invaders[i].Location.X; // lolización del alien en el eje x
                int y = invaders[i].Location.Y; // lolización del alien en el eje y

                invaders[i].Left += SpeedInvaders; // Movimiento de los invadersaaa

                if (x > width) //  verificar la condición si el cuadro de imagen toca
                               //  el límite del ancho del formulario   
                {
                    invaders[i].Location = new Point(x - 1100, y + 65); // redibujo los invaders
                }
            }

            // Boss
            int w = boss.Location.X; // lolización del alien en el eje x
            int t = boss.Location.Y; // lolización del alien en el eje y

            if (MovBoss == true)
            {
                boss.Left += 5;

                if (boss.Left > 920) // x ded
                {
                    MovBoss = false;

                    Point point = new Point( boss.Left, boss.Top + 80); // Localizo el punto
                    boss.Location = point; // redibujo el picturebox
                }
            }
            if (MovBoss == false)
            {
                boss.Left -= 5;

                if (boss.Left < -10)
                {
                    MovBoss = true;
                }
            }


        }

    }


}
