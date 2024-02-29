namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool player = true; // T = 1 F = 2
        int contadorPlayer1 = 0;
        int contadorPlayer2 = 0;
        string caminho1 = "A:\\Meus Documentos\\Área de Trabalho\\PrjC#\\JogodaVelhaMuitoVelho\\JogoDaVelha3\\WinFormsApp1\\img\\x.png";
        string caminho2 = "A:\\Meus Documentos\\Área de Trabalho\\PrjC#\\JogodaVelhaMuitoVelho\\JogoDaVelha3\\WinFormsApp1\\img\\O.png";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Image player1 = Image.FromFile(caminho1);
            Image player2 = Image.FromFile(caminho2);

            if (player)
            {
                pictureBox1.Image = player1;

            }
            else
            {
                pictureBox1.Image = player2;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Image player1 = Image.FromFile(caminho1);
            Image player2 = Image.FromFile(caminho2);

            if (player)
            {
                if (contadorPlayer1 < 3 && button.Name != "ow")
                {
                    button.Name = "xis";
                    button.BackgroundImage = player1;
                    button.BackgroundImageLayout = ImageLayout.Stretch;



                    player = false;
                    contadorPlayer1++;

                }
                else
                {

                    if (button.Name == "xis")
                    {
                        button.BackgroundImage = null;
                        contadorPlayer1--;
                        button.Name = null;
                    }


                }
            }
            else
            {
                if (contadorPlayer2 < 3 && button.Name != "xis")
                {
                    button.BackgroundImage = player2;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Name = "ow";


                    player = true;
                    contadorPlayer2++;

                }
                else
                {
                    if (button.Name == "ow")
                    {
                        button.BackgroundImage = null;
                        contadorPlayer2--;
                        button.Name = null;
                    }
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
