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
    public partial class Form2 : Form // Game over
    {
        Space_Invaders space_Invaders = new Space_Invaders();
        menu menu = new menu();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            volver_intentarlo.Location = new Point(120, 233);
            button1.Location = new Point(330, 233);

        }

        private void volver_intentarlo_Click(object sender, EventArgs e) // reintenetar
        {

            space_Invaders.Show(); // llamo al form
            space_Invaders.Refresh(); // refresco todo el form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // Boton salir
        {
            menu.Show();
            this.Close();

        }

       
    }
}
