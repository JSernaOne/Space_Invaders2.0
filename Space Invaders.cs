using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection;
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
        Vida vida = new Vida();
        public Space_Invaders(int speedInvaders) // Constructor que reibe parametros
        {
            InitializeComponent();

            invaders1 = new Invaders1(speedInvaders); // mando dato de la velocidad de los invaders

            label2.Text = main.Score.ToString(); // muestro conteo del puntaje

            //accedo a los métodos de las clases instanciadas
            loadtank.CreateTank(this); // creo el tanque en el form
            vida.VidaTank(this); // creo barra de vida
            invaders1.Create(this); // creo los aliens en el form

            if (main.Score >= 66) // condición única para el nivel 3
            {
                Boss.Visible = true; // mostrar Jefe final
                vida.VidaBoss(this);
                invaders1.Boss(this);
            }
        } 

        private int timer = 200; // invaders
        int timerDisparo = 200; // jugador

        private void Timer_Main_Tick(object sender, EventArgs e) // Timer principal en cargado
                                                                 // de iniciar las funciones del juego 
        {
            loadtank.MovementBullet(this); // bala
            invaders1.Movement(this); // invaders

            // ***Control** de la cadencia de las balas

            // Conteo regresivo para ejecutar 
            timerDisparo -= 20; // jugador
            timer -= 10; // invaders
            if (timer < 1)
            {
                timer = 200;
                invaders1.Bullet(this, "BulletAliens"); // creó la bala
            }

            // Funciones de eliminar, ganar y perder

            foreach (Control x in this.Controls) // asigno controles a la x
            {
                // Función de invación de los aliens

                if (x is PictureBox && (string)x.Tag == "invaders") // se asigna como PictureBox a la x y
                                                                    // las propiedades que contiene el tag
                {
                    // Bounds: Obtengo tamaño y ubicación
                    if (x.Bounds.IntersectsWith(loadtank.tank.Bounds)) // detecto cuando se intercepción
                    {
                        Form2 form2 = new Form2();//INSTANCIO EL FORM DEL GAME OVER(cuando los aliens llegan al suelo)

                        Timer_Main.Stop(); // detiene el Timer
                        this.Visible = false; // oculto este form
                        form2.ShowDialog();//MOSTRAR EL FORM DE GAME OVER

                    }

                    // **** Winner ****
                    foreach (Control y in this.Controls) // asigno propiedades
                    {
                        // BALA TANQUE
                        if (y is PictureBox && (string)y.Tag == "BulletTank")
                        {
                            if (y.Top < 0) // delete bala cuando pasa las dimensiones de la ventana
                            {
                                this.Controls.Remove(y);
                            }


                            if (y.Bounds.IntersectsWith(x.Bounds)) // válido que la bala intercepte al inavders
                            {

                                this.Controls.Remove(x); //remover el invader cuando la bala lo toca
                                this.Controls.Remove(y); // Remuevo bala

                                main.Score += 1; // suma al score
                                label2.Text = main.Score.ToString();
                                Score();
                            }

                        }

                    }

                }
                //###### BOSS ###########
                if (x is PictureBox && (string)x.Tag == "Boss")
                {
                    // INVASIÓN
                    if (x.Bounds.IntersectsWith(loadtank.tank.Bounds))
                    {
                        Form2 form2 = new Form2();

                        Timer_Main.Stop();
                        this.Visible = false;

                        form2.ShowDialog();

                    }

                    // Winner 
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "BulletTank") // BALA TANQUE
                        {
                            if (y.Top < 0) // delete bala cuando pasa las dimensiones de la ventana
                            {
                                this.Controls.Remove(y);
                            }


                            if (y.Bounds.IntersectsWith(x.Bounds)) // válido que la bala intercepte al boss
                            {
                                vida.vidaBoss.Value -= 10; // redusco progressBar cuando se intercepta
                                this.Controls.Remove(y); // Remuevo bala
                                main.Score += 20; // suma al score
                                label2.Text = main.Score.ToString();

                                if (vida.vidaBoss.Value == 0) // condicón para cuando se derrota al Boss
                                {
                                    Score();
                                }

                            }

                        }
                    }
                }

                //*** BALA INVADERS ***
                if (x is PictureBox && (string)x.Tag == "BulletAliens") // bala Aliens
                {
                    x.Top += 8; // muevo bala invaders
                    if (x.Top > 640) // delete bala cuando pasa las dimensiones de la ventana
                    {
                        this.Controls.Remove(x);
                    }

                    if (x.Bounds.IntersectsWith(loadtank.tank.Bounds))
                    {
                        // QUITAr VIDAS
                        vida.vidatank.Value -= 30; // RECUDCIR LA VIDA EN 30 del tanque
                        this.Controls.Remove(x); // remover la bala cuando intercepta al tank

                        if (vida.vidatank.Value == 0)
                        {
                            Form2 form2 = new Form2();//INSTANCIAR EL FORM DEL GAME OVER(cuando la vida del tanque sea 0)

                            this.Controls.Remove(loadtank.tank);
                            Timer_Main.Stop();
                            this.Visible = false;

                            form2.ShowDialog();//MOSTRAR EL FORM DE GAME OVER
                        }

                    }
                }
            }


        }

        public void Score() // Score
        {
            Winner winner = new Winner(main.Score); // le paso el valor del score al winner

            // Condiciones para cada nivel a razón del puntaje

            if (main.Score == 33)
            {
                Timer_Main.Stop();
                this.Visible = false;

                winner.ShowDialog();
            }

            if (main.Score == 66)
            {
                Timer_Main.Stop();
                this.Visible = false;

                winner.ShowDialog();
            }

            if (main.Score == 326)
            {
                Timer_Main.Stop();
                this.Visible = false;

                winner.ShowDialog();
                main.Score = 0; // reinicio puntaje al superar el nivel 3
            }


        }
        private void MovimientoTank(object sender, KeyEventArgs e) // Movimiento del tanque
        {
            int x = loadtank.tank.Location.X; // Guardo la localización

            if (x >= 920) x = 920; // limite x por derechaaa
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
            if (timerDisparo < 1) // condición´para ejecutar 
            {
                if(e.Button == MouseButtons.Left) 
                {
                    timerDisparo = 200; // reinicio del timer
                    loadtank.Bullet(this, "BulletTank");

                }
            }
        }

        private void Space_Invaders_FormClosing(object sender, FormClosingEventArgs e) // Finalizar ejecución
        {
            Application.Exit(); // cerrar desde el boton de ventana
        }

        private void Label2_Click(object sender, EventArgs e) // Puntuación
        {

        }

        private void Space_Invaders_Load(object sender, EventArgs e)
        {
            
        }
    }
}
