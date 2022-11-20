using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_load(object sender, EventArgs e)
        {
            pictureBox1.Location=new Point(330, 82);
            button1.Location = new Point(154, 263);
            

        }
        private void Form2_load(object sender, KeyEventArgs e)//INSTANCIAR EL FORM DE GAME OVER
        {
            Form2 gameover = new Form2();
            gameover.ShowDialog();
            this.Hide();
        }
        private void intentarlo()//BOTON DE PARA VOLVER A JUGAR (un nuevo intento)
        {
            Space_Invaders space_Invaders=new Space_Invaders();
            space_Invaders.Show();
            this.Hide();

        }

        private void salir()//  BOTON DE SALIR AL MENU EN EL GAME OVER
        {
            menu menu=new menu();//INSTANCIAEL FORM DE EL MENU
            menu.Show();
            this.Hide();
            

        }
    }
}
