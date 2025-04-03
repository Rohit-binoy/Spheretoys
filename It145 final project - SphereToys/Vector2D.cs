using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// HOW TO USE ME:
// I work just like a normal double, float, or whatever. Declare me
// like a normal object, then use stuff like +, -, *, or /. I can
// be multiplied with a double to scale me by some amount, or divided
// in the same way.
// Multiplying a vector by a vector (foo * bar, where both are Vector2D)
// will result in the dot product.
// You can also freely print me and use me like a string!

// IE:
//	Vector2D foo = new Vector2D(5, 10);
//	foo = foo * 0.5;
//	Console.WriteLine(foo);
// Will produce a vector foo <5, 10>, scale it by 0.5, and print "<2.5, 5>"

// NOTE: you can also use +=, -=, *=, and /= operations

namespace It145_final_project___SphereToys {
	public class Vector2D {
		
		public double X { get; set; }
		public double Y { get; set; }

		// constructor
		public Vector2D(double xIn = 0, double yIn =0) {
			X = xIn;
			Y = yIn;
		}

		// lets the class be freely converted to a string
		public override string ToString() {
			return $"<{X}, {Y}>";
		}
		
		// --- MATHEMATICAL OPERATION OVERRIDES ---

		// override addition
		public static Vector2D operator +(Vector2D vector1, Vector2D vector2) {
			return new Vector2D((vector1.X + vector2.X), (vector1.Y + vector2.Y));
		}

		// override subtraction
		public static Vector2D operator -(Vector2D vector1, Vector2D vector2) {
			return new Vector2D((vector1.X - vector2.X), (vector1.Y - vector2.Y));
		}

		// override multiplication for vector * scalar
		public static Vector2D operator *(Vector2D vector, double scalar) {
			return new Vector2D((vector.X * scalar), (vector.Y * scalar));
		}

		// override multiplication for dot product (vector * vector)
		public static double operator *(Vector2D inputVector1, Vector2D inputVector2) {
			return (inputVector1.X * inputVector2.X) + (inputVector1.Y * inputVector2.Y);
		}

		// override division for vector / scalar
		public static Vector2D operator /(Vector2D vector, double scalar) {
			return new Vector2D((vector.X / scalar), (vector.Y / scalar));
		}

		// --- METHODS ---

		public double magnitude() {
			return Math.Sqrt((X * X) + (Y * Y));
		}
	}
}
