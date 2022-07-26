using LittleGames;

namespace LittleGames.Games
{
    public partial class TicTacToe
    {
        class Bot
        {
            int x; //coords[0]
            int y; //coords[1]
            int[] coords = new int[2];
            Cell[][] cells;
            public Bot(Cell[][] cells)
            {
                this.cells = cells;
            }
            public int[] Work()
            {
                RandomCell();
                coords[0] = x;
                coords[1] = y;
                return coords;
            }
            public void RandomCell()
            {
                var rand = new Random();
                x = rand.Next(0, 2);
                y = rand.Next(0, 2);
                while (cells[x][y].full)
                {
                    x = rand.Next(0, 2);
                    y = rand.Next(0, 2);
                }
            }
        }
    }
}