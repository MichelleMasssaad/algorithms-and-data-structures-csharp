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

//PARTIE FAUUUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
int[] bagsArray = { 1, 16, 15, 11, 7, 9, 6, 6, 3, 10 };
int[] bag1 = GaulishMall.Shop.Selection(bagsArray, 50);   // bag1 == { 1, 16, 15, 11, 7 }
int[] bag2 = GaulishMall.Shop.Selection(bagsArray, 33);   // bag2 == { 1, 16, 15 }
int[] bag3 = GaulishMall.Shop.Selection(bagsArray, 80);   // bag3 == { 16, 15, 11, 7, 9, 6, 6, 10 }
int[] bag4 = GaulishMall.Shop.Selection(bagsArray, 5);    // bag4 == { 1, 3 }
*/
int[] binarySearchArray = { 1, 3, 5, 8, 12, 42 };
int binA = GaulishMall.Shop.Binarix(binarySearchArray, 8);     // binA == 3
int binB = GaulishMall.Shop.Binarix(binarySearchArray, 1);     // binB == 0
int binC = GaulishMall.Shop.Binarix(binarySearchArray, 42);    // binC == 5
int binD = GaulishMall.Shop.Binarix(binarySearchArray, 4);     // binD == 2
int binE = GaulishMall.Shop.Binarix(binarySearchArray, 26);    // binE == 5
int binF = GaulishMall.Shop.Binarix(binarySearchArray, -3);    // binF == 0
int binG = GaulishMall.Shop.Binarix(binarySearchArray, 64);    // binG == 6
