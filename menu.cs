using System.Media;

namespace Space_Invaders2._0
{
    public partial class menu : Form // Ventana de inicio
    {
        public menu()
        {
            InitializeComponent();
            Media();
            DesbloqearLevel(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DesbloqearLevel(int puntaje)
        {
            int score = puntaje;

            label4.Text = score.ToString();

            if (score == 33)
            {
                NivelUno.Enabled = false;
                NivelDos.Enabled = true;
            }
            if (score == 66)
            {
                NivelUno.Enabled = false;
                NivelTres.Enabled = true;
            }
        }

        public void Media()
        {
            //SoundPlayer sp = new SoundPlayer(Properties.Resources.space_invaders);
            //sp.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Inicio(object sender, KeyEventArgs e)
        {

        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NivelUno_Click(object sender, EventArgs e) // nIVEL 1
        {

            Space_Invaders spaceInvaders = new Space_Invaders(5); // Instancio el form2

            spaceInvaders.Visible = true; // abro el form2
            this.Visible = false; // Oculto el form1

        }

        private void NivelDos_Click(object sender, EventArgs e) //Nivel 2
        {
            Space_Invaders spaceInvaders = new Space_Invaders(8); // Instancio el form2
  
            spaceInvaders.Visible = true;
            this.Visible = false;

        }

        private void NivelTres_Click(object sender, EventArgs e) // Nivel 3
        {
            Space_Invaders spaceInvaders = new Space_Invaders(12); // Instancia del form 2

            spaceInvaders.Visible = true;
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}