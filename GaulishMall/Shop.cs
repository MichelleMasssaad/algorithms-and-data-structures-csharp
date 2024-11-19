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
    
    
    public static int[] Selection(int[] array, int budget)
    {
        var res_size = 0;
        var total = 0;
        
        var carray = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
            carray[i] = array[i];
        var barray = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
            barray[i] = array[i];
        
        for (int i = 0; i < array.Length; i++)
        {
            var max = budget - total;
            var current = -1;
            for (int j = 0; j < barray.Length; j++)
            {
                if (barray[j] == -1) continue;
                if (current == -1)
                {
                    if (barray[j] < max) current = j;
                    continue;
                }
                if (barray[j] > barray[current] && barray[j] <= max)
                {
                    current = j;
                }
            }
            if (current == -1) break;
            res_size++;
            total += barray[current];
            barray[current] = -1;
            if (total >= budget) break;
        }
        
        var res = new int[res_size];
        total = 0;
        var ind = 0;
        for (int i = 0; i < carray.Length; i++)
        {
            var max = budget - total;
            var current = -1;
            for (int j = 0; j < carray.Length; j++)
            {
                if (carray[j] == -1) continue;
                if (current == -1)
                {
                    if (barray[j] < max) current = j;
                    continue;
                }
                if (carray[j] > carray[current] && carray[j] <= max)
                {
                    current = j;
                }
            }
            if (current == -1) break;
            res[ind] = current;
            ind++;
            total += carray[current];
            carray[current] = -1;
            if (total >= budget) break;
        }
        BubbleSort(res);
        var res2 = new int[res_size];
        for (int i = 0; i < res.Length; i++)
            res2[i] = array[res[i]];
        return res2;
    }

//FAUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
   /* public static int[] Selection(int[] array, int budget)
    {
        foreach (int price in array)
        {
            if (price <= 0)
            {
                throw new ArgumentException("...");
            }
        }

        if (budget <= 0)
        {
            throw new ArgumentException("...");
        }

        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("...");
        }
        
        int index = 0;
        int[] list = new int[index];
        
        for (int i = 0; i < budget; i++)
        {
           
            budget -= array[i];
            list [i] = array[i];
            index++;
        }
        return list;
        
    }
    */
    //CODE AVANT IS WRONGGGGGGGG
    
    public static int Binarix(int[] array, int x)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (array[mid] == x)
            {
                return mid;
            }
            else if (array[mid] < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }






}