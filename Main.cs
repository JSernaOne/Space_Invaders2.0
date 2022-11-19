using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders2._0
{
    internal class Main
    {
        // Instancias
        public PictureBox tank; // almacenar bala 
        public PictureBox[] invaders; // almacenar aliens
        public PictureBox bullet; // almacena las balas
        public Random random;


        // Propiedades
        private int left = 0; // pocisión en x inicial 
        private int top = 0; // pocision en y inicial
        private int speed = 0; // velocidad de movimiento
        private int speedInvader = 0; // intervalo de movimietno
        private int score = 0;
        public Main()
        {
            tank = new PictureBox();
            invaders = new PictureBox[33];
            bullet = new PictureBox();
            random = new Random();

            left = 50; // pocisión en x inicial 
            top = 50; // pocision en y inicial
            speed = 10; // velocidad de movimient
            speedInvader = 5;
        }

        // Get y set
        public int Left { get => left; set => left = value; } // acceso a la variable, mostrar o obtener valor
        public int Top { get => top; set => top = value; } // acceso
        public int Speed // acceso a la variable, mostrar o obtener valor
        {
            get { return speed; }
            set { this.Speed = value; }
        }
        public int SpeedInvaders { get => speedInvader; set => speedInvader = value; }

        public int Score { get=> score; set => score = value; }
        public void Bullet(Control c, String Tag) // Creación de balas del tanque
        {

            int x = tank.Left + 35; // localización
            int y = tank.Top - 20; // localización

            bullet = new PictureBox(); // Creo el picture
            bullet.Size = new Size(7, 15);// diemenciones del pictureBox
            bullet.SizeMode = PictureBoxSizeMode.StretchImage; // ajusto la imagen
            bullet.Location = new Point(x, y); // Localización donde se va a dibujar el bullet
            bullet.Tag = Tag;// asignación de tag(id) para validar:

            if ((string)bullet.Tag == "BulletTank")  // Id de la bala
            {
                bullet.Image = Properties.Resources.bullet; // obtengo la imagen
                bullet.Top -= 7; // movimiento
            }

            if ((string)bullet.Tag == "BulletAliens") // Id del Tanque
            {
                bullet.Image = Properties.Resources.bulletAlien; // obtengo la imagen
                int n = random.Next(0, 1000); // genero número aleatorios para variar la salida del disparo
                bullet.Location = new Point(n, 10); //  redibujo la bala
            }

            c.Controls.Add(bullet);

            bullet.BringToFront(); // traer al frente

        }
        public void GameOver(String message, Form p) //game over (termina la partida)
        {
            foreach (PictureBox i in invaders) // recorro cada elemento del picture
            {
                p.Controls.Remove(i); // elimino los elementos

            }


            MessageBox.Show(message); // mensaje 
        }
    }s
}

