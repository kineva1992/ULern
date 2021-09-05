namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			MoveRobot(robot, Direction.Right, width - 3);
			MoveRobot(robot, Direction.Down, height - 3);
		}

		private static void MoveRobot(Robot robot,Direction direction, int stepCount)
		{
			for (int i = 0; i < stepCount; i++)
			{
				robot.MoveTo(direction);				
			}
		}

		
	}
}