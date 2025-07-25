using DesafioPOO.Models;

Smartphone nokia = new Nokia("12345678", "Modelo", "000000", 64);
Smartphone iphone = new Iphone("12345678", "Modelo", "000000", 64);

Console.WriteLine("=========NOKIA=========\n");
nokia.InstalarAplicativo("Snake");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine("\n=======================");

Console.WriteLine("=========IPHONE========\n");
iphone.InstalarAplicativo("GarageBand");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine("\n=======================");