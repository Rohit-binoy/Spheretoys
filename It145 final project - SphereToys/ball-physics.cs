using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace It145_final_project___SphereToys
{
    internal class ball_physics
    { 
        public float X { get; protected set; } // X position
        public float Y { get; protected set; } // Y position
        public float VelocityX { get; protected set; } // Horizontal velocity
        public float VelocityY { get; protected set; } // Vertical velocity

        public float Radius { get; protected set; } // Ball radius
        public float Gravity { get; protected set; } = 0.5f; // Gravity 
        public float Friction { get; protected set; } = 0.99f; // Friction 
        public float Bounce { get; protected set; } = 0.7f; // the force after the bounce
        
        public ball_physics(float x, float y, float radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        // to update ball position
        public virtual void Update()
        {
            
            VelocityY += Gravity;

            
            X += VelocityX;
            Y += VelocityY;

            
            VelocityX *= Friction;
            VelocityY *= Friction;
        }

        // to handle collision
        public virtual void HandleCollision(Control container)
        {
            int windowWidth = container.ClientSize.Width;
            int windowHeight = container.ClientSize.Height;

            
            if (X - Radius < 0)
            {
                X = Radius;
                VelocityX = -VelocityX * Bounce;
            }
            else if (X + Radius > windowWidth)
            {
                X = windowWidth - Radius;
                VelocityX = -VelocityX * Bounce;
            }

            
            if (Y - Radius < 0)
            {
                Y = Radius;
                VelocityY = -VelocityY * Bounce;
            }
            else if (Y + Radius > windowHeight)
            {
                Y = windowHeight - Radius;
                VelocityY = -VelocityY * Bounce;
            }
        }

        // to render the ball
        public virtual void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }

        // to set velocity
        public void SetVelocity(float vx, float vy)
        {
            VelocityX = vx;
            VelocityY = vy;
        }
    }
}

