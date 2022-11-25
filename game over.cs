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
    public partial class Form2 : Form // Game Over
    {
        public Form2(int score)
        {
            InitializeComponent();

            puntaje = score;
        }

        int puntaje;
        private void Form2_Load_1(object sender, EventArgs e)
        {
            PictureBox1.Location=new Point(253, 90);
            Volver_intentarlo.Location = new Point(120, 200);
            Volver.Location = new Point(300, 200);
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click_1(object sender, EventArgs e)
        {
            menu menu = new menu();//INSTANCIAEL FORM DE EL MENU
            menu.Visible = true;
            menu.DesbloqearLevel(puntaje);
            this.Visible = false;
        }

        private void Volver_intentarlo_Click_1(object sender, EventArgs e)
        {
            Space_Invaders space_Invaders = new Space_Invaders();
            space_Invaders.Visible = true;
            this.Visible=false;
 
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
