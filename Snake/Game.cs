using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game : Form
    {
        #region Constructor
        #region Variables
        private const int MAX_BOMB = 5;  // Nbr de bombes max
        private int Score;
        private int direction = 0; // 0=down,1=left,2=right,3=up
        private int choice; //Définit le jeu qui sera jouer        
        private int snakeRate = 3; //Plus il augmente, plus la vitesse du serpent augmente 
        private bool GameOver;// Est a false à la fin du jeu et permet d'afficher qq elemeents
        private int[,] Pos_Bomb = new int[MAX_BOMB,2]; // tableau contenant position des bombes
        private Bitmap[] Images = new Bitmap[7];// contient les images qui seront utilisés au cours du jeu
        private System.Media.SoundPlayer son = new System.Media.SoundPlayer();
        private String[] sound = { "..\\..\\sound\\BOOM.wav", "..\\..\\sound\\GameOver.wav", "..\\..\\sound\\Start.wav","..\\..\\sound\\Bite.wav" };
        List<Body> Snake = new List<Body>();
        Body food;
        Body poison;
        Body bombe;
        Timer SnakeLoop = new Timer();

        Random rand = new Random();
        
        #endregion

        public int GameType
        {
            get { return choice; }
            set { choice = value; }
        }

        public Game()
        {
            InitializeComponent();
            SnakeLoop.Tick += new EventHandler(UpdateSnake);
            SnakeLoop.Interval = 1000 / 5;
            SnakeLoop.Start();
            initImage();
           
        }

        private void Game_Load(object sender, EventArgs e)
        {
            switch (choice)
            {

                case 1:
                    pbSnake.Image = Images[3];
                    pbSnake.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbSnake.Refresh();
                    pbSnake.Visible = true;
                    break;
                case 2:
                    pbSnake.Image = Images[4];
                    pbSnake.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbSnake.Refresh();
                    pbSnake.Visible = true;
                    break;
            }
            StartGame();
        }
        #endregion

        #region Form Events
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void pbSnake_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }
        #endregion

        #region GameLogic

        private void initImage()
        {
            Images[0] = new Bitmap("2.png");
            Images[1] = new Bitmap("3.png");
            Images[2] = new Bitmap("bombe.png");
            Images[3] = new Bitmap("foot.jpeg");
            Images[4] = new Bitmap("sand.jpg");
            Images[5] = new Bitmap(1,1);
        }

        private void StartGame()
        {
            son.SoundLocation = sound[2];
            son.Play();
            GameOver = false;
            Score = 10;
            Snake.Clear();
            Body head = new Body(10, 8);
            Snake.Add(head);
            GenerateFood();
            GeneratePoison();
            GenerateBomb();
        }

        private void UpdateSnake(object sender, EventArgs e)
        {
            if (!GameOver)
            {
                if (Input.Press(Keys.Left) && direction !=2)
                {
                    direction = 1;
                }
                else if (Input.Press(Keys.Right) && direction!=1)
                {
                        direction = 2;
                }
                else if (Input.Press(Keys.Up) && direction!=0)
                {
                    direction = 3;
                }
                else if (Input.Press(Keys.Down) && direction!=3)
                {
                    direction = 0;
                }
            }
            pbSnake.Invalidate();
            Player();
             
        }

        private void Player()
        {
            int col = 0;
            if (!GameOver)
            {
                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        // changement de direction de la tête du serpent en fonction de la direction choisie
                        switch (direction)
                        {
                            case 0:
                                Snake[0].Y++;
                                break;
                            case 1:
                                Snake[0].X--;
                                break;
                            case 2:
                                Snake[0].X++;
                                break;
                            case 3:
                                Snake[0].Y--;
                                break;
                        }

                        Body head = Snake[0];
                        //condition pour le terrain de foot où il peut passer à travers les goals.
                        // cette condition doit être testé avant celle de hors limites car sinon le sanke ne passe pas de l'autre côté du terrain
                        if (choice == 1)
                        {
                            if (direction == 3 && head.Y < 0 && head.X > 6 && head.X < 13)
                                head.Y = 24;
                            else if (direction == 0 && head.Y > 24 && head.X > 6 && head.X < 13)
                                head.Y = 0;
                        }
                        // hors limites
                        if (head.X >= 20 || head.X < 0 || head.Y < 0 || head.Y >= 25)
                        {
                            gameover(1);
                        }

                        //collision avec corps
                        for (int j = 1; j < Snake.Count; j++)
                            if (head.X == Snake[j].X && head.Y == Snake[j].Y)
                                gameover(1);

                        //collision avec Nourriture
                        if (food.X == head.X && food.Y == head.Y)
                        {
                            Body part = new Body(Snake[Snake.Count - 1].X, Snake[Snake.Count - 1].Y);
                            Snake.Add(part);
                            GenerateFood();
                            Score += 10;
                            son.SoundLocation = sound[3];
                            son.Play();
                            if (snakeRate < 15)
                                snakeRate++;
                            SnakeLoop.Interval = 1000 / snakeRate;
                            if (Score >= 40)
                                GeneratePoison();
                        }

                        //Collision avec la nourriture empoisonné
                        if (Score > 40)
                        {
                            if (poison.X == head.X && poison.Y == head.Y)
                            {
                                if (choice == 2)
                                {
                                    Score -= 10;
                                    GeneratePoison();
                                }
                                else
                                    gameover(1);
                            }
                        }

                        //Collision avec la bombe
                        if (choice == 2)
                        {
                            for (int j = 0; j < MAX_BOMB; j++)
                            {
                                if (Pos_Bomb[j, col] == head.X && Pos_Bomb[j, col + 1] == head.Y)
                                {
                                    gameover(0);

                                }
                            }
                        }
                    }
                    else
                    {
                        //Fait avancer le reste du corps
                        Snake[i].X = Snake[i - 1].X;
                        Snake[i].Y = Snake[i - 1].Y;
                    }

                }
            }
        }

        private void Draw(Graphics canvas)
        {
            int col = 0;
            Font font = this.Font;
            //Si fin du jeu
            if (GameOver)
            {
                //on affiche message du fin de jeu et le score
                SizeF message = canvas.MeasureString("GameOver !", font);
                canvas.DrawString("Gameover !", font, Brushes.Red, new PointF(250 - message.Width / 2, 280));
                message = canvas.MeasureString("Final Score :" + Score.ToString(), font);
                canvas.DrawString("Final Score :" + Score.ToString(), font, Brushes.Red, new PointF(250- message.Width / 2, 320));
                b_close.Visible = true;
                b_game.Visible = true;
            }
            else
            {
                l_score.Text = "Score : " + Score;
                Body currentpart = Snake[0];
                canvas.FillEllipse(new SolidBrush(Color.Green), new Rectangle(currentpart.X * 25, currentpart.Y * 25, 25, 25)); 
                for (int i = 1; i < Snake.Count; i++)
                { 
                    currentpart = Snake[i];                    
                    canvas.FillEllipse(new SolidBrush(Color.LawnGreen), new Rectangle(currentpart.X * 25, currentpart.Y * 25, 25 ,25)); 
                }
                canvas.DrawImage(Images[0], new Rectangle(food.X*25,food.Y*25,25,25));
                if (Score>40)                
                    canvas.DrawImage(Images[1], new Rectangle(poison.X * 25, poison.Y * 25, 25, 25));
                if (choice == 2)
                {
                    for (int i = 0; i <MAX_BOMB; i++)
                    {
                        canvas.DrawImage(Images[2], new Rectangle(Pos_Bomb[i, col] * 25, Pos_Bomb[i, col + 1] * 25, 25, 25));
                    } 
                }
            }
        }

        #endregion

        #region Food and Others

        private void GenerateFood()
        {
            bool safe_place = true;
            int col = 0;
            food = new Body(rand.Next(0, 20), rand.Next(0, 25));
            // checks if the food is on the same place as a bomb
            for (int i = 0; i < MAX_BOMB; i++)
            {
                if (Pos_Bomb[i,col] == food.X && Pos_Bomb[i,col+1 ] == food.Y)
                    food = new Body(rand.Next(0, 20), rand.Next(0, 25));
            }
            safe_place = checkSnake(food.X,food.Y);
            while (!safe_place)
            {
                food = new Body(rand.Next(0, 20), rand.Next(0, 25));
                safe_place = checkSnake(food.X,food.Y);
            }
            // doesn't need to check for the poison because poison is created after the food
        }

        private void GeneratePoison()
        {
            bool safe = true;
            int col = 0;
            poison = new Body(rand.Next(0, 20), rand.Next(0, 25));
            while (poison.X ==food.X && poison.Y == food.Y) {
                poison = new Body(rand.Next(0, 20), rand.Next(0, 25));
            }
            //check with the snake
            safe = checkSnake(poison.X, poison.Y);
            while (!safe)
            {
                poison = new Body(rand.Next(0, 20), rand.Next(0, 25));
                safe = checkSnake(poison.X, poison.Y);
            }
        }

        private void GenerateBomb()
        {
            //Les bombes sont créées au début du jeu => pas besoin de vérifier leur position avec celles du snake.
            int X, Y,line=0,col=0;
            if (choice == 2)
            {
                while (line<MAX_BOMB)
                {
                    X = rand.Next(20);
                    Y = rand.Next(25);
                    Pos_Bomb[line, col] = X;
                    Pos_Bomb[line, col + 1] = Y;
                    line++;
                }
                
                bombe = new Body(Pos_Bomb[0,0], Pos_Bomb[0, 1]);
            }
        }

        private bool checkSnake(int x, int y)
        {
            bool safe = true;
            for (int i = 0; i <Snake.Count; i++)
            {
                if(Snake[i].X ==x && Snake[i].Y == y)
                {
                    safe = false;
                    break;
                }
            }
            return safe;
        }
        #endregion

        #region EndGame

        private void gameover(int noise)
        {
            GameOver = true;
            son.SoundLocation = sound[noise];
            son.Play();
        }

        private void b_game_Click(object sender, EventArgs e)
        {
            Hide();
            (new Menu()).ShowDialog();
            Close();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


    }
}
