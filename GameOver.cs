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
    public partial class Form2 : Form // Winner
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Score = 0;
            menu menu = new menu();//INSTANCIAEL FORM DE EL MENU
            menu.Visible = true;
            this.Visible = false;
        }

        private void Volver_intentarlo_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Score = 0;
            Space_Invaders space_Invaders = new Space_Invaders(5);
            space_Invaders.Visible = true;
            this.Visible=false;
 
        }
        
        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Regresar(object sender, FormClosedEventArgs e) // Evente formClose
        {
            menu menu = new menu();//INSTANCIAEL FORM DE EL MENU
            menu.Visible = true;
        }
    }
}
