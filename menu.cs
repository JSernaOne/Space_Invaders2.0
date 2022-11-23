using System.Media;

namespace Space_Invaders2._0
{
    public partial class menu : Form // Ventana de inicio
    {
        public menu()
        {
            InitializeComponent();
            Media();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(286, 134);
            label2.Location = new Point(343, 291);
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
            Space_Invaders spaceInvaders = new Space_Invaders(); // Instancio el form2
            if (e.KeyCode == Keys.Enter) // Verfiico pulsación
            {
                spaceInvaders.Show(); // abro el form2
                this.Hide(); // Oculto el form1
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}