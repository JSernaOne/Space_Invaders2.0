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
        public PictureBox tank; // almacenar tank
        public PictureBox[] invaders; // almacenar aliens y asigno el tamaño del array
        public PictureBox boss;
        public PictureBox bullet; // almacena las balas
        public Random random;
        public ProgressBar vidatank;
        public ProgressBar vidaBoss;

        // Propiedades
        private int left = 0; // pocisión en x inicial 
        private int top = 0; // pocision en y inicial
        private int speed = 0; // velocidad de movimiento
        private int speedInvader = 0; // intervalo de movimietno
        private static int score = 0; // Static me permite guardar los valores del puntaje entre cada form
        public Main() // base para iniciar
        {
            // Inicializo métodos y propiedades
            invaders = new PictureBox[33];
            tank = new PictureBox();
            bullet = new PictureBox();
            boss = new PictureBox();
            random = new Random();
            vidatank = new ProgressBar();
            vidaBoss = new ProgressBar();

            left = 50; // pocisión en x inicial 
            top = 50; // pocision en y inicial
            speed = 15; // velocidad de movimient
        }

        public Main(int speedInvader) // Constructor de niveles
        {
            // Inicializo métodos y propiedades
            invaders = new PictureBox[33];
            tank = new PictureBox();
            bullet = new PictureBox();
            boss = new PictureBox();
            random = new Random();
            vidatank = new ProgressBar();
            vidaBoss = new ProgressBar();

            left = 50; // pocisión en x inicial 
            top = 50; // pocision en y inicial
            speed = 15; // velocidad de movimient
            
            this.speedInvader = speedInvader; // velocidad del invader de acuerdo al  nivel
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

            if ((string)bullet.Tag == "BulletTank")  // Id de la bala del tanque
            {
                bullet.Image = Properties.Resources.bullet; // obtengo la imagen
            }

            if ((string)bullet.Tag == "BulletAliens") // Id de los Aliens
            {
                bullet.Image = Properties.Resources.bulletAlien; 
                int n = random.Next(0, 1000); // genero número aleatorios para variar la salida del disparo
                bullet.Location = new Point(n, 10); //  redibujo la bala
            }

            c.Controls.Add(bullet);

            bullet.BringToFront(); // traer al frente

        }

    }
}

