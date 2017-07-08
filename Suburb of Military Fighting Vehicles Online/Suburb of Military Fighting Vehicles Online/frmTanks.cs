using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suburb_of_Military_Fighting_Vehicles_Online
{
    public partial class frmTanks : Form
    {
        public frmTanks()
        {
            InitializeComponent();
            KeyUp += frmTanks_KeyUp;
            KeyDown += frmTank_KeyDown;
            Load += frmTanks_Load;
        }
        public Tanks tank1;
        public Tanks tank2;
        // Public Bullets1(mBullets) As PictureBox
        // Public Bullets2(mBullets) As PictureBox
        // Public b1Directions(mBullets) As Integer
        // Public b2Directions(mBullets) As Integer
        PictureBox Bullet1;
        PictureBox Bullet2;
        int Bullet1Direction;

        int Bullet2Direction;
        public const int dirStop = 0;
        public const int dirUp = 1;
        public const int dirLeft = 4;
        public const int dirRight = 2;
        public const int dirDown = 3;
        public const int tMove = 7;
        public const int jumpBack = 2;
        public const int mBullets = 3;

        public const int bulletShift = 15;
        public int score1 = 0;
        public int newscore1 = 0;

        public static int score2 = 0;
        int clock = 0;
        //Dim pctTank As System.Windows.Forms.PictureBox
        //Dim pctTank2 As System.Windows.Forms.PictureBox
        int deathCount = 0;

        public const int deathWait = 100;

        public void setup()
        {
        }


        private void frmTanks_Load(System.Object sender, System.EventArgs e)
        {
            tank1 = new Tanks(12, 124);
            tank2 = new Tanks(52, 234);
            pctTankTwo.Image = Properties.Resources.GreenTankUp;
            pctTank1.Image = Properties.Resources.SovietTankUp;
            Bullet1Direction = dirStop;
            Bullet2Direction = dirStop;
            Bullet1 = new PictureBox();
            Bullet2 = new PictureBox();


        }
        private void frmTank_KeyDown(object sender, KeyEventArgs e)
        {


            if (tank2.disabledStatus() == false)
            {

                switch (e.KeyCode)
                {

                    //Tank 2
                    //W
                    case Keys.W:
                        tank2.SetDirection(dirUp);
                        pctTankTwo.Image = Properties.Resources.GreenTankUp;
                        break;
                    //A
                    case Keys.A:
                        tank2.SetDirection(dirLeft);
                        pctTankTwo.Image = Properties.Resources.GreenTankLeft;
                        break;
                    //S
                    case Keys.S:
                        tank2.SetDirection(dirDown);
                        pctTankTwo.Image = Properties.Resources.GreenTankDown;
                        break;
                    //D
                    case Keys.D:
                        tank2.SetDirection(dirRight);
                        pctTankTwo.Image = Properties.Resources.GreenTankRight;
                        break;
                    case Keys.Space:
                        //shooting
                        if (tank2.addBullet() == true)
                        {
                            switch (tank2.getSDirection())
                            {
                                case dirUp:
                                    //Up
                                    Bullet2.Left = pctTankTwo.Left + 25;
                                    Bullet2.Top = pctTankTwo.Top - 16;
                                    break;
                                case dirDown:
                                    //Down
                                    Bullet2.Left = pctTankTwo.Left + 100 - 25;
                                    Bullet2.Top = pctTankTwo.Top + 100 + 1;
                                    break;
                                case dirLeft:
                                    //Left
                                    Bullet2.Left = pctTankTwo.Left - 1;
                                    Bullet2.Top = pctTankTwo.Top + 60;
                                    break;
                                case dirRight:
                                    //Right
                                    Bullet2.Left = pctTankTwo.Left + 101;
                                    Bullet2.Top = pctTankTwo.Top + 25;
                                    break;
                            }
                            Bullet2Direction = tank2.getSDirection();
                            Bullet2.Image = Properties.Resources.Bullet1;
                            this.Controls.Add(Bullet2);


                        }
                        break;
                }
            }

            // Tank 1


            if (tank1.disabledStatus() == false)
            {
                switch (e.KeyCode)
                {
                    //Tank 1
                    case Keys.Up:
                        tank1.SetDirection(dirUp);
                        pctTank1.Image = Properties.Resources.SovietTankUp;
                        break;
                    case Keys.Down:
                        tank1.SetDirection(dirDown);
                        pctTank1.Image = Properties.Resources.SovietTankDown;
                        break;
                    case Keys.Left:
                        tank1.SetDirection(dirLeft);
                        pctTank1.Image = Properties.Resources.SovietTankLeft;
                        break;
                    case Keys.Right:
                        tank1.SetDirection(dirRight);
                        pctTank1.Image = Properties.Resources.SovietTankRight;

                        break;
                    case Keys.NumPad0:
                        //shooting

                        if (tank1.addBullet() == true)
                        {

                            switch (tank1.getSDirection())
                            {
                                case dirUp:
                                    //Up
                                    Bullet1.Left = pctTank1.Left + 25;
                                    Bullet1.Top = pctTank1.Top - 16;
                                    break;
                                case dirDown:
                                    //Down
                                    Bullet1.Left = pctTank1.Left + 100 - 25;
                                    Bullet1.Top = pctTank1.Top + 100 + 1;
                                    break;
                                case dirLeft:
                                    //Left
                                    Bullet1.Left = pctTank1.Left - 1;
                                    Bullet1.Top = pctTank1.Top + 60;
                                    break;
                                case dirRight:
                                    //Right
                                    Bullet1.Left = pctTank1.Left + 101;
                                    Bullet1.Top = pctTank1.Top + 25;
                                    break;
                            }
                            Bullet1Direction = tank1.getSDirection();
                            Bullet1.Image = Properties.Resources.Bullet1;
                            Bullet1.Visible = true;

                            this.Controls.Add(Bullet1);


                        }
                        break;
                }
            }
        }

        private void frmTanks_KeyUp(object sender, KeyEventArgs e)
        {
            if (tank1.disabledStatus() == false)
            {
                if (e.KeyCode == Keys.Up | e.KeyCode == Keys.Down | e.KeyCode == Keys.Left | e.KeyCode == Keys.Right)
                {
                    tank1.SetDirection(dirStop);
                }
            }

            if (tank2.disabledStatus() == false)
            {
                if (e.KeyCode == Keys.W | e.KeyCode == Keys.S | e.KeyCode == Keys.A | e.KeyCode == Keys.D)
                {
                    tank2.SetDirection(dirStop);
                }
            }

            e.Handled = true;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            int numberB1 = 0;
            int numberB2 = 0;
            clock = clock + 1;

            // Tank 2 bullet actions
            numberB2 = tank2.getBullets();
            if (numberB2 == 1)
            {
                switch (Bullet2Direction)
                {
                    case dirUp:
                        Bullet2.Top = Bullet2.Top - bulletShift;
                        break;
                    case dirDown:
                        Bullet2.Top = Bullet2.Top + bulletShift;
                        break;
                    case dirLeft:
                        Bullet2.Left = Bullet2.Left - bulletShift;
                        break;
                    case dirRight:
                        Bullet2.Left = Bullet2.Left + bulletShift;
                        break;
                }
                if (Bullet2.Top <= 20 | Bullet2.Top >= 600 | Bullet2.Left <= 0 | Bullet2.Left >= 1200)
                {
                    tank2.removeBullet();
                    this.Controls.Remove(Bullet2);
                }
                // check if the bullet hit the obstacle
                if (CollisionBulletWall(Bullet2, pctObstacle) == true)
                {
                    tank2.removeBullet();
                    this.Controls.Remove(Bullet2);
                }
                // check if we hit the other tank
                if (CollisionBulletTank(Bullet2, pctTank1) == true)
                {
                    tank2.removeBullet();
                    this.Controls.Remove(Bullet2);
                    tank1.disable();
                    tank1.SetDirection(dirStop);
                    //cmdRestart.Visible = True
                    //handle scores
                    clock = 0;
                    lblScore1.Text = score1.ToString();
                    score2 = score2 + 1;
                    lblScore2.Text = score2.ToString();

                    //pctTank2.Image = Properties.Resources.Death2
                }
            }

            numberB1 = tank1.getBullets();

            if (numberB1 == 1)
            {

                switch (Bullet1Direction)
                {
                    case dirUp:
                        Bullet1.Top = Bullet1.Top - bulletShift;
                        break;
                    case dirDown:
                        Bullet1.Top = Bullet1.Top + bulletShift;
                        break;
                    case dirLeft:
                        Bullet1.Left = Bullet1.Left - bulletShift;
                        break;
                    case dirRight:
                        Bullet1.Left = Bullet1.Left + bulletShift;
                        break;
                }

                if (Bullet1.Top <= 20 | Bullet1.Top >= 600 | Bullet1.Left <= 0 | Bullet1.Left >= 1200)
                {
                    tank1.removeBullet();
                    this.Controls.Remove(Bullet1);
                }
                if (CollisionBulletWall(Bullet1, pctObstacle) == true)
                {
                    tank1.removeBullet();
                    this.Controls.Remove(Bullet1);
                }
                if (CollisionBulletTank(Bullet1, pctTankTwo) == true)
                {
                    tank1.removeBullet();
                    this.Controls.Remove(Bullet1);
                    tank2.disable();
                    tank2.SetDirection(dirStop);
                    //cmdRestart.Visible = True
                    //Handle scores
                    clock = 0;

                    lblScore2.Text = score2.ToString();
                    score1 = score1 + 1;
                    lblScore1.Text = score1.ToString();

                }
            }


            if (tank2.disabledStatus() == false)
            {

                switch (tank2.getDirection())
                {
                    //Tank 2
                    //W
                    case dirUp:

                        if ((pctTankTwo.Top - tMove >= 20))
                        {
                            pctTankTwo.Top = pctTankTwo.Top - tMove;
                            if (Collision(pctTankTwo, pctTank1) == true)
                            {
                                pctTankTwo.Top = pctTankTwo.Top + tMove + 4;
                            }
                            if (CollisionWall(pctTankTwo, pctObstacle) == true)
                            {
                                pctTankTwo.Top = pctTankTwo.Top + tMove + 4;
                            }
                        }
                        break;
                    //e.Handled = True
                    //A
                    case dirLeft:

                        if ((pctTankTwo.Left - tMove >= 0))
                        {
                            pctTankTwo.Left = pctTankTwo.Left - tMove;
                            if (Collision(pctTankTwo, pctTank1) == true | CollisionWall(pctTankTwo, pctObstacle) == true)
                            {
                                pctTankTwo.Left = pctTankTwo.Left + tMove + 4;
                            }
                        }
                        break;
                    //e.Handled = True
                    //S
                    case dirDown:

                        if ((pctTankTwo.Top + tMove <= 590))
                        {
                            pctTankTwo.Top = pctTankTwo.Top + tMove;
                            if (Collision(pctTankTwo, pctTank1) == true | CollisionWall(pctTankTwo, pctObstacle) == true)
                            {
                                pctTankTwo.Top = pctTankTwo.Top - tMove - 4;
                            }
                        }
                        break;
                    // e.Handled = True
                    //D
                    case dirRight:

                        if ((pctTankTwo.Left <= 1200))
                        {
                            pctTankTwo.Left = pctTankTwo.Left + tMove;
                            if (Collision(pctTankTwo, pctTank1) == true | CollisionWall(pctTankTwo, pctObstacle) == true)
                            {
                                pctTankTwo.Left = pctTankTwo.Left - tMove - 4;
                            }
                        }
                        break;
                    //e.Handled = True

                }

            }
            else
            {
                // Tank 2 is dead, let us spin it
                int tankD2 = 0;
                deathCount = deathCount + 1;
                tankD2 = tank2.getDirection();
                if (tankD2 == dirStop)
                {
                    tankD2 = dirUp;
                }
                switch (tankD2)
                {
                    //Tank 2
                    case dirUp:
                        tank2.SetDirection(dirRight);
                        pctTankTwo.Image = Properties.Resources.GreenTankUp;
                        break;
                    case dirDown:
                        tank2.SetDirection(dirLeft);
                        pctTankTwo.Image = Properties.Resources.GreenTankDown;
                        break;
                    case dirLeft:
                        tank2.SetDirection(dirUp);
                        pctTankTwo.Image = Properties.Resources.GreenTankLeft;
                        break;
                    case dirRight:
                        tank2.SetDirection(dirDown);
                        pctTankTwo.Image = Properties.Resources.GreenTankRight;
                        break;
                }
            }

            //Tank 1

            if (tank1.disabledStatus() == false)
            {

                switch (tank1.getDirection())
                {

                    case dirUp:

                        if ((pctTank1.Top - tMove >= 20))
                        {
                            pctTank1.Top = pctTank1.Top - tMove;
                            if (Collision(pctTank1, pctTankTwo) == true)
                            {
                                pctTank1.Top = pctTank1.Top + tMove + jumpBack;
                            }
                            if (CollisionWall(pctTank1, pctObstacle) == true)
                            {
                                pctTank1.Top = pctTank1.Top + tMove + jumpBack;
                            }

                        }
                        break;
                    case dirDown:

                        if ((pctTank1.Top - tMove <= 590))
                        {
                            pctTank1.Top = pctTank1.Top + tMove;
                            if (Collision(pctTank1, pctTankTwo) == true | CollisionWall(pctTank1, pctObstacle) == true)
                            {
                                pctTank1.Top = pctTank1.Top - tMove - jumpBack;
                            }
                        }
                        break;
                    case dirLeft:
                        if ((pctTank1.Left + tMove >= 0))
                        {
                            pctTank1.Left = pctTank1.Left - tMove;
                            if (Collision(pctTank1, pctTankTwo) == true | CollisionWall(pctTank1, pctObstacle) == true)
                            {
                                pctTank1.Left = pctTank1.Left + tMove + jumpBack;
                            }

                        }
                        break;
                    case dirRight:
                        if ((pctTank1.Left <= 1200))
                        {
                            pctTank1.Left = pctTank1.Left + tMove;
                            if (Collision(pctTank1, pctTankTwo) == true | CollisionWall(pctTank1, pctObstacle) == true)
                            {
                                pctTank1.Left = pctTank1.Left - tMove - jumpBack;
                            }
                        }
                        break;
                }
            }
            else
            {
                // Tank 1 is dead, let us spin it
                int tankD = 0;
                tankD = tank1.getDirection();
                deathCount = deathCount + 1;
                if (tankD == dirStop)
                {
                    tankD = dirUp;
                }
                switch (tankD)
                {
                    //Tank 1
                    case dirUp:
                        tank1.SetDirection(dirRight);
                        pctTank1.Image = Properties.Resources.SovietTankUp;
                        break;
                    case dirDown:
                        tank1.SetDirection(dirLeft);
                        pctTank1.Image = Properties.Resources.SovietTankDown;
                        break;
                    case dirLeft:
                        tank1.SetDirection(dirUp);
                        pctTank1.Image = Properties.Resources.SovietTankLeft;
                        break;
                    case dirRight:
                        tank1.SetDirection(dirLeft);
                        pctTank1.Image = Properties.Resources.SovietTankRight;
                        break;
                }

            }

            if (deathCount >= deathWait)
            {
                restart();
            }
        }

        public bool Collision(System.Windows.Forms.PictureBox t1, System.Windows.Forms.PictureBox t2)
        {
            if (isInside(t1.Left, t1.Top, t2) == true)
            {
                return true;
            }
            if (isInside(t1.Left + 100, t1.Top, t2) == true)
            {
                return true;
            }
            if (isInside(t1.Left, t1.Top + 100, t2) == true)
            {
                return true;
            }
            if (isInside(t1.Left + 100, t1.Top + 100, t2) == true)
            {
                return true;
            }

            return false;

        }
        public bool CollisionWall(System.Windows.Forms.PictureBox t1, System.Windows.Forms.PictureBox o)
        {
            if (isInsideWall(t1.Left, t1.Top, o) == true)
            {
                return true;
            }
            if (isInsideWall(t1.Left + 100, t1.Top, o) == true)
            {
                return true;
            }
            if (isInsideWall(t1.Left, t1.Top + 100, o) == true)
            {
                return true;
            }
            if (isInsideWall(t1.Left + 100, t1.Top + 100, o) == true)
            {
                return true;
            }

            return false;

        }
        public bool CollisionBulletWall(System.Windows.Forms.PictureBox b, System.Windows.Forms.PictureBox o)
        {
            if (isInsideWall(b.Left, b.Top, o) == true)
            {
                return true;
            }
            if (isInsideWall(b.Left + 15, b.Top, o) == true)
            {
                return true;
            }
            if (isInsideWall(b.Left, b.Top + 15, o) == true)
            {
                return true;
            }
            if (isInsideWall(b.Left + 15, b.Top + 15, o) == true)
            {
                return true;
            }

            return false;

        }
        public bool CollisionBulletTank(System.Windows.Forms.PictureBox b, System.Windows.Forms.PictureBox t)
        {
            if (isInside(b.Left, b.Top, t) == true)
            {
                return true;
            }
            if (isInside(b.Left + 15, b.Top, t) == true)
            {
                return true;
            }
            if (isInside(b.Left, b.Top + 15, t) == true)
            {
                return true;
            }
            if (isInside(b.Left + 15, b.Top + 15, t) == true)
            {
                return true;
            }

            return false;

        }

        public bool isInside(int x, int y, System.Windows.Forms.PictureBox t)
        {

            // checks to see is point (x,y) is inside the box of pictureBox t.
            if (x >= t.Left & x <= t.Left + 100 & y >= t.Top & y <= t.Top + 100)
            {
                return true;
            }
            return false;

        }

        public bool isInsideWall(int x, int y, System.Windows.Forms.PictureBox t)
        {

            // checks to see is point (x,y) is inside the box of pictureBox t.
            if (x >= t.Left & x <= t.Left + 174 & y >= t.Top & y <= t.Top + 174)
            {
                return true;
            }
            return false;

        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            tank1.SetDirection(dirStop);
            tank2.SetDirection(dirStop);
            tank1.enable();
            tank2.enable();
            tank1.removeBullet();
            tank2.removeBullet();

            pctTankTwo.Left = 12;
            pctTankTwo.Top = 530;
            pctTankTwo.Image = Properties.Resources.GreenTankUp;

            pctTank1.Left = 1172;
            pctTank1.Top = 530;
            pctTank1.Image = Properties.Resources.SovietTankUp;
            // cmdRestart.Text = "Wait for it"
            clock = 0;
        }

        private void restart()
        {
            tank1.SetDirection(dirStop);
            tank2.SetDirection(dirStop);
            tank1.enable();
            tank2.enable();
            tank1.removeBullet();
            tank2.removeBullet();

            pctTankTwo.Left = 12;
            pctTankTwo.Top = 530;
            pctTankTwo.Image = Properties.Resources.GreenTankUp;

            pctTank1.Left = 1172;
            pctTank1.Top = 530;
            pctTank1.Image = Properties.Resources.SovietTankUp;
            // cmdRestart.Text = "Wait for it"
            clock = 0;
            deathCount = 0;
        }

        public void newGame()
        {
            resetScore();
            restart();
        }

        public void resetScore()
        {
            score1 = 0;
            score2 = 0;
            lblScore1.Text = score1.ToString();
            lblScore2.Text = score2.ToString();
        }

        private void startServerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}
