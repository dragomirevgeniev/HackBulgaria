namespace HackBulgaria_Fall_2015
{
    class Points
    {   
        public static void MovePoint(string directions, int currentX, int currentY)
        {
            const char UPWARDS = '^';
            const char DOWNWARDS = 'v';
            const char RIGHT = '>';
            const char LEFT = '<';
            const char REVERSE = '~';
            int update = 1;
            
            for (int i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case UPWARDS:
                        currentY -= update;
                        break;
                    case DOWNWARDS:
                        currentY += update;
                        break;
                    case LEFT:
                        currentX -= update;
                        break;
                    case RIGHT:
                        currentX += update;
                        break;
                    case REVERSE:
                        update *= (-1);
                        break;
                    default:
                        break;
                }
            }

            System.Console.WriteLine("({0}, {1})", currentX, currentY);
        }

        public static void Main(string[] args)
        {
            System.Console.Write("Starting point: ");

            // User enters the point in format (x, y)
            string startingPoint = System.Console.ReadLine();
            string[] splittedStartingPoint = startingPoint.Split(new char[] { '(', ')', ',' }, System.StringSplitOptions.RemoveEmptyEntries);
            int currentX = int.Parse(splittedStartingPoint[0]);
            int currentY = int.Parse(splittedStartingPoint[1]);

            string directions = System.Console.ReadLine();

            MovePoint(directions, currentX, currentY);
        }
    }
}
