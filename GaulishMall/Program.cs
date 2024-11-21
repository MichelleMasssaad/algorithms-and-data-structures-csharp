// See https://aka.ms/new-console-template for more information
using GaulishMall;
Console.WriteLine("Hello, World!");
/*
string[] createShops = GaulishMall.Shop.CreateShops("Asterix", "Obelix", "Unhygienix", "Fulliautomatix"); // createShops == { "Asterix", "Obelix", "Unhygienix", "Fulliautomatix" }
string[] createShops2 = GaulishMall.Shop.CreateShops("Geriatrix", "Cacofonix", "Getafix", "Abraracourcix");     // createShops2 == { "Geriatrix", "Cacofonix", "Getafix", "Abraracourcix" }



string[] shop = GaulishMall.Shop.CreateShops("Asterix", "Obelix", "Unhygienix", "Fulliautomatix");
string[] shop2 = GaulishMall.Shop.CreateShops("Geriatrix", "Cacofonix", "Getafix", "Abraracourcix");
GaulishMall.Shop.SwapShops(shop, shop2, 1, 3);
// shop == { "Getafix", "Obelix", "Geriatrix", "Fulliautomatix" }
// shop2 == { "Unhygienix", "Cacofonix", "Asterix", "Abraracourcix" }
Shop.SwapShops(shop, shop2, 0, 6);


char[] str = { 'x', 'i', 'r', 'e', 't', 's', 'a' };
GaulishMall.Shop.Reverse(str);
// str == { 'a', 's', 't', 'e', 'r', 'i', 'x' }


string[] register = new[] {"Caesar", "Asterix", "Obelix", "Caesar", "Getafix", "Caesar"};
int[] result1 = GaulishMall.Shop.WhereIsCaesar("Caesar", register);   // result1 == { 0, 3, 5 }
int[] result2 = GaulishMall.Shop.WhereIsCaesar("Who?", register);    // result2 == {}

int[] bagsArray = { 1, 16, 15, 11, 7, 9, 6, 6, 3, 10 };
int[] bag1 = GaulishMall.Shop.Selection(bagsArray, 50);   // bag1 == { 1, 16, 15, 11, 7 }
int[] bag2 = GaulishMall.Shop.Selection(bagsArray, 33);   // bag2 == { 1, 16, 15 }
int[] bag3 = GaulishMall.Shop.Selection(bagsArray, 80);   // bag3 == { 16, 15, 11, 7, 9, 6, 6, 10 }
int[] bag4 = GaulishMall.Shop.Selection(bagsArray, 5);    // bag4 == { 1, 3 }

int[] binarySearchArray = { 1, 3, 5, 8, 12, 42 };
int binA = GaulishMall.Shop.Binarix(binarySearchArray, 8);     // binA == 3
Console.WriteLine(binA);
int binB = GaulishMall.Shop.Binarix(binarySearchArray, 1);     // binB == 0
Console.WriteLine(binB);
int binC = GaulishMall.Shop.Binarix(binarySearchArray, 42);    // binC == 5
Console.WriteLine(binC);
int binD = GaulishMall.Shop.Binarix(binarySearchArray, 4);     // binD == 2
Console.WriteLine(binD);
int binE = GaulishMall.Shop.Binarix(binarySearchArray, 26);    // binE == 5
Console.WriteLine(binE);
int binF = GaulishMall.Shop.Binarix(binarySearchArray, -3);    // binF == 0
Console.WriteLine(binF);
int binG = GaulishMall.Shop.Binarix(binarySearchArray, 64);    // binG == 6
Console.WriteLine(binG);


int[] keys = { 9, 7, 5, 4, 2, 8, 2, 1, 3 };
GaulishMall.Shop.BubbleSort(keys);   // keys == { 1, 2, 2, 3, 4, 5, 7, 8, 9 };
foreach (var result in keys)
{
    Console.WriteLine(result);
}
*/
string compressed1 = GaulishMall.MathNMatix.Compress("abc");                           // compressed1 == "1a1b1c"
Console.WriteLine(compressed1);
string compressed2 = GaulishMall.MathNMatix.Compress("oooooooooohhhh my  Gauuuuul!!!");// compressed2 == "9o1o4h1 1m1y2 1G1a5u1l3!"
Console.WriteLine(compressed2);
string compressed3 = GaulishMall.MathNMatix.Compress("xxxxxxxxxxxxxxx");               // compressed3 == "9x6x"
Console.WriteLine(compressed3);
string compressed4 = GaulishMall.MathNMatix.Compress("");                              // compressed4 == ""
//BOOL
Console.WriteLine(compressed4 == "");