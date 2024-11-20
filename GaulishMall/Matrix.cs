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
    
    
    
    public static string[][] Trim(string[][] arr, string[] forbidden)
    {
        string[][] result = new string[arr.Length][];

        for (int i = 0; i < arr.Length; i++)
        {
            int validCount = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                bool isForbidden = false;

                for (int k = 0; k < forbidden.Length; k++)
                {
                    if (arr[i][j] == forbidden[k])
                    {
                        isForbidden = true;
                        break;
                    }
                }

                if (!isForbidden)
                {
                    validCount++;
                }
            }

            string[] validShops = new string[validCount];
            int index = 0;

            for (int j = 0; j < arr[i].Length; j++)
            {
                bool isForbidden = false;

                for (int k = 0; k < forbidden.Length; k++)
                {
                    if (arr[i][j] == forbidden[k])
                    {
                        isForbidden = true;
                        break;
                    }
                }

                if (!isForbidden)
                {
                    validShops[index] = arr[i][j];
                    index++;
                }
            }

            result[i] = validShops;
        }

        return result;
    }
    
    
    
    public static int SecondLargest(int[][] shops)
    {
        if (shops.Length == 0 || shops[0].Length < 2)
            throw new ArgumentException("...");

        int? max = null;
        int? secondMax = null;

        foreach (var shop in shops)
        {
            foreach (var item in shop)
            {
                if (max == null || item > max)
                {
                    secondMax = max;
                    max = item;
                }
                else if (item != max && (secondMax == null || item > secondMax))
                {
                    secondMax = item;
                }
            }
        }

        return secondMax ?? throw new ArgumentException("...");
    }
    
    
    public static int[][] Pascal(uint n)
    {
        int[][] triangle = new int[n + 1][];

        for (int i = 0; i <= n; i++)
        {
            triangle[i] = new int[i + 1]; 
        
            // AWAL W EKHIR ELEMENT BEL LISTE
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            //LA BE2E L LISTE 3ABEYA
            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }



}