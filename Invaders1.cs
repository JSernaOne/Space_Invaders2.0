using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders2._0
{
    internal class Invaders1 : Main // manipulación de los enemigos
    {
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
                    invaders[i].Tag = "invaders";   // Innecesario - se puede utilizar para llamar a la lista como string

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

        public void Movement(Form f) // Movimietno invaders
        {
            for (int i = 0; i <= invaders.GetUpperBound(0); i++) // Recorrer la matriz
            {
                int x = invaders[i].Location.X; // lolización del alien en el eje x
                int y = invaders[i].Location.Y; // lolización del alien en el eje y

                int white = f.Width; // tamaño(ancho) del form

                invaders[i].Left += SpeedInvaders; // Movimiento de los invaders

                if (x > white) //  verificar la condición si el cuadro de imagen toca
                               //  el límite del ancho del formulario   
                {
                    invaders[i].Location = new Point(x - 1100, y + 65); // redibujo los invaders
                }
            }
        }


        //public void Point(Control x)
        //{

        //    if (x is PictureBox && (string)x.Tag == "BulletTag")
        //    {
        //        Remove(x);
        //    }

        //}
        //public void Remove(Control y)
        //{

        //    for (int i = 0; i <= invaders.GetUpperBound(0); i++)
        //    {
        //        if (y.Bounds.IntersectsWith(invaders[i].Bounds)) // obtengo todos los valores del tamaño de x
        //                                                         // y si se cruza con los invaders
        //        {
        //            y.Controls.Remove(invaders[i]); //remover el invader cuando la bala lo toca
        //        }
        //    }
        //}


    }


}
