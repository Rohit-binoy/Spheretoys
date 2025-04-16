using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Final project first draft code
///date:3/20/25
///purpose: to make a first draft of our code for the final project of our code
///teamates: Rohit Binoy, Ang tsering Sherpa, Lucas Chaponis, Silas Tracy
///thoughts: this the first draft of the project but i am confident in our Main Ball-physics
///which is very important for this project and will act as anhertence for the rest of the minigames
///still need some time for us to figure out the minigames but i am confident that we can pull through.
namespace It145_final_project___SphereToys
{
    internal class Pinball : ball_physics
    {
        private float FlipperForce = -15f; // this force for flipper that will be below

        public Pinball(float x, float y, float radius) : base(x, y, radius) { }

        // Override for piball since it will be different for othe minigames
        public override void Update()
        {
            base.Update();
            ApplyPinballPhysics();
        }

        
        private void ApplyPinballPhysics()
        {
            // stillfiguring out what to put here to make exact. need to research more
        }

        // Handle Flipper Interaction
        public void UseFlipper(bool isLeft)
        {
            if (isLeft)
            {
                VelocityY += FlipperForce;
                VelocityX -= 5f; // Left flipper adds leftward force
            }
            else
            {
                VelocityY += FlipperForce;
                VelocityX += 5f; // Right flipper adds rightward force
            }
        }

        // to make the pinnvall below so when we switch from menu to game it will work coresoponily
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}

