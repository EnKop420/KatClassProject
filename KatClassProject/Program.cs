// See https://aka.ms/new-console-template for more information
using KatClassProject;

Kat katFarve = new("grå");

Console.WriteLine("farven på katten er " + katFarve.Farve);
Console.WriteLine("Efter lidt tid blev katten " + katFarve.changeColor());