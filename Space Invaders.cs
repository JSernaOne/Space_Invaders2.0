using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Space_Invaders2._0
{
    public partial class Space_Invaders : Form // form 2, jugable
    {
        // instancias de las clases
        Tank loadtank = new Tank();
        Main main = new Main();
        Invaders1 invaders1;
        Vida vidatak = new Vida();

        public Space_Invaders(int speedInvaders) // inicio los niveles
        {
            InitializeComponent();

            invaders1 = new Invaders1(speedInvaders); // mando dato a los invaders

            loadtank.CreateTank(this); // creo el tanque en el form
            invaders1.Create(this); // creo los aliens en el form
            vidatak.VidaTank(this);
        }
        private int timer = 200;
        private void Space_Invaders_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Main_Tick(object sender, EventArgs e)
        {
            loadtank.MovementBullet(this); // bala
            invaders1.Movement(this); // invaders

            // Balas de lso Aliens
            timer -= 10; // conteo regresivo del timer
            if (timer < 1) // condición´para ejecutar 
            {
                timer = 200; // cada que el intervalo definido en el timer del form se ejecute lanzara un bala
                invaders1.Bullet(this, "BulletAliens"); // LLamo a la bala del alien
            }

            foreach (Control x in this.Controls) // propiedades de los cuadros 
            {
                // INVASIÓN
                if (x is PictureBox && (string)x.Tag == "invaders") // asigno la x a un Picture dandole un valor de string
                                                                    // y lo comparo con el tag de los invaders
                {

                    if (x.Bounds.IntersectsWith(loadtank.tank.Bounds)) // obtengo todos los valores del tamaño de x
                                                                       // y si se cruza con los invaders
                    {
                        Form2 form2 = new Form2();//INSTANCIO EL FORM DEL GAME OVER(cuando los aliens llegan al suelo)

                        Timer_Main.Stop();
                        form2.ShowDialog();//MOSTRAR EL FORM DE GAME OVER
                        this.Visible = false;

                    }

                    // wINNER
                    foreach (Control y in this.Controls) // asigno propiedades
                    {
                        // BALA TANQUE
                        if (y is PictureBox && (string)y.Tag == "BulletTank") // bala del tanque
                        {
                            if (y.Top < 0) // delete bala cuando pasa las dimensiones de la ventana
                            {
                                this.Controls.Remove(y);
                            }


                            if (y.Bounds.IntersectsWith(x.Bounds)) // válido que la bala intercepte al inavders
                            {

                                this.Controls.Remove(x); //remover el invader cuando la bala lo toca
                                this.Controls.Remove(y); // Remuevo bala

                                Score();
                            }

                        }

                    }

                }

                //BALA INVADERS
                if (x is PictureBox && (string)x.Tag == "BulletAliens") // bala Aliens
                {
                    x.Top += 5; // muevo bala invaders
                    if (x.Top > 640) // delete bala cuando pasa las dimensiones de la ventana
                    {
                        this.Controls.Remove(x);
                    }

                    if (x.Bounds.IntersectsWith(loadtank.tank.Bounds)) // obtengo todos los valores del tamaño de x
                                                                       // y si se cruza con los invaders
                    {
                        // QUITA VIDAS
                        vidatak.vida.Value -= 30; // RECUDCIR LA VIDA EN 30
                        this.Controls.Remove(x); // remover la bala cuando intercepta al tank

                        if (vidatak.vida.Value == 0)
                        {
                            Form2 form2 = new Form2();//INSTANCIAR EL FORM DEL GAME OVER(cuando la vida del tanque sea 0)

                            this.Controls.Remove(loadtank.tank);
                            Timer_Main.Stop();
                            form2.ShowDialog();//MOSTRAR EL FORM DE GAME OVER
                            this.Visible = false;

                        }

                    }
                }
            }


        }

        public void Score()
        {
            if (main.Score <= 33)
            {
                main.Score += 1; // suamr al score

                label2.Text = main.Score.ToString();
                Winner winner = new Winner(main.Score);

                if (main.Score == 33)
                {
                    Timer_Main.Stop();
                    winner.ShowDialog();
                    this.Visible = false;
                }
            }

            if (main.Score >= 33 && main.Score <= 66)
            {
                main.Score += 1; // sumar al score
                label2.Text = main.Score.ToString();
                Winner winner = new Winner(main.Score);
                if (main.Score == 66)
                {
                    Timer_Main.Stop();
                    winner.ShowDialog();
                    this.Visible = false;
                }

            }
          
        }
        private void MovimientoTank(object sender, KeyEventArgs e) // Teclas tanque
        {
            int x = loadtank.tank.Location.X; // Guardo la localización

            if (x >= 920) x = 920; // limite x por derecha
            if (x <= 5) x = 5; // limite x por la izquieda
            Point point = new Point(x, 520); // Localizo el punto
            loadtank.tank.Location = point; // redibujo el picturebox

            // mover tanque
            if (e.KeyCode == Keys.Left) // muevo a la izquierda
            {
                loadtank.tank.Left -= loadtank.Speed; // resto pixeles para que se mueva a la izquierda
            }
            if (e.KeyCode == Keys.Right) // muevo a la derecha
            {
                loadtank.tank.Left += loadtank.Speed; // agrego pixeles para que se mueva a la derecha

            }
            if (e.KeyCode == Keys.A) loadtank.tank.Left -= loadtank.Speed; // muevo a la izquierda
            if (e.KeyCode == Keys.D) loadtank.tank.Left += loadtank.Speed; // muevo a la dereccha



        }
        private void Disparo(object sender, MouseEventArgs e) // Generar bala
        {

            //timer -= 110; // resta al timer
            //if (timer <= 1) // condición
            //{
            //    timer = 200; //  tiempo en que se ejcutara (milisegundos)

                loadtank.Bullet(this, "BulletTank");

            //}

        }
        private void Space_Invaders_FormClosing(object sender, FormClosingEventArgs e) // Finalizar ejecución
        {
            Application.Exit(); // cerrar desde el boton de ventana
        }

        private void Label2_Click(object sender, EventArgs e) // Puntuación
        {

        }
    }
}
