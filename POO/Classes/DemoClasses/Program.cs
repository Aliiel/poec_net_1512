using DemoClasses;
using System;

Chaise chaiseParDefaut = new Chaise();
Chaise chaiseAvecParams = new Chaise(6, "verre", "verte");
Chaise chaiseAvecAutresParams = new Chaise(4, "plastique", "transparent");

Chaise[] chaises = { chaiseParDefaut, chaiseAvecParams, chaiseAvecAutresParams };

foreach (Chaise ch in chaises)
{
    Console.WriteLine(ch.ToString());
}