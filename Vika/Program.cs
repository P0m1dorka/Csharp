// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a = 5; //целое число которое может быть как с минусом так и с плюсом
double b = 5.6; //число с плавующей запятой
uint c = 3; //цилое число которое может быть ТОЛЬКО ПОЛОЖИТЕЛЬНЫМ
bool f = true; //булевая переменная которая может быть или true или false
string p = "str"; //строка 

Console.WriteLine("String:" + p); //вывела строку
Console.WriteLine("Int:" + a); //вывела инт
Console.WriteLine("Double:" + b); //вывела дабл
Console.WriteLine("Uint" + c); //вывела юинт
Console.WriteLine("Bool:" + f); //вывела бул

Console.WriteLine("Сложение 5+5:" + 5+5 ); //просто сложение
Console.WriteLine("Вычитание 5-5:" + (5-5)); //просто вычитание
Console.WriteLine("Деление 5/5:" + 5/5); // целая часть от деления
Console.WriteLine("Умножение 5*5:" + 5*5 ); // просто умножение
Console.WriteLine("Процент 5%5:" + 5%5); // число которое идёт после запятой во время деления

Console.WriteLine("Вычислить (10 + 5)*2/4-9 :" + ((10 + 5)*2/4-9)); //округлила 
Console.WriteLine("Вычислить (10 + 5)*2/4-9 :" + ((double)(10 + 5)*2/4-9)); //без округления

Console.WriteLine("Вычислить 1+(7-2)*3*2-1 :" + (1+(7-2)*3*2-1)); //округление