using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace It145_final_project___SphereToys
{
    internal class ball_physics {

        public Vector2D position { get; set; } = new Vector2D();
        public Vector2D velocity { get; set; } = new Vector2D();
        public Vector2D gravity { get; set; } = new Vector2D(0, 0.981);

        public double radius { get; set; } = 1;
        public double frictionCoefficient { get; set; } = 0.99;
        public double bounceCoefficient { get; set; } = 0.7;

		public void Update()
        {
            velocity -= gravity;
            position += velocity;
            velocity *= frictionCoefficient;
        }

        public virtual void HandleCollision(Control container)
        {
            int windowWidth = container.ClientSize.Width;
            int windowHeight = container.ClientSize.Height;

            if (position.X - radius < 0) {
                position.X = radius;
                velocity.X = -1 * bounceCoefficient * velocity.X;
            } else if (velocity.X + radius > windowWidth) {
                position.X = windowWidth - radius;
                velocity.X = -1 * bounceCoefficient * velocity.X;
            }

			if (position.Y - radius < 0) {
				position.Y = radius;
				velocity.Y = -1 * bounceCoefficient * velocity.Y;
            } else if (velocity.Y + radius > windowWidth) {
                position.Y = windowWidth - radius;
				velocity.Y = -1 * bounceCoefficient * velocity.Y;
            }
		}

        // to render the ball
        public virtual void Draw(Graphics g) {
            g.FillEllipse(Brushes.Red, (float)(position.X - radius), (float)(position.Y - radius), (float)radius * 2, (float)radius * 2);
        }
    }
}

