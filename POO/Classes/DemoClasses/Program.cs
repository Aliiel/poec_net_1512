using DemoClasses;
using System;

Chaise chaiseParDefaut = new Chaise();
Chaise chaiseAvecParams = new Chaise(6, "verre", "verte");

Console.WriteLine(chaiseParDefaut.ToString());
Console.WriteLine(chaiseAvecParams.ToString());