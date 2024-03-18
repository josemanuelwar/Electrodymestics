// See https://aka.ms/new-console-template for more information
using Electrodymestics.electrodymestics;
using Electrodymestics.enums;

var lavadora = new WashingMachine();

lavadora.basePrice=100.99;
lavadora.energyConsumption="E";
lavadora.color=enumColor.BLACK;
lavadora.weight=10;
lavadora.load=50;
lavadora.checkEnergyConsumption("A");
var precio =lavadora.FinalPrice();
Console.WriteLine("----------------------------------");
Console.WriteLine("El precio de la lavadores es : ");
Console.WriteLine(precio + " Euros");
Console.WriteLine("----------------------------------");


var tv = new Television();
tv.basePrice=1400;
tv.energyConsumption="A";
tv.color=enumColor.BLACK;
tv.weight=20;
tv.resolution=60;
tv.TDT=true;
var preciotv=tv.FinalPrice();
Console.WriteLine("----------------------------------");
Console.WriteLine("El precio de la lavadores es : ");
Console.WriteLine(preciotv + " Euros");
Console.WriteLine("----------------------------------");
