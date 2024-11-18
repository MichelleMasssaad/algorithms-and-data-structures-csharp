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
*/

string[] register = new[] {"Caesar", "Asterix", "Obelix", "Caesar", "Getafix", "Caesar"};
int[] result1 = GaulishMall.Shop.WhereIsCaesar("Caesar", register);   // result1 == { 0, 3, 5 }
int[] result2 = GaulishMall.Shop.WhereIsCaesar("Who?", register);    // result2 == {}
