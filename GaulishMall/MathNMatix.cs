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
        

    }

}

