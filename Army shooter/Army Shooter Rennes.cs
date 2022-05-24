//#define My_Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Army_shooter.Properties;
using System.Threading.Tasks;
using System.Media;

namespace Army_shooter
{
    public partial class Army_Shooter_Rennes : Form
    {
        //The following will be tracking how well the player performs in the stage
        double hits = 0;
        double misses = 0;
        double totalShots = 0;
        
        //This variable controls how often a new soldier will pop up
        int _gameFrame = 0;
//#if My_Debug     
        //These are to track the location of mouse on the form
        int _cursX = 0;
        int _cursY = 0;
//#endif
        Random rnd = new Random();

        //This is to reference the image details of _soldier from the class, CSoldier
        CSoldier _soldier;

        

        public Army_Shooter_Rennes()
        {
            InitializeComponent();

            
            //This creates the "click zone" for the new cursor that was added
            Bitmap b = new Bitmap(Resources.Site); 
            this.Cursor = Crosshair1.CreateCursor(b, b.Height / 2, b.Width / 2);
            //This is the starting point of the soldier
            _soldier = new CSoldier() { Left = 10, Top = 200 };
        }

        

        private void Army_Shooter_Rennes_Load(object sender, EventArgs e)
        {

        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {
            //This whole code controls how frequently the soldier will pop up
            if (_gameFrame >= 8)
            {
                UpdateSoldier();
                _gameFrame = 0;
            }
            _gameFrame++;

            this.Refresh();
        }

        private void UpdateSoldier()
        {
            //This controls the coordinates the soldier will pop up at 
            _soldier.Update(
                
                rnd.Next(Resources.sniper2.Width, this.Width ),
                rnd.Next( Resources.sniper2.Height, this.Height )
                    );
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //These lines are to display the coordinates of the mouse
            //I was using them originally to try and debug and be able to see the coordinates of different points in the program
            Graphics dc = e.Graphics;
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(e.Graphics, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font, 
            new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif
            _soldier.DrawImage(dc);
            
            base.OnPaint(e);

        }

        private void Army_Shooter_Rennes_MouseMove(object sender, MouseEventArgs e)
        {
            //These track the mouse's x and y coordinates
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }

        private void start_Stage_Click(object sender, EventArgs e)
        {
            //This starts the stage wand prevents the user from reaching the next stage without clearing the first one
            timerGameLoop.Start();
            next_Stage.Enabled = false;
        }

        private void hits1Label_Click(object sender, EventArgs e)
        {

        }

        private void FireGun()
        {
            //This plays the sound of the gunshots 
            SoundPlayer simpleSound = new SoundPlayer(Resources.GunShotSound);

            simpleSound.Play();
        }


        private void Army_Shooter_Rennes_MouseClick_1(object sender, MouseEventArgs e)
        {
            //The following track how well the player has performed within the stage
            if (_soldier.Hit(e.X, e.Y))
            {
                hits++;
            }
            else
            {
                misses++;
            }
            totalShots = misses + hits;
            double hitPercent = (hits / totalShots);
            double hitPerc = hitPercent * 100;
            string hitsS = hits.ToString();
            string missesS = misses.ToString();
            string totalShotsS = totalShots.ToString();
            string hitPercentS = hitPerc.ToString();
            hits1Label.Text = hitsS;
            missesLabel.Text = missesS;
            totalShotsLabel.Text = totalShotsS;
            hitPercentLabel.Text = hitPercentS + "%";
            FireGun();
        }
    }
}
