namespace GaulishMall;

public class MathNMatix
{
    public static string Compress(string uncompressed)
    {
        
        string result = "";
        int count = 1; //Ta eza ma fi gheyr mara wehde ati3 ya3tine 1
        if (uncompressed.Length == 0) return "";
        char temp = uncompressed[0];
        for (int i = 1; i < uncompressed.Length; i++) //balacht men i=1 li2n awal element trete bel abla
        {
            if (temp == uncompressed[i] && count != 9) //lama yssir =9 ha yrouh 3al else
            {
                count++;
            }
            else
            {
                result += count.ToString() + temp;
                temp = uncompressed[i];
                count = 1;
            }
        }
        result += count.ToString() + temp;
        return result;
    }
    
    
    public static string Uncompress(string compressed)
    {
        string result = "";
        int i = 0;

        while (i < compressed.Length)
        {
            int count = 0;

            while (i < compressed.Length && compressed[i] >= '0' && compressed[i] <= '9')
            {
                count = count * 10 + (compressed[i] - '0');
                i++;
            }

            if (i >= compressed.Length || (compressed[i] < ' ' || compressed[i] > '~'))
                throw new ArgumentException();

            result += new string(compressed[i], count);
            i++;
        }

        return result;
    }
    
    
    
    public static int[,] MatrixMult(int[,] mat1, int[,] mat2)
    {
        int rows1 = mat1.GetLength(0); // Nbre de lignes de mat1
        int cols1 = mat1.GetLength(1); // Nbre de colonnes de mat1
        int rows2 = mat2.GetLength(0); // Nbre de lignes de mat2
        int cols2 = mat2.GetLength(1); // Nbre de colonnes de mat2

        if (cols1 != rows2)
            throw new ArgumentException("...");

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }

        return result;
    }

}

