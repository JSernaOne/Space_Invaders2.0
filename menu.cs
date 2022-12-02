using System.Media;

namespace Space_Invaders2._0
{
    public partial class menu : Form // Ventana de inicio, Form 1
    {
        public menu()
        {
            InitializeComponent();

            // Inicilizó métodos
            Media();
            DesbloqearLevel(0); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DesbloqearLevel(int puntaje) // Función que permite desboquear los niveles
        {
            int score = puntaje;

            label4.Text = score.ToString();

            // Desbloqueó niveles comparando puntaje
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
       
        public void Media() // Música de la app
        {
            //SoundPlayer sp = new SoundPlayer(Properties.Resources.space_invaders);
            //sp.PlayLooping();;
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

        private void Exit(object sender, FormClosingEventArgs e) // Botón de ventana, cierra toda la ejecución del programa
        {
            Application.Exit();
        }

        // Niveles 1, 2 y 3
        private void NivelUno_Click(object sender, EventArgs e) 
        {

            Space_Invaders spaceInvaders = new Space_Invaders(5); // Se instancia el form y se le pasa los
                                                                  // valores de inicio al constructor

            spaceInvaders.Visible = true; // abro el form2
            this.Visible = false; // Oculto este form (menú)

        }

        private void NivelDos_Click(object sender, EventArgs e)
        {
            Space_Invaders spaceInvaders = new Space_Invaders(8); 
  
            spaceInvaders.Visible = true;
            this.Visible = false;

        }

        private void NivelTres_Click(object sender, EventArgs e)
        {
            Space_Invaders spaceInvaders = new Space_Invaders(12); 

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