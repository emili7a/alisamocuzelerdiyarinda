﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





//string username = "mario";
//string password = "mario123";
//if (username == "admin" && password == "admin123")
//{
//    Console.WriteLine("xos gelmisiniz");
//}
//else
//{
//    Console.WriteLine("username ve ya password yalnisdir");
//}



//int score = 65;
//if (score > 91 && score < 100)
//{
//    Console.WriteLine("A");
//}
//else if (score > 80 && score < 90)
//{
//    Console.WriteLine("B");
//}
//else if (score > 70 && score < 79)
//{
//    Console.WriteLine("c");
//}
//else if (score > 60 && score < 69)
//{
//    Console.WriteLine("D");
//}
//else if (score > 51 && score < 59)
//{
//    Console.WriteLine("E");
//}
//else
//{
//    Console.WriteLine("Bdu telebesidirse kesilir");
//}




int number = 5;
if (number > 10 || number < 99)
{
    Console.WriteLine(" 10 ve 99 arasinda ikireqemli ededi yazin");
}
int tens = number / 10;
int units = number % 10;
if (tens > units)
{
    Console.WriteLine("onluq mertebe tekliden boyukdur");
}
else if (units > tens)
{
    Console.WriteLine("teklik onluqdan boyukdur");
}
else
{
    Console.WriteLine("beraberdirler");
}
