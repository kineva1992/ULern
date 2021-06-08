namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
        {         
            int dlin = width - 3;
            int vniz = 2;
 
            while (robot.Finished == false)
            {
                if (robot.Finished == false) {
                    for (int i = 0; i < dlin; i++)
                    { robot.MoveTo(Direction.Right); }
                    for (int i = 0; i < vniz; i++)
                    { robot.MoveTo(Direction.Down); }
                    for (int i = 0; i < dlin; i++)
                    { robot.MoveTo(Direction.Left);}
                    if (robot.Finished == false) {
                        for (int i = 0; i < vniz; i++)
                        { robot.MoveTo(Direction.Down); } }
                } }     
        }


	}
}