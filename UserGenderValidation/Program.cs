﻿// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please, enter your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your last name:");

string userLastname = (Console.ReadLine());

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");

}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastname}!");
}