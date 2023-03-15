using System.Media;
namespace CarGame
{
    public partial class Form1 : Form
    {
        
        
        
        SoundPlayer soundPlayer=new SoundPlayer(soundLocation: @"CarGame\music.wav");
        SoundPlayer soundPlayer2 = new SoundPlayer(soundLocation: @"CarGame\carpti.wav");
        
        
        int yolhizi = 15;
        int trafikhizi = 15;
        int oyuncuhizi = 12;
        int skor;
        int carImage;

        Random rand= new Random();
        Random carPosition = new Random();
        bool goleft, goright;

        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void restartGame(object sender, EventArgs e)
        {
            Oyunuyenidenbaslat();
            
        }
        private void Oyunuyenidenbaslat()
        {
            
            //soundPlayer.Play();
            btnStart.Enabled = false;   
            explosion.Visible = false;
            award.Visible = false;
            goleft=false;
            goright=false;
            skor=0;
            award.Image = Properties.Resources.hosgeldiin;
            yolhizi = 12;
            trafikhizi = 15;
            A1.Top = carPosition.Next(200, 500) * -1;
            A1.Left=carPosition.Next(5, 200);
            A2.Top = carPosition.Next(200, 500) * -1;
            A2.Left=carPosition.Next(245, 422);
            gameTimer.Start();
        }
        
        
        private void gameTimerEvent(object sender, EventArgs e)
        {
            textScore.Text = "Score: " + skor;
            skor++;
            if(goleft == true && player.Left > 10)
            {
                player.Left -= oyuncuhizi;
            }
            if(goright == true && player.Right < 415)
            {
                player.Left += oyuncuhizi;
            }

            roadtrack1.Top += yolhizi;
            roadtruck2.Top += yolhizi;

            if(roadtruck2.Top > 519)
            {
                roadtruck2.Top = -519;
            }
            if(roadtrack1.Top > 519)
            {
                roadtrack1.Top = -519;
            }
            A1.Top += trafikhizi;
            A2.Top += oyuncuhizi;
            
            if(A1.Top > 530)
            {
                Arabalaridegistir(A1);
            }
            if(A2.Top >530)
            {
                Arabalaridegistir(A2);
            }
            if(player.Bounds.IntersectsWith(A1.Bounds)|| player.Bounds.IntersectsWith(A2.Bounds))
            {
                Oyunbitti();
            }
            if(skor>40 && skor<200)
            {
                award.Image = Properties.Resources.bronze12;
            }
            if (skor > 200 && skor < 500)
            {
                
                award.Image = Properties.Resources.amator;
                yolhizi = 20;
                trafikhizi = 22;
            }
            if(skor>500 && skor<1000)
            {
                award.Image = Properties.Resources.yaripro;
                yolhizi = 22;
                trafikhizi = 24;
            }
            if(skor > 1000 && skor <2000)
            {
                award.Image = Properties.Resources.pro;
                yolhizi = 24;
                trafikhizi = 26;
            }
            if (skor > 2000)
            {
                award.Image = Properties.Resources.efsane;
                yolhizi = 27;
                trafikhizi = 25;
            }
        }
        private void Oyunbitti()
        {
            
            soundPlayer.Stop();
            //soundPlayer2.Play();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            btnStart.Enabled = true;
        }
        private void Arabalaridegistir(PictureBox tempCar)
        {
            carImage = rand.Next(1, 7);
            switch(carImage)
            {
                case 1:
            tempCar.Image = Properties.Resources.ambulance;
            break;
               case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;
            if((string)tempCar.Tag=="carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200); 
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roadtruck2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
    }
}