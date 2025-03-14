// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.ExceptionServices;
using System.Xml;

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






//int[] ededler = { 12, 13, 14, 15, 16, 17, 18 };
//int cem = 0;
//foreach (int Num in nums) ;
//{
//    sum += num;
//}
//double average = (double)sum / (double)nums.Length;
//Console.WriteLine("array elementlerinin orta qiymeti");


//int[] Nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
//Console.WriteLine("arraydeki cut ededler");
//for (int i = 0; i < nums.Length; i++) ;
//if (num % 2 == 0)
//{
//    Console.WriteLine("eded");
//}




//int[] nums = { 1, 2, 3, 4, 5, 6 };
//int Sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    sum += nums[i];
//}
//Console.WriteLine("massivdeki elementlerin cemi");




//int number = 5;
//if (number > 10 || number < 99)
//{
//    Console.WriteLine(" 10 ve 99 arasinda ikireqemli ededi yazin");
//}
//int tens = number / 10;
//int units = number % 10;
//if (tens > units)
//{
//    Console.WriteLine("onluq mertebe tekliden boyukdur");
//}
//else if (units > tens)
//{
//    Console.WriteLine("teklik onluqdan boyukdur");
//}
//else
//{
//    Console.WriteLine("beraberdirler");
//}






//int num1 = 12;
//int num2 = 24;
//int sum = num1 + num2;
//if (num1 % 2 == 0 && num2 % 2 == 0)
//{
//    Console.WriteLine("eded qaliqiz bolunur");
//}
//else
//{
//    Console.WriteLine("daxil olan eded cut olmalidir");
//}




//int[] array = { 3, 6, 9, 12, 15, 17, 21, 24, 27, 30 };
//int count = 0;
//foreach ( int num in array)
//if ( num % 2 !=0 && num % 3==0)
//    {
//        count++;
//    }
//{
//    Console.WriteLine("hem tek hemde 3e bolunen ededler" + count);
//}


int[] array = { 5, 12, 3, 9, 21, 7, };
int min = 0;
int max = 0;
foreach (int num in array)
{
    if (num < min)
       min = num;
    if (num > max)
        max = num;
}
int sum = min + max;
Console.WriteLine(" en min eded" +min);
Console.WriteLine("en max eded"+ max);
Console.WriteLine("cem"+ sum);
