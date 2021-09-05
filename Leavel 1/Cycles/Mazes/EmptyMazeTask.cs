namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
		}

		private static void MoveRight(Robot robot, int stepCount)
		{
            for (int i = 0; i < stepCount - 3; i++)
            {
				robot.MoveTo(Direction.Right);
            }
		}
		private static void MoveLeft(Robot robot, int stepCount)
		{
			for (int i = 0; i < stepCount - 3; i++)
			{
				robot.MoveTo(Direction.Left);
			}
		}
	}
}