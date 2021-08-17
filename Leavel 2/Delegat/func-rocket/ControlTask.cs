using System;

namespace func_rocket
{
	public class ControlTask
	{
		public static Turn ControlRocket(Rocket rocket, Vector target)
		{
			var distanceVector = target - rocket.Location;
			double totalAngle = distanceVector.Angle - rocket.Direction;
			if (Math.Abs(distanceVector.Angle - rocket.Direction) < 0.5
				|| Math.Abs(distanceVector.Angle - rocket.Velocity.Angle) < 0.5)
				totalAngle = (totalAngle + distanceVector.Angle - rocket.Velocity.Angle) / 2;
			if (totalAngle > 0)
				return Turn.Right;
			if (totalAngle < 0)
				return Turn.Left;
			else
				return Turn.None;
		}
	}
}