using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders2._0
{
    internal class Invaders1 : Main // Propiedades y métodos de los Enemigos
    {
        // Se crea un constrcutor que va a recibir el valor del parametro y se lo va mandar
        // al costrcutor de la clase padre que permite recibir este parametro
        public Invaders1(int speedInvaders) : base(speedInvaders)
        {
        }
        //

        private bool MovBoss = true; // Movimiento del Boss
        public void Create(Control x) // Creación de Aliens
        {
            // GetUpper devuleve el último indice
            // de la primera dimención del array y
            // GetLower el primer indice del array
            for (int i = 0; i <= invaders.GetUpperBound(0); i++) 
            {
                invaders[i] = new PictureBox(); // Creo el picture
                invaders[i].Size = new Size(80, 60);
                invaders[i].SizeMode = PictureBoxSizeMode.StretchImage; // ajusto el tamaño de la imagen

                // Primera Fila
                if (i <= 11) // si recorro la pocision de 0 a 11
                {
                    invaders[i].Image = Properties.Resources.inavders; // obtengo la imagen
                    invaders[i].Left = Left; // pocisión inicial
                    invaders[i].Top = 50; // margen superior
                    invaders[i].Tag = "invaders"; // Contiene las propiedades del PictureBox

                    x.Controls.Add(base.invaders[i]); // agregando invaders a la lista
                    Left += 80; // avanzo de pocisión de los invaders
                }

                // Segunda fila
                if (i >= 11 && i <= 22) //recorro la pocision de 11 a 22
                {
                    invaders[i].Image = Properties.Resources.inavaders2; 
                    invaders[i].Left = Left - 960; // Por cada invader creado en la fila 1 se le suma
                                                   // a la pocisión inicial, se resta lo sumado para que vuelva a la pocisión inicla
                    invaders[i].Top = Top + 50; // margen superior
                    invaders[i].Tag = "invaders"; 

                    x.Controls.Add(base.invaders[i]); 
                    Left += 80;
                }
                // Tercera Fila
                if (i >= 22) // de 22 hasta el maximo 
                {
                    invaders[i].Size = new Size(80, 55); // Modifico las dimenciones

                    invaders[i].Image = Properties.Resources.invaders3; 
                    invaders[i].Left = Left - 1920; 
                    invaders[i].Top = Top + 120; 
                    invaders[i].Tag = "invaders"; 

                    x.Controls.Add(base.invaders[i]); 
                    Left += 80; 
                }
            }

        }

        public void Boss(Form f) // Creación del jefe final
        {
            boss.Size = new Size(120, 80);
            boss.SizeMode = PictureBoxSizeMode.StretchImage; 
            boss.Image = Properties.Resources.Boss; 
            boss.Location = new Point(500, 50);
            boss.Tag = "Boss";

            f.Controls.Add(base.boss); // agrego el picture a la instancia PictureBox del main
                                       // (base accedo a la clase padre)


            for (int i = 0; i <= invaders.GetUpperBound(0); i++) 
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
                boss.Left += 5; // movimietno del invader a la derecha

                if (boss.Left > 920) // dectecto cuando el Boss pasa las dimencions del form
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
