using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace It145_final_project___SphereToys
{
    public class PinballForm : Form
    {
        private Timer gameTimer;
        private Pinball pinball;
        private Button backButton;

        public PinballForm()
        {
            this.Text = "Pinball Game";
            this.Size = new Size(600, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;

            pinball = new Pinball(300, 400, 15);

            gameTimer = new Timer { Interval = 16 };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            this.KeyDown += PinballForm_KeyDown;

            backButton = new Button
            {
                Text = "Back to Menu",
                Size = new Size(100, 40),
                Location = new Point(10, 10)
            };
            backButton.Click += BackButton_Click;

            this.Controls.Add(backButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            this.Close();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pinball.Update();
            pinball.HandleCollision(this);
            this.Invalidate();
        }

        private void PinballForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                pinball.UseFlipper(true);
            else if (e.KeyCode == Keys.Right)
                pinball.UseFlipper(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            pinball.Draw(e.Graphics);
        }
    }
}
    
