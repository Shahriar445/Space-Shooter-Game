using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

/*
 *                                                  International University of Business Agriculture and Technology
 *                                            
 *                                                  Project Name: Space shooter 
 *                                                  Department: BCSE
 *                                                  Semester:4th year
 *                                                  Owner Name: Md Shahriar Haque
 *                                                  Technology: C#/Asp.net Framework
 *                                                  
 *                                                  


*/

namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] stars;
        int backgroundspeed;
        int playerSpeed;


        Random rnd;

        PictureBox[] munitions;
        int MunitionSpeed;


        PictureBox[] enemies;
        int enemieSpeed;

        PictureBox[] enemiesMunition;
        int enemieMunitionSpeed;

        // For Design part 

        int score;
        int level;
        int deficulty;
        bool pause;
        bool gameIsOver;




        public Form1()
        {
            InitializeComponent();
        }
    

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            deficulty = 9;


            backgroundspeed = 4;
            playerSpeed = 4;
            MunitionSpeed = 20;
            enemieSpeed = 4;
            enemieMunitionSpeed = 4;
            munitions = new PictureBox[3];

            // Load Images 
            Image munition = Image.FromFile(@"asserts\munition.png");
            Image enemi1 = Image.FromFile(@"asserts\\E1.png");
            Image enemi2 = Image.FromFile(@"asserts\\E2.png");
            Image enemi3 = Image.FromFile(@"asserts\\E3.png");
            Image boss1 = Image.FromFile(@"asserts\\Boss1.png");
            Image boss2 = Image.FromFile(@"asserts\\Boss2.png");


            enemies = new PictureBox[10];

            // Initialiase EnemisPicture boxes 
            for (int i= 0;i< enemies.Length; i++)
            {
                enemies[i]= new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle= BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }
            enemies[0].Image = boss1;
            enemies[1].Image = enemi1;
            enemies[2].Image = enemi2;
            enemies[3].Image = enemi3;
            enemies[4].Image = enemi2;
            enemies[5].Image = enemi1;
            enemies[6].Image = enemi3;
            enemies[7].Image = enemi1;
            enemies[8].Image = enemi2;
            enemies[9].Image = boss2;




            for (int i = 0; i<munitions.Length;i++)
            {
                munitions[i]= new PictureBox();
                munitions[i].Size = new Size(8, 8); // pixel size fixed
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            // Create WindowsMediaPlayer
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            // Load all song from local file 
            gameMedia.URL = "songs//GameSong.mp3";
            shootgMedia.URL = "songs//shoot.mp3";
            explosion.URL = "songs//boom.mp3";

            //Setup Song setting 
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 2;
            explosion.settings.volume = 6;


            stars = new PictureBox[15];
            rnd = new Random();

            

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 588), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(4, 4);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);

            }
            //Enemis Munition 
            enemiesMunition = new PictureBox[10];

            for (int i=0;i<enemiesMunition.Length;i++)
            {
                enemiesMunition[i] =new PictureBox();
                enemiesMunition[i].Size=new Size(2, 25);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }
            gameMedia.controls.play();

        }

        private void MoveBgTimer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right<575)
            {
                Player.Left += playerSpeed;
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {

            if (Player.Left > 10)
            {
                Player.Left-= playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top-= playerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top+= playerSpeed;
            }
        }

     

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    LeftMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpMoveTimer.Start();
                }
            }
           
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        Labelbtn.Visible = false;
                        gameMedia.controls.play();
                        pause = false;

                    }
                    else
                    {
                        Labelbtn.Location = new Point(this.Width / 2 - 120, 150);
                        Labelbtn.Text = "PAUSED";
                        Labelbtn.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }

        }

        private void MoveMinutionTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();

            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                    Collision();  // called the sound and damage enemies  function 
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location= new Point(Player.Location.X + 20 , Player.Location.Y - i * 30 );
                }
            }
        }

        private void MoveEnemiTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemieSpeed);
        }
        private void MoveEnemies(PictureBox[] array , int speed)
        {
            for (int i=0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        // For enemies damage sounds
        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) ||
                    munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)||
                    munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    // for update score 
                  
                    score += 1;
                    ScoreUp.Text=(score<10)? "0" + score.ToString() : score.ToString();

                    if (score %30 == 0)
                    {
                        level += 1;
                        labelUpdate.Text=(level<10)? "0" + level.ToString() : level.ToString();


                        if (enemieSpeed <=10 && enemieMunitionSpeed <=10 && deficulty >= 0 )

                        {
                            deficulty--;
                            enemieSpeed++;
                            enemieMunitionSpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("Game Finished");
                        }
                    }




                    enemies[i].Location = new Point((i + 1) * 50, -100);

                }

                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }

        }


        // For Game over functions 

        private void GameOver(String str)
        {
            Labelbtn.Text = str;
            Labelbtn.Location = new Point(120, 120);
            Labelbtn.Visible = true;
            Replaybtn.Visible = true;
            Exitbtn.Visible = true;


            gameMedia.controls.stop();
            StopTimers();
        }


        // Stop Time 
        private void StopTimers()
        {
            MoveBgTimer.Stop();
            MoveEnemiTimer.Stop();    
            MoveMinutionTimer.Stop();

            EnemiesMunitionTimer.Stop();
        }
        // Start Timer
        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemiTimer.Start();
            MoveMinutionTimer.Start();
            EnemiesMunitionTimer.Start();

        }

        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (enemiesMunition.Length- deficulty); i++)
            {
                if (enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemieMunitionSpeed;
                    CollisionWithEnemiesMunition();

                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);

                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);


                }
            }
        }

        // For Fair Enemies function 
        private void CollisionWithEnemiesMunition()
        {
            for (int i= 0;i < munitions.Length;i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 20;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

       

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            Environment.Exit(1);
        }
        private void Replaybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load_1(sender, e);

        }
    }

}
