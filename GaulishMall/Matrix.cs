namespace GaulishMall;

public class Matrix
{
    public static int CountItems(int[,] shops, int price)
    {
        int count = 0;
    
        for (int i = 0; i < shops.GetLength(0); i++)
        {
            for (int j = 0; j < shops.GetLength(1); j++)
            {
                if (shops[i, j] == price)
                {
                    count++;
                }
            }
        }

        return count;
    }
    
    
    
    
    
    public static int[,] FindItems(int[,] shops, int price)
    {
        int count = 0;

        for (int i = 0; i < shops.GetLength(0); i++)
        {
            for (int j = 0; j < shops.GetLength(1); j++)
            {
                if (shops[i, j] == price)
                {
                    count++;
                }
            }
        }

        if (count == 0)
        {
            return new int[0, 0];
        }

        int[,] result = new int[count, 2];
        int index = 0;

        for (int i = 0; i < shops.GetLength(0); i++)
        {
            for (int j = 0; j < shops.GetLength(1); j++)
            {
                if (shops[i, j] == price)
                {
                    result[index, 0] = i;
                    result[index, 1] = j;
                    index++;
                }
            }
        }

        return result;
    }
    
    
    
    
    public static int[,] RotateShops(int[,] shops)
    {
        int rows = shops.GetLength(0);
        int cols = shops.GetLength(1);
        int[,] rotated = new int[cols, rows];
    
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                rotated[j, i] = shops[i, j];
            }
        }

        return rotated;
    }
    
    
    
    public static int CountJagged(int[][] shops, int price)
    {
        int count = 0;

        for (int i = 0; i < shops.Length; i++) // Parcours des sous-tableaux
        {
            for (int j = 0; j < shops[i].Length; j++) // Parcours des éléments du sous-tableau
            {
                if (shops[i][j] == price)
                {
                    count++;
                }
            }
        }

        return count;
    }

}