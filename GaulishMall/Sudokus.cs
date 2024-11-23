namespace GaulishMall;

public class Sudokus
{
    public static bool InLine(int[,] grid, int line, int digit)
    {
        for (int col = 0; col < 9; col++)
        {
            if (grid[line, col] == digit)
                return true;
        }
        return false;
    }
    
    public static bool InCol(int[,] grid, int col, int digit)
    {
        for (int row = 0; row < 9; row++)
        {
            if (grid[row, col] == digit)
                return true;
        }
        return false;
    }
    
    
    public static bool InBox(int[,] grid, int box, int digit)
    {
        int startRow = (box / 3) * 3;
        int startCol = (box % 3) * 3;

        for (int row = startRow; row < startRow + 3; row++)
        {
            for (int col = startCol; col < startCol + 3; col++)
            {
                if (grid[row, col] == digit)
                    return true;
            }
        }

        return false;
    }
    
    public static bool Solver(int[,] grid)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (grid[row, col] == 0)
                {
                    for (int digit = 1; digit <= 9; digit++)
                    {
                        if (!InLine(grid, row, digit) && !InCol(grid, col, digit) && !InBox(grid, (row / 3) * 3 + (col / 3), digit))
                        {
                            grid[row, col] = digit;

                            if (Solver(grid))
                            {
                                return true;
                            }

                            grid[row, col] = 0;
                        }
                    }

                    return false; 
                }
            }
        }

        return true; 
    }
}