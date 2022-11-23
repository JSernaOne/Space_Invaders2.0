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
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Location=new Point(253, 90);
            volver_intentarlo.Location = new Point(120, 200);
            Volver.Location = new Point(300, 200);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click_1(object sender, EventArgs e)
        {
            menu menu = new menu();//INSTANCIAEL FORM DE EL MENU
            menu.Show();
            this.Close();
        }

        private void volver_intentarlo_Click_1(object sender, EventArgs e)
        {
            Space_Invaders space_Invaders = new Space_Invaders();
            space_Invaders.Show();
            this.Close();
        }
    }
}
