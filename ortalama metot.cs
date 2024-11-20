using System;
Console.Write("öğrenci adı: ");
string ad = Console.ReadLine();

Console.Write("öğrenci soyadı");
string soyad = Console.ReadLine();

Console.Write("1.sınav notunu girin: ");

int not1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2.sınav notunu girin: ");
int not2 = Convert.ToInt32(Console.ReadLine());

double ortalama = (not1 + not2) / 2;
 Console.WriteLine(ortalama);