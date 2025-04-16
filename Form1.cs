using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace It145_final_project___SphereToys
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitMenu();
        }

        private void InitMenu()
        {
            this.Text = "SphereToys Menu";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            pinballButton = new Button
            {
                Text = "Play Pinball",
                Size = new Size(150, 50),
                Location = new Point((this.ClientSize.Width - 150) / 2, 100)
            };

            pinballButton.Click += PinballButton_Click;

            // Add button to form controls
            this.Controls.Add(pinballButton);

        }




        private void PinballButton_Click(object sender, EventArgs e)
        {
            using (PinballForm pinballGame = new PinballForm())
            {
                this.Hide();
                pinballGame.ShowDialog();
                this.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

