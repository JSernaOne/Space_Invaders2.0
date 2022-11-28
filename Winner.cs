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
    public partial class Winner : Form
    {
        private int puntaje;
        public Winner(int score)
        {
            InitializeComponent();
            puntaje = score;
        }

        private void Regresar(object sender, FormClosedEventArgs e) // Evento formcClosed
        {
            menu menu = new menu();
            menu.Visible = true;
            this.Visible = false;
        }

        private void Volver_Click(object sender, EventArgs e) //bOTTON
        {
            menu menu = new menu();
            menu.Visible = true;
            menu.DesbloqearLevel(puntaje);

            this.Visible = false;
        }

        private void Winner_Load(object sender, EventArgs e)
        {

        }
    }
}
