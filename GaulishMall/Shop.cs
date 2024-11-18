namespace GaulishMall;

public class Shop
{
    public static string[] CreateShops(string shop1, string shop2, string shop3, string shop4)
    {
        string[] shops = { shop1, shop2, shop3, shop4 };
        return shops;
    }

    public static void SwapShops(string[] shop1, string[] shop2, int i, int j)
    {
        if (i < 0 || i > 3 || j < 0 || j > 3)
        {
            throw new ArgumentException("...");
        }
        
        string swap1 = shop1[i];
        string swap2 = shop2[j];
        shop1[i] = swap2;
        shop2[j] = swap1;
    }

    /*public static void Reverse(char[] name)
    {
        char [] reversed = new char[name.Length];
        for (int i = name.Length - 1; i >= 0 ; i-- )
        {
            for (int j = 0; j < name.Length; j++)
            {
                reversed[j] = name[i];
                
            }
        }

    }*/
    public static void Reverse(char[] name)
    {
        for (int i = 0, j = name.Length - 1; i < j; i++, j--)
        {
            (name[i], name[j]) = (name[j], name[i]);
        }
    }
    

    public static int[] WhereIsCaesar(string owner, string[] register)
    {
        int count = 0;
        for (int i = 0; i < register.Length; i++)
        {
            if (register[i]==owner)
            {
                count++;
            }
            
        }
        int [] indices = new int[count];
        int index = 0;
        for (int i = 0; i < register.Length; i++)
        {
            if (register[i]==owner)
            {
                indices[index] = i;
                index++;
                
            }
            
        }
        return indices;
    }

    public static void BubbleSort(int[] keys)
    {
        int n = keys.Length;
        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n-1-i; j++)
            {
                if (keys[j]>keys[j+1])
                {
                    int temp = keys[j];
                    keys[j] = keys[j+1];
                    keys[j+1] = temp;
                }
            }
        }
    }





}