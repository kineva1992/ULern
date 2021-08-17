using System;
using System.Collections.Generic;

namespace func_rocket
{
	public class LevelsTask
	{
		static readonly Physics standardPhysics = new Physics();

		private static Dictionary<string, Gravity> CreateLevelsDictonary(Rocket rocket, Vector target)
		{
            var levelGravity = new Dictionary<string, Gravity>();
            levelGravity.Add("Zero", (size, v) => Vector.Zero);
            levelGravity.Add("Heavy", (size, v) => new Vector(0, 0.9));
            levelGravity.Add("Up", (size, v) => new Vector(0, -300 / (size.Height - v.Y + 300.0)));
            levelGravity.Add("WhiteHole", (size, v) =>
            {
                var toWhiteHole = v - target;
                return toWhiteHole.Normalize() * 140 * toWhiteHole.Length
                / (toWhiteHole.Length * toWhiteHole.Length + 1);
            });
            levelGravity.Add("BlackHole", (size, v) =>
            {
                var toBlackHole = v - (target + rocket.Location) / 2;
                return toBlackHole.Normalize() * -300 * toBlackHole.Length
                / (toBlackHole.Length * toBlackHole.Length + 1);
            });
            levelGravity.Add("BlackAndWhite",
                (size, v) =>
                (levelGravity["WhiteHole"](size, v) + levelGravity["BlackHole"](size, v)) / 2);
            return levelGravity;
        }

		public static IEnumerable<Level> CreateLevels()
		{
            var rocket = new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI);
            var target = new Vector(700, 500);
            var levelGravity = CreateLevelsDictonary(rocket, target);

            foreach (var gravity in levelGravity)
            {
                yield return new Level(gravity.Key, rocket, target, gravity.Value, standardPhysics);
            }
		}
	}
}